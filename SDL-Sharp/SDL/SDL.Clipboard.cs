using SDL_Sharp.Utility;
using SDL_Sharp.Utils;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
public static unsafe partial class SDL
{
    [DllImport(LibraryName, EntryPoint = "SDL_GetClipboardText", CallingConvention = CallingConvention.Cdecl)]
    private static extern byte* INTERNAL_GetClipboardText();
    
    public static string GetClipboardText()
    {
        return InternalUtils.GetString(INTERNAL_GetClipboardText());
    }

    [DllImport(LibraryName, EntryPoint = "SDL_HasClipboardText", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool HasClipboardText();

    [DllImport(LibraryName, EntryPoint = "SDL_SetClipboardText", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern int SetClipboardText(string text);
}
