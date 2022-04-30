using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
public static partial class SDL
{
    private const string LibraryName = "SDL2";

    static SDL()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath("./runtimes/win-x64/native/"));
            }
            if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
            {
                Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath("./runtimes/win-x86/native/"));
            }
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath("./runtimes/linux-x64/native/"));
            }
            if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
            {
                Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath("./runtimes/linux-x86/native/"));
            }
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + ";" + Path.GetFullPath("./runtimes/osx-x64/native/"));
            }
        }

        NativeLibrary.SetDllImportResolver(typeof(SDL).Assembly, ResolveDllImport);
    }

    private static IntPtr ResolveDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        IntPtr _handle = default;

        if (_handle == IntPtr.Zero)
        {
            foreach (var path in GetSearchPaths(assembly, libraryName))
            {
                if (path != null && NativeLibrary.TryLoad(path, out _handle))
                {
                    return _handle;
                }
            }
        }

        return _handle;
    }

    private static IEnumerable<string> GetSearchPaths(Assembly assembly, string libraryName)
    {
        string libName = GetNativeLibraryName(libraryName);

        // Try loading from runtimes/<rid>/native/<lib-name>
        yield return Path.Combine(
        Path.GetDirectoryName(assembly.Location),
        "runtimes",
        GetRuntimeIdentifier(),
        "native",
        libName);

        // Finally, just try the name of the library
        yield return libName;
    }

    private static string GetRuntimeIdentifier()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                return "win-x64";
            }

            if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
            {
                return "win-x86";
            }
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                return "linux-x64";
            }

            if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
            {
                return "linux-x86";
            }
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return "osx-x64";
        }

        throw new PlatformNotSupportedException();
    }

    private static string GetNativeLibraryName(string baseName)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return $"{baseName}.dll";
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return $"lib{baseName}-2.0.so.0";
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return $"lib{baseName}.dylib";
        }

        throw new PlatformNotSupportedException();
    }
}
