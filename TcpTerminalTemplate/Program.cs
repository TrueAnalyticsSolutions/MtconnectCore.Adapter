using ConsoulLibrary;
using Microsoft.Extensions.Logging;
using Mtconnect;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.DeviceConfiguration;
using Mtconnect.AdapterSourceTemplate;

namespace TcpTerminal
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(o => { o.AddConsoulLogger(); o.SetMinimumLevel(LogLevel.Debug); });

            var options = new TcpAdapterOptions();
            options.UpdateFromConfig();

            using(var adapter = new TcpAdapter(options, new AdapterLogger(loggerFactory)))
            {
                adapter.Start(new AdvancedAdapterDataModelSource());

                Task.Run(() => SaveDevices(adapter));
                
                Consoul.Write($"Adapter running @ http://*:{adapter.Port}");

                if (File.Exists(PUTTY_EXE) && Consoul.Ask("Would you like to run PuTTY?"))
                    StartPuTTY(adapter.Port);

                Consoul.Wait();

                adapter.Stop();
            }
        }
        private class AdapterLogger : IAdapterLogger
        {
            private readonly ILogger _logger;
            public AdapterLogger(ILoggerFactory loggerFactory)
            {
                _logger = loggerFactory.CreateLogger<AdapterLogger>();
            }
            public void LogDebug(string message, params object[] args)
                => _logger.LogDebug(message, args);

            public void LogError(string message, params object[] args)
                => _logger.LogError(message, args);

            public void LogError(Exception exception, string message, params object[] args)
                => _logger.LogError(exception, message, args);

            public void LogInformation(string message, params object[] args)
                => _logger.LogInformation(message, args);

            public void LogTrace(string message, params object[] args)
                => _logger.LogTrace(message, args);

            public void LogWarning(string message, params object[] args)
                => _logger.LogWarning(message, args);

            public void LogWarning(Exception exception, string message, params object[] args)
                => _logger.LogWarning(message, args);
        }
        private static void SaveDevices(TcpAdapter adapter)
        {
            System.Threading.Thread.Sleep(5_000);
            var dcf = new DeviceModelFactory();
            var doc = dcf.Create(adapter);
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Devices.xml");
            doc.Save(filename);
        }

        private const string PUTTY_EXE = "C:\\Program Files\\PuTTY\\putty.exe";
        private const string CMD_EXE = "C:\\windows\\system32\\cmd.exe";
        private static void StartPuTTY(int port)
        {
            using (var cmd = new System.Diagnostics.Process())
            {
                cmd.StartInfo.FileName = CMD_EXE;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;

                cmd.Start();

                cmd.StandardInput.WriteLine($"\"{PUTTY_EXE}\" -raw -P {port} localhost");
            }
        }
    }
}