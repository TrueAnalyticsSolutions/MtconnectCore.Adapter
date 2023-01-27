using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mtconnect.AdapterInterface
{
    /// <summary>
    /// Helper class for handling scripting of the Adapter.
    /// </summary>
    public static class Scripting
    {
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
