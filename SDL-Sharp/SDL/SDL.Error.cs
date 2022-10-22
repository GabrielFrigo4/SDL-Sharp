using SDL_Sharp.Utils;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
public static unsafe partial class SDL
{
    [DllImport(LibraryName, EntryPoint = "SDL_GetError", CallingConvention = CallingConvention.Cdecl)]
    private static extern byte* INTERNAL_GetError();

    public static string GetError()
    {
        return InternalUtils.GetString(INTERNAL_GetError());
    }

    [DllImport(LibraryName, EntryPoint = "SDL_ClearError", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClearError();
}
