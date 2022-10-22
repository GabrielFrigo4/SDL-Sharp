using SDL_Sharp.Utils;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL_Sharp;
[Flags]
public enum SdlInitFlags : uint
{
    None = 0,
    Timer = 0x00000001u,
    Audio = 0x00000010u,
    Video = 0x00000020u,
    Joystick = 0x00000200u,
    Haptic = 0x00001000u,
    GameController = 0x00002000u,
    Events = 0x00004000u,
    NoParachute = 0x00100000u,
    Everything = Timer | Audio | Video | Events
        | Joystick | Haptic | GameController
}

public static unsafe partial class SDL
{
    [DllImport(LibraryName, EntryPoint = "SDL_Init", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Init(SdlInitFlags flags);

    [DllImport(LibraryName, EntryPoint = "SDL_InitSubSystem", CallingConvention = CallingConvention.Cdecl)]
    public static extern int InitSubSystem(SdlInitFlags flags);

    [DllImport(LibraryName, EntryPoint = "SDL_QuitSubSystem", CallingConvention = CallingConvention.Cdecl)]
    public static extern void QuitSubSystem(SdlInitFlags flags);

    [DllImport(LibraryName, EntryPoint = "SDL_WasInit", CallingConvention = CallingConvention.Cdecl)]
    public static extern SdlInitFlags WasInit(SdlInitFlags flags);

    [DllImport(LibraryName, EntryPoint = "SDL_Quit", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Quit();

    [DllImport(LibraryName, EntryPoint = "SDL_GetBasePath", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetBasePath();

    public static string GetBasePathString()
    {
        return InternalUtils.GetString(GetBasePath());
    }
}
