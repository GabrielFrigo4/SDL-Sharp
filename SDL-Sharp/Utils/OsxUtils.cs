using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public static class OsxUtils
{
    /// <summary>
    /// Add environment path in this process on OSX
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return;
        Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(path));
    }
}
