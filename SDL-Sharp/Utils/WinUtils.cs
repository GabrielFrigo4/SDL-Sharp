using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public unsafe static class WinUtils
{
    [DllImport(dllName: "Shcore", CallingConvention = CallingConvention.Cdecl)]
    private static extern int SetProcessDpiAwareness(WinHighDpiMode value);

    [DllImport("dwmapi.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int* attrValue, int attrSize);
    private const int DwmwaUseImmersiveDarkMode = 20;

    /// <summary>
    /// Set dpi awareness in Windows
    /// </summary>
    /// <param name="value"></param>
    public static void SetDpiAwareness(WinHighDpiMode value)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
        SetProcessDpiAwareness(value);
    }

    /// <summary>
    /// Set dpi awareness in Windows
    /// </summary>
    /// <param name="value"></param>
    public static void SetWindowTheme(Window window, WinTheme theme)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
        SysWMInfo wmInfo;
        SDL.GetVersion(&wmInfo.Version);
        SDL.GetWindowWMInfo(window, &wmInfo);
        int useImmersiveDarkMode = (int)theme;
        _ = DwmSetWindowAttribute(wmInfo.Info.Win.Window,
            DwmwaUseImmersiveDarkMode, &useImmersiveDarkMode, sizeof(int));
    }

    /// <summary>
    /// Add environment path in this process on Windows
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
        string win_path = path.Replace(@"/", @"\");
        Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath(win_path));
    }
}

public enum WinHighDpiMode
{
    DpiUnaware,
    SystemAware,
    PerMonitor,
}

public enum WinTheme:int
{
    Light = 0,
    Dark = 1,
}