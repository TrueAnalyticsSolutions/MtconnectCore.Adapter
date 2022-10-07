// See https://aka.ms/new-console-template for more information
using ConsoulLibrary;
using MtconnectCore.Adapter;
using MtconnectCore.Adapter.DataItems;
using SampleAdapter.PC;
using System.Drawing;
using System.Threading;

namespace SampleAdapter
{
    public static class Program
    {
        private const string AVAILABILITY = "avail";
        private const string X_POSITION = "xpos";
        private const string Y_POSITION = "ypos";
        private const string PROGRAM = "prog";

        public static Dictionary<string, DataItem> DataItems { get; set; } = new Dictionary<string, DataItem>();

        public static System.Timers.Timer Timer { get; set; } = new System.Timers.Timer();

        public static Adapter Adapter { get; set; } = new Adapter();

        public static void Main(string[] args)
        {
            Timer.Interval = 1000;
            Timer.Elapsed += Timer_Elapsed;

            DataItems.Add(AVAILABILITY, new Event(AVAILABILITY));
            DataItems.Add(X_POSITION, new Event(X_POSITION));
            DataItems.Add(Y_POSITION, new Event(Y_POSITION));
            DataItems.Add(PROGRAM,  new Event(PROGRAM));

            foreach (var item in DataItems)
            {
                Adapter.AddDataItem(item.Value);
            }

            Timer.Start();
            Adapter.Start();
            Adapter.Begin();

            Consoul.Write("Reporting: AVAILABILITY, Mouse X-Position, Mouse Y-Position, Active Window Title");
            Consoul.Write($"Adapter running @ http://*:{Adapter.Port}");
            Consoul.Wait();

            Timer.Stop();
            Adapter.Stop();
        }

        private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            DataItems[AVAILABILITY].Value = "AVAILABLE";

            Point lpPoint;
            if (WindowHandles.GetCursorPos(out lpPoint))
            {
                DataItems[X_POSITION].Value = lpPoint.X;
                DataItems[Y_POSITION].Value = lpPoint.Y;
            } else
            {
                DataItems[X_POSITION].Unavailable();
                DataItems[Y_POSITION].Unavailable();
            }

            try
            {
                string activeWindowTitle = WindowHandles.GetActiveWindowTitle();
                if (!string.IsNullOrEmpty(activeWindowTitle))
                {
                    DataItems[PROGRAM].Value = activeWindowTitle;
                } else {
                    DataItems[PROGRAM].Unavailable();
                }
            }
            catch (Exception ex)
            {
                DataItems[PROGRAM].Unavailable();
            }

            Adapter.SendChanged();
        }
    }
}