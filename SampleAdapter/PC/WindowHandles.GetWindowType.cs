namespace SampleAdapter.PC
{
    public static partial class WindowHandles
    {
        public enum GetWindowType : uint
        {
            GW_HWNDFIRST,
            GW_HWNDLAST,
            GW_HWNDNEXT,
            GW_HWNDPREV,
            GW_OWNER,
            GW_CHILD,
            GW_ENABLEDPOPUP,
        }
    }
}
