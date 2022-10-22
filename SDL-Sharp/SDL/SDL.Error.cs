using SDL_Sharp.Utils;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
public static unsafe partial class SDL
{
    [DllImport(LibraryName, EntryPoint = "SDL_GetError", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetError();

    public static string GetErrorString()
    {
        return InternalUtils.GetString(GetError());
    }

    [DllImport(LibraryName, EntryPoint = "SDL_ClearError", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClearError();
}
