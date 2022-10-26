using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        public static string EncryptScript(string certLocation, string rawScript)
        {
            Func<object, object> func = CSharpScript.EvaluateAsync<Func<object, object>>(rawScript).Result;
            if (func == null) throw new Exception("Cannot evaluate script into Func<object, object>");

            string encryptedScript = Cryptography.ConfigurationEncrypter.Encrypt(certLocation, rawScript);

            return encryptedScript;
        }

        public static Func<object, object> DecryptScript(string encryptedScript)
        {
            string decryptedScript = Cryptography.ConfigurationDecrypter.Decrypt(encryptedScript);

            Func<object, object> func = CSharpScript.EvaluateAsync<Func<object, object>>(decryptedScript).Result;

            return func;
        }
    }

}
