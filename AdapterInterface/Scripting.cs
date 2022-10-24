using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Mtconnect.AdapterInterface
{
    /// <summary>
    /// Helper class for handling scripting of the Adapter.
    /// </summary>
    public static class Scripting
    {
        private const int KeySize = 256;
        private const int DerivationIterations = 1_000;
        private const int ByteSize = 8;
        private const int takeSize = KeySize / ByteSize;
        private const string CertificateName = "MtconnectAdapterScript";

        /// <summary>
        /// Encrypts raw scripts using a specific passcode.
        /// </summary>
        /// <param name="rawScript">Raw C# script for a <c>Func&lt;object, object&gt;</c>.</param>
        /// <param name="passcode">The passcode for encrypting the script.</param>
        /// <returns>Encrypted C# script.</returns>
        public static string EncryptScript(string rawScript, string passcode)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            byte[] saltBytes = Generate256BitsOfRandomEntropy();
            byte[] ivBytes = Generate256BitsOfRandomEntropy();
            byte[] textBytes = Encoding.UTF8.GetBytes(rawScript);
            using (var password = new Rfc2898DeriveBytes(passcode, saltBytes, DerivationIterations))
            {
                byte[] keyBytes = password.GetBytes(ByteSize);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = KeySize;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, ivBytes))
                    using (var memoryStream = new MemoryStream())
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(textBytes, 0, textBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                        byte[] cipherBytes = saltBytes;
                        cipherBytes = cipherBytes.Concat(ivBytes).ToArray();
                        cipherBytes = cipherBytes.Concat(memoryStream.ToArray()).ToArray();
                        memoryStream.Close();
                        cryptoStream.Close();
                        return Convert.ToBase64String(cipherBytes);
                    }
                }
            }
        }

        /// <inheritdoc cref="EncryptScript(string, string)" path="/summary"/>
        /// <param name="rawScript"><inheritdoc cref="EncryptScript(string, string)" path="/param[@name='rawScript']"/></param>
        /// <returns><inheritdoc cref="EncryptScript(string, string)" path="/returns"/></returns>
        public static string EncryptScript(string rawScript)
        {
            var certificate = getCertificate(CertificateName);

            return EncryptScript(rawScript, certificate.PublicKey.ToString());
        }

        /// <summary>
        /// Decrypts an encrypted C# script.
        /// </summary>
        /// <param name="encryptedScript">Encrypted C# script for a <c>Func&lt;object, object&gt;</c>.</param>
        /// <param name="passcode">The passcode for decrypting the script.</param>
        /// <returns>Decrypted C# script.</returns>
        public static Func<object, object> DeserializeScript(string encryptedScript, string passcode)
        {
            string decryptedScript = decryptString(encryptedScript, passcode);

            Func<object, object> func = CSharpScript.EvaluateAsync<Func<object, object>>(decryptedScript).Result;

            return func;
        }

        /// <inheritdoc cref="DeserializeScript(string, string)" path="/summary"/>
        /// <param name="encryptedScript"><inheritdoc cref="DeserializeScript(string, string)" path="/param[@name='encryptedScript']"/></param>
        /// <returns><inheritdoc cref="DeserializeScript(string, string)" path="/returns"/></returns>
        public static Func<object, object> DeserializeScript(string encryptedScript)
        {
            var certificate = getCertificate(CertificateName);

            return DeserializeScript(encryptedScript, certificate.PublicKey.ToString());
        }

        private static string decryptString(string source, string passcode)
        {
            int skipSize = 0;

            var saltedScript = Convert.FromBase64String(source);
            var saltedBytes = saltedScript.Take(takeSize).ToArray();
            skipSize = takeSize;

            var ivBytes = saltedScript.Skip(skipSize).Take(takeSize).ToArray();
            skipSize += takeSize;

            var textBytes = saltedScript.Skip(skipSize).Take(saltedScript.Length - skipSize).ToArray();

            using (var password = new Rfc2898DeriveBytes(passcode, saltedBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(takeSize);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = KeySize;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivBytes))
                    using (var memoryStream = new MemoryStream(textBytes))
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    using (var streamReader = new StreamReader(cryptoStream, Encoding.UTF8))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        private static X509Certificate2 getCertificate(string name)
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection certificates = store.Certificates.Find(X509FindType.FindBySubjectName, name, false);
            if (certificates.Count == 1)
            {
                return certificates[0];
            } else if (certificates.Count > 1)
            {
                throw new Exception($"More than one certificate with name '{name}' found in store LocalMachine/My.");
            } else
            {
                throw new Exception($"Certificate '{name}' not found in store LocalMachine/My.");
            }
        }
    }
}
