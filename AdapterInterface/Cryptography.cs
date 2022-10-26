using System;
using System.Collections.Generic;
using System.Text;

namespace Mtconnect.AdapterInterface.Cryptography
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;


    /*
     * Please see ConfigurationEncrypter for a summary of how encryption works
     */
    public class ConfigurationDecrypter
    {
        public static string Decrypt(string ciphertext)
        {
            // Convert the Base64 string into an encryption result
            EncryptionResult encryptionResult = DeserializeFromBase64String(ciphertext);

            // Access the certificate store
            X509Certificate2 cert = LocateCertificate(encryptionResult.CertificateThumbprint);

            // Create an RSA cryptography provider class using the certificate provided
            var rsaCryptoProvider = (RSA)cert.PrivateKey;
            Trace.WriteLine("PrivateKey retrieved");

            // Create a Rijndael encryption class with the same details as the encryption
            var rjndl = new RijndaelManaged { KeySize = 256, BlockSize = 128, Mode = CipherMode.CBC };

            // Decrypt the Rijndael key using the certificate

            var keyDecrypted = rsaCryptoProvider.Decrypt(encryptionResult.Key, RSAEncryptionPadding.OaepSHA512);

            // Create the Rijndael decryption transformer using the decrypted Rijndael key
            var transform = rjndl.CreateDecryptor(keyDecrypted, encryptionResult.InitializationVector);
            Trace.WriteLine("Decryptor created");

            // Decrypt the string and return
            return DecryptString(encryptionResult.Value, transform);
        }

        private static X509Certificate2 LocateCertificate(string certificateThumbprint)
        {
            try
            {
                return OpenCertificateStore(StoreName.My, StoreLocation.CurrentUser, certificateThumbprint);
            }
            catch (Exception)
            {
                Trace.WriteLine("No access to My : CurrentUser");
            }

            try
            {
                return OpenCertificateStore(StoreName.My, StoreLocation.LocalMachine, certificateThumbprint);
            }
            catch (Exception)
            {
                Trace.WriteLine("No access to My : LocalMachine");
            }

            throw new Exception("Could not locate certificate");
        }

        private static X509Certificate2 OpenCertificateStore(StoreName storeName, StoreLocation storeLocation, string certificateThumbprint)
        {
            var store = new X509Store(storeName, storeLocation);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
            Trace.WriteLine("Store Opened");

            // Locate the private key in the store, using the unique thumbprint of the certificate
            // It is not possible to do a "single" search on the store, even with a unique ID
            var matches = store.Certificates.Find(X509FindType.FindByThumbprint, certificateThumbprint, false); // You should use a thumbprint instead of name here

            if (matches.Count == 0)
            {
                throw new Exception("Certificate not found");
            }

            if (matches.Count > 1)
            {
                throw new Exception("Multiple certificates found");
            }

            store.Close();

            return matches[0];
        }

        private static string DecryptString(byte[] cipherText, ICryptoTransform decryptor)
        {
            // We return the plaintext as a string to allow easy use
            string plaintext;

            // The CryptoStream needs to do it's transformations into a stream
            using (var plaintextStream = new MemoryStream(cipherText))
            {
                // Cryptostream actually does the decryption, turning the ciphertext into plaintext
                using (var decryptionTransformationStream = new CryptoStream(plaintextStream, decryptor, CryptoStreamMode.Read))
                {
                    // We need to read the decryptionTransformationStream to get the plaintext
                    using (var decryptionTransformationStreamReader = new StreamReader(decryptionTransformationStream))
                    {
                        // Read the decryptionTransformationStream to get the plaintext
                        plaintext = decryptionTransformationStreamReader.ReadToEnd();
                    }
                }
            }

            // return the plaintext
            return plaintext;
        }

        private static EncryptionResult DeserializeFromBase64String(string base64String)
        {
            // Convert the Base64 string into an EncryptionResult
            EncryptionResult result;

            using (var ms = new MemoryStream(Convert.FromBase64String(base64String)))
            {
                ms.Seek(0, SeekOrigin.Begin);
                result = (EncryptionResult)new BinaryFormatter().Deserialize(ms);
            }

            return result;
        }
    }

    /*         
     * A QUICK OVERVIEW OF ENCRYPTION
     * 
     * RSA can only encrypt strings up to a certain length "Messages must not be longer than the N of the public key."
     * To get around this, we instead use two step encryption. Rijndael is a symmetric encryption method that can encrypt
     * a string of any length. We will use Rijndael to encrypt the input string. We then encrypt the single use Rijndael key with RSA.
     * We store this key, Rijndael Initialization Vector, the certificate we used to encrypt with's thumbprint and the Rijndael
     * encrypted data in a Base64 string. This string can then be used in the place of the original data.
     * 
     * Using this method, we can encrypt a string of any length asymmetrically.
     */
    public class ConfigurationEncrypter
    {
        public static string Encrypt(string certificateLocation, string plaintext)
        {
            // Create a Rijndael encryption class with a fixed keysize so that it can be encrypted with RSA
            var rjndl = new RijndaelManaged { KeySize = 256, BlockSize = 128, Mode = CipherMode.CBC };
            var transform = rjndl.CreateEncryptor();

            // Create an RSA cryptography provider class using the certificate provided
            var cert = new X509Certificate2(certificateLocation);

            var rsaEncryptor = (RSA)cert.PublicKey.Key;

            // Take the Rijndael key and encrypt it with RSA
            var keyEncrypted = rsaEncryptor.Encrypt(rjndl.Key, RSAEncryptionPadding.OaepSHA512);
            if (keyEncrypted == null)
            {
                // If we've been given an invalid certificate we should throw an error
                throw new Exception("Encrypted key was null. Invalid certificate?");
            }

            // Encrypt the string
            var inputEncrypted = EncryptString(plaintext, transform);

            // Serialize and save the Encryption result which contains all our required information
            return SerializeToBase64String(new EncryptionResult { Key = keyEncrypted, InitializationVector = rjndl.IV, Value = inputEncrypted, CertificateThumbprint = cert.Thumbprint });
        }

        private static byte[] EncryptString(string plaintext, ICryptoTransform transform)
        {
            // We'll store the ciphertext (encrypted string) in a byte array to avoid lots of swapping from string to byte array
            byte[] ciphertext;

            // The CryptoStream needs to do it's transformations into a stream
            using (var ciphertextStream = new MemoryStream())
            {
                // Cryptostream actually does the encryption, turning the plaintext into ciphertext
                using (var encryptionTransformationStream = new CryptoStream(ciphertextStream, transform, CryptoStreamMode.Write))
                {
                    // We need to write the plaintext into the encryptionTransformationStream
                    using (var encryptionTransformationStreamWriter = new StreamWriter(encryptionTransformationStream))
                    {
                        // Write the plaintext to the encryptionTransformationStream which outputs ciphertext into the ciphertextStream
                        encryptionTransformationStreamWriter.Write(plaintext);
                    }

                    // Store the ciphertext into the byte array
                    ciphertext = ciphertextStream.ToArray();
                }
            }

            // Return the ciphertext
            return ciphertext;
        }

        private static string SerializeToBase64String(EncryptionResult encryptionResult)
        {
            // Convert the EncryptionResult object into a base64 string
            using (var ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, encryptionResult);
                ms.Seek(0, SeekOrigin.Begin);
                var base64String = Convert.ToBase64String(ms.ToArray());
                return base64String;
            }
        }
    }

    [Serializable]
    internal class EncryptionResult
    {
        internal byte[] Key { get; set; }

        internal byte[] InitializationVector { get; set; }

        internal byte[] Value { get; set; }

        internal string CertificateThumbprint { get; set; }
    }
}
