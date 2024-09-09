using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public static class FreeBdsUtils
{
    /// <summary>
    /// Add environment path in this process on FreeBSD
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)) return;
        string freebsd_path = path.Replace(@"\", @"/");
        Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(freebsd_path));
    }
}
