using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public partial class Utils
{
    [DllImport(dllName: "Shcore", CallingConvention = CallingConvention.Cdecl)]
    private static extern int SetProcessDpiAwareness(HighDpiMode value);

    public static void WindowsSetDpiAwareness(HighDpiMode value)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            SetProcessDpiAwareness(value);
    }
}

public enum HighDpiMode
{
    DpiUnaware,
    SystemAware,
    PerMonitor,
}