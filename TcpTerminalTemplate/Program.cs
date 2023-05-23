using ConsoulLibrary;
using Microsoft.Extensions.Logging;
using Mtconnect;
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

            using(var adapter = new TcpAdapter(options, loggerFactory))
            {
                adapter.Start(new BasicAdapterDataModelSource());

                Task.Run(() => SaveDevices(adapter));
                
                Consoul.Write($"Adapter running @ http://*:{adapter.Port}");

                if (File.Exists(PUTTY_EXE) && Consoul.Ask("Would you like to run PuTTY?"))
                    StartPuTTY(adapter.Port);

                Consoul.Wait();

                adapter.Stop();
            }
        }
        private static async void SaveDevices(TcpAdapter adapter)
        {
            System.Threading.Thread.Sleep(5000);
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