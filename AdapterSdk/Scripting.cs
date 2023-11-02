using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Threading.Tasks;

namespace Mtconnect.AdapterSdk.Cryptography
{
    /// <summary>
    /// Helper class for handling scripting of the Adapter.
    /// </summary>
    public static class Scripting
    {
        /// <summary>
        /// Encrypts the provided text.
        /// </summary>
        /// <param name="certLocation">Location of the secret certificate</param>
        /// <param name="rawScript">Raw text</param>
        /// <returns>Task for encrypting the provided text</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<string> EncryptScript(string certLocation, string rawScript)
        {
            var options = ScriptOptions.Default;
            options = options.AddReferences(AppDomain.CurrentDomain.GetAssemblies());
            options.AddImports("System");
            Func<object, object> func = await CSharpScript.EvaluateAsync<Func<object, object>>(rawScript, options);
            if (func == null) throw new Exception("Cannot evaluate script into Func<object, object>");

            string encryptedScript = Cryptography.ConfigurationEncrypter.Encrypt(certLocation, rawScript);

            return encryptedScript;
        }

        /// <summary>
        /// Decrypts the provided encrypted text.
        /// </summary>
        /// <param name="encryptedScript">Encrypted text</param>
        /// <returns>Task for decrypting the provided text</returns>
        public static async Task<Func<object, object>> DecryptScript(string encryptedScript)
        {
            var options = ScriptOptions.Default;
            //options = options.AddReferences(AppDomain.CurrentDomain.GetAssemblies());
            options.AddImports("System");
            string decryptedScript = Cryptography.ConfigurationDecrypter.Decrypt(encryptedScript);

            Func<object, object> func = await CSharpScript.EvaluateAsync<Func<object, object>>(decryptedScript, options);

            return func;
        }
    }

}
