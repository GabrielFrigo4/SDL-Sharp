﻿using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public static class LinuxUtils
{
    /// <summary>
    /// Add environment path in this process on Linux
    /// </summary>
    /// <param name="path"></param>
    public static void AddEnvironmentPath(string path)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return;
        string linux_path = path.Replace(@"\", @"/");
        Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(linux_path));
    }
}
