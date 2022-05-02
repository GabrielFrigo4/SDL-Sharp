using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public class WinUtils
{
    [DllImport(dllName: "Shcore", CallingConvention = CallingConvention.Cdecl)]
    private static extern int SetProcessDpiAwareness(WinHighDpiMode value);

    /// <summary>
    /// Set dpi awareness in Windows
    /// </summary>
    /// <param name="value"></param>
    public static void SetDpiAwareness(WinHighDpiMode value)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            SetProcessDpiAwareness(value);
    }

    /// <summary>
    /// Add environment path in this process on Windows
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath(path));
    }
}

public enum WinHighDpiMode
{
    DpiUnaware,
    SystemAware,
    PerMonitor,
}