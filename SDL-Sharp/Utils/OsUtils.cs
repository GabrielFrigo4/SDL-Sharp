using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public static class OsUtils
{
    /// <summary>
    /// Get operating system platform
    /// </summary>
    public static OSPlatform OSPlatform
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
            else
                throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Add environment path in this process for any operate system
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        if (OSPlatform == OSPlatform.Windows)
            WinUtils.AddEnvironmentPath(path);
        if (OSPlatform == OSPlatform.Linux)
            LinuxUtils.AddEnvironmentPath(path);
        if (OSPlatform == OSPlatform.OSX)
            OsxUtils.AddEnvironmentPath(path);
        if (OSPlatform == OSPlatform.FreeBSD)
            FreeBdsUtils.AddEnvironmentPath(path);
    }
}