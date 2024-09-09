using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public static class OsUtils
{
    /// <summary>
    /// Get operating system platform
    /// </summary>
    public OSPlatform OSPlatform
    {
        get 
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return OSPlatform.Windows;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return OSPlatform.Linux;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return OSPlatform.OSX;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
                return OSPlatform.FreeBSD;
        }
    }

    /// <summary>
    /// Add environment path in this process for any operate system
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        switch (OSPlatform) {
            case OSPlatform.Windows:
                WinUtils.AddEnvironmentPath(path);
                break;
            case OSPlatform.Linux:
                LinuxUtils.AddEnvironmentPath(path);
                break;
            case OSPlatform.OSX:
                OsxUtils.AddEnvironmentPath(path);
                break;
            case OSPlatform.FreeBSD:
                FreeBdsUtils.AddEnvironmentPath(path);
                break;
        }
    }
}