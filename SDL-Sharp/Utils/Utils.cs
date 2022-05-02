using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public partial class Utils
{
    public static void AddEnvironmentPath(string path)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath(path));
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(path));
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(path));  
    }
}
