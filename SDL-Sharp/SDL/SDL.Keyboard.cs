using SDL_Sharp.Utils;
using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
[StructLayout(LayoutKind.Sequential)]
public struct Keysym
{
    public Scancode Scancode;
    public Keycode Sym;
    public KeyModifier Mod;
    public uint Unused;
}

public static unsafe partial class SDL
{
    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromName", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern Keycode GetKeyFromName(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromScancode", CallingConvention = CallingConvention.Cdecl)]
    public static extern Keycode GetKeyFromScancode(Scancode scancode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyName", CallingConvention = CallingConvention.Cdecl)]
    private static extern byte* INTERNAL_GetKeyName(Keycode key);

    public static string GetKeyName(Keycode key)
    {
        return InternalUtils.GetString(INTERNAL_GetKeyName(key));
    }

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardFocus", CallingConvention = CallingConvention.Cdecl)]
    public static extern Window GetKeyboardFocus();

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardState", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetKeyboardState(int* numKeys);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardState", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr GetKeyboardState(out int numKeys);

    [DllImport(LibraryName, EntryPoint = "SDL_GetModState", CallingConvention = CallingConvention.Cdecl)]
    public static extern KeyModifier GetModState();

    [DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern Scancode GetScancodeFromKey(Keycode key);

    [DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromName", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern Scancode GetScancodeFromName(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetScancodeName", CallingConvention = CallingConvention.Cdecl)]
    private static extern byte* INTERNAL_GetScancodeName(Scancode scancode);

    public static string GetScancodeName(Scancode scancode)
    {
        return InternalUtils.GetString(INTERNAL_GetScancodeName(scancode));
    }

    [DllImport(LibraryName, EntryPoint = "SDL_HasScreenKeyboardSupport", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool HasScreenKeyboardSupport();

    [DllImport(LibraryName, EntryPoint = "SDL_IsScreenKeyboardShown", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsScreenKeyboardShown(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_IsTextInputActive", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsTextInputActive();

    [DllImport(LibraryName, EntryPoint = "SDL_SetModState", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetModState(KeyModifier modstate);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextInputRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetTextInputRect(Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextInputRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetTextInputRect(ref Rect rect);

    [DllImport(LibraryName, EntryPoint = "SDL_StartTextInput", CallingConvention = CallingConvention.Cdecl)]
    public static extern void StartTextInput();

    [DllImport(LibraryName, EntryPoint = "SDL_StopTextInput", CallingConvention = CallingConvention.Cdecl)]
    public static extern void StopTextInput();
}
