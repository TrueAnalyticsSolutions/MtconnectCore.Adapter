using System.Runtime.InteropServices;

namespace SampleAdapter.PC
{
    public static partial class WindowHandles
    {
        public class SystemPower
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool GetSystemPowerStatus(
              out WindowHandles.SystemPower.SystemPowerStatus sps);

            public bool ACPowerPluggedIn()
            {
                WindowHandles.SystemPower.SystemPowerStatus sps = new WindowHandles.SystemPower.SystemPowerStatus();
                WindowHandles.SystemPower.GetSystemPowerStatus(out sps);
                return sps.LineStatus == WindowHandles.SystemPower.ACLineStatus.Online;
            }

            public int BatteryCharge()
            {
                WindowHandles.SystemPower.SystemPowerStatus sps = new WindowHandles.SystemPower.SystemPowerStatus();
                WindowHandles.SystemPower.GetSystemPowerStatus(out sps);
                return (int)sps.BatteryLifePercent;
            }

            public enum ACLineStatus : byte
            {
                Offline = 0,
                Online = 1,
                Unknown = 255, // 0xFF
            }

            public enum BatteryFlag : byte
            {
                High = 1,
                Low = 2,
                Critical = 4,
                Charging = 8,
                NoSystemBattery = 128, // 0x80
                Unknown = 255, // 0xFF
            }

            public struct SystemPowerStatus
            {
                public WindowHandles.SystemPower.ACLineStatus LineStatus;
                public WindowHandles.SystemPower.BatteryFlag flgBattery;
                public byte BatteryLifePercent;
                public byte Reserved1;
                public int BatteryLifeTime;
                public int BatteryFullLifeTime;
            }
        }
    }
}
