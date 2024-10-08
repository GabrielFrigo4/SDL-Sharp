using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SDL_Sharp.Utility;

namespace SDL_Sharp.Loader;

public static class SdlLoader
{
    /// <summary>
    /// Default Dll Import Resolver for the SDL-Sharp library.
    /// Currently, supports Windows, Linux, and OSX. Only x64 and x86 architectures are supported for now.
    /// 
    /// Consider calling this method before using any SDL-Sharp functionality. Otherwise you can load them manually yourself.
    /// </summary>
    /// <exception cref="PlatformNotSupportedException">When the current platform is not supported</exception>
    public static void LoadDefault()
    {
        if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
        {
            WinUtils.AddEnvironmentPath(@".\runtimes\win-x64\native\");
            LinuxUtils.AddEnvironmentPath(@"./runtimes/linux-x64/native/");
            OsxUtils.AddEnvironmentPath(@"./runtimes/osx-x64/native/");
        }
        if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
        {
            WinUtils.AddEnvironmentPath(@".\runtimes\win-x86\native\");
            LinuxUtils.AddEnvironmentPath(@"./runtimes/linux-x86/native/");
        }

        NativeLibrary.SetDllImportResolver(typeof(SDL).Assembly, ResolveDllImport);
    }

    private static IntPtr ResolveDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        IntPtr _handle = default;

        if (_handle == IntPtr.Zero)
        {
            foreach (var path in GetSearchPaths(libraryName))
            {
                if (path != null && NativeLibrary.TryLoad(path, out _handle))
                {
                    return _handle;
                }
            }
        }

        return _handle;
    }

    private static IEnumerable<string> GetSearchPaths(string libraryName)
    {
        string libName = GetNativeLibraryName(libraryName);

        // Try loading from runtimes/<rid>/native/<lib-name>
        yield return Path.Combine(
            AppContext.BaseDirectory,
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
