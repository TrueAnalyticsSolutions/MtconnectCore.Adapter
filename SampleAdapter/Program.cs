// See https://aka.ms/new-console-template for more information
using ConsoulLibrary;
using MtconnectCore.AdapterInterface.DataItems;
using MtconnectCore.TcpAdapter;
using SampleAdapter.PC;
using System.Drawing;

namespace SampleAdapter
{
    public static class Program
    {
        private const string AVAILABILITY = "avail";
        private const string X_POSITION = "xpos";
        private const string Y_POSITION = "ypos";
        private const string PROGRAM = "prog";

        private const string PUTTY_EXE = "C:\\Program Files\\PuTTY\\putty.exe";
        private const string CMD_EXE = "C:\\windows\\system32\\cmd.exe";

        public static System.Timers.Timer Timer { get; set; } = new System.Timers.Timer();

        public static TcpAdapter Adapter { get; set; } = new TcpAdapter();

        public static void Main(string[] args)
        {
            Timer.Interval = 50;
            Timer.Elapsed += Timer_Elapsed;

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

            Timer.Stop();
            Adapter.Stop();
        }

        private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Adapter[AVAILABILITY].Value = "AVAILABLE";

            Point lpPoint;
            if (WindowHandles.GetCursorPos(out lpPoint))
            {
                Adapter[X_POSITION].Value = lpPoint.X;
                Adapter[Y_POSITION].Value = lpPoint.Y;
            } else
            {
                Adapter[X_POSITION].Unavailable();
                Adapter[Y_POSITION].Unavailable();
            }

            try
            {
                string activeWindowTitle = WindowHandles.GetActiveWindowTitle();
                if (!string.IsNullOrEmpty(activeWindowTitle))
                {
                    Adapter[PROGRAM].Value = activeWindowTitle;
                } else {
                    Adapter[PROGRAM].Unavailable();
                }
            }
            catch (Exception ex)
            {
                Adapter[PROGRAM].Unavailable();
            }

            Adapter.Send(MtconnectCore.AdapterInterface.Contracts.DataItemSendTypes.Changed);
        }
    }
}