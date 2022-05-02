using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Utility;
public partial class Utils
{
    public static void OsxAddEnvironmentPath(string path)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ":" + Path.GetFullPath(path));
    }
}
