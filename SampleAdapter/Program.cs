// See https://aka.ms/new-console-template for more information
using ConsoulLibrary;
using Mtconnect;
using Mtconnect.AdapterInterface.DataItems;
using SampleAdapter.PC;
using System.Drawing;

namespace SampleAdapter
{
    public static class Program
    {
        private const string PUTTY_EXE = "C:\\Program Files\\PuTTY\\putty.exe";
        private const string CMD_EXE = "C:\\windows\\system32\\cmd.exe";


        public static TcpAdapter Adapter { get; set; } = new TcpAdapter();

        public static PCModel Model { get; set; } = new PCModel();

        public static void Main(string[] args)
        {

            Adapter.AddDataItem(new Event(AVAILABILITY));
            Adapter.AddDataItem(new Sample(X_POSITION));
            Adapter.AddDataItem(new Sample(Y_POSITION));
            Adapter.AddDataItem(new Event(PROGRAM));

            Timer.Start();

            Adapter.Start();

            Consoul.Write("Reporting: AVAILABILITY, Mouse X-Position, Mouse Y-Position, Active Window Title");
            Consoul.Write($"Adapter running @ http://*:{Adapter.Port}");

            if (File.Exists(PUTTY_EXE) && Consoul.Ask("Would you like to run PuTTY?"))
            {
                using (var cmd = new System.Diagnostics.Process())
                {
                    cmd.StartInfo.FileName = CMD_EXE;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;

                    cmd.Start();

                    cmd.StandardInput.WriteLine($"\"{PUTTY_EXE}\" -raw -P {Adapter.Port} localhost");
                }
            }

            Consoul.Wait();

            Adapter.Stop();
        }
    }
}