using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public partial class Utils
{
    public static void LinuxAddEnvironmentPath(string path)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(path));
    }
}
