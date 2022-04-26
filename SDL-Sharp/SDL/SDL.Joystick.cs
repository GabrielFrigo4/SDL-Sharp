using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
public enum JoystickType
{
    Unknown,
    GameController,
    Wheel,
    ArcadeStick,
    FlightStick,
    DancePad,
    Guitar,
    DrumKit,
    ArcadePad,
    Throttle
}

public enum JoystickPowerLevel
{
    Unknown = -1,
    Empty,
    Low,
    Medium,
    Full,
    Wired,
    Max
}

public enum Hat : byte
{
    Centered = 0x00,
    Up = 0x01,
    Right = 0x02,
    Down = 0x04,
    Left = 0x08,

    RightUp = Right | Up,
    RightDown = Right | Down,
    LeftUp = Left | Up,
    LeftDown = Left | Down
}

[StructLayout(LayoutKind.Sequential)]
public struct Joystick
{
    private readonly IntPtr ptr;

    public Joystick(IntPtr ptr)
    {
        this.ptr = ptr;
    }

    public static implicit operator IntPtr(Joystick joystick)
    {
        return joystick.ptr;
    }

    public static implicit operator Joystick(IntPtr ptr)
    {
        return new Joystick(ptr);
    }
}

[StructLayout(LayoutKind.Sequential)]
public struct JoystickID
{
    private readonly int id;

    public JoystickID(int id)
    {
        this.id = id;
    }

    public static implicit operator int(JoystickID joystickID)
    {
        return joystickID.id;
    }
}

public static unsafe partial class SDL
{
    [DllImport(LibraryName, EntryPoint = "SDL_JoystickClose", CallingConvention = CallingConvention.Cdecl)]
    public static extern void JoystickClose(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickCurrentPowerLevel", CallingConvention = CallingConvention.Cdecl)]
    public static extern JoystickPowerLevel JoystickCurrentPowerLevel(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickFromInstanceID", CallingConvention = CallingConvention.Cdecl)]
    public static extern Joystick JoystickFromInstanceID(JoystickID joyid);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetAttached", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool JoystickGetAttached(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetAxis", CallingConvention = CallingConvention.Cdecl)]
    public static extern short JoystickGetAxis(Joystick joystick, int axis);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetBall", CallingConvention = CallingConvention.Cdecl)]
    public static extern int JoystickGetBall(Joystick joystick, int ball, int* dx, int* dy);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetBall", CallingConvention = CallingConvention.Cdecl)]
    public static extern int JoystickGetBall(Joystick joystick, int ball, out int dx, out int dy);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetButton", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte JoystickGetButton(Joystick joystick, int button);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetDeviceGUID", CallingConvention = CallingConvention.Cdecl)]
    public static extern Guid JoystickGetDeviceGUID(int deviceIndex);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetGUID", CallingConvention = CallingConvention.Cdecl)]
    public static extern Guid JoystickGetGUID(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetGUIDFromString", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    public static extern Guid JoystickGetGUIDFromString(string pchGUID);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetGUIDString", CallingConvention = CallingConvention.Cdecl)]
    public static extern void JoystickGetGUIDString(Guid guid, byte* pszGUID, int cbGUID);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetGUIDString", CallingConvention = CallingConvention.Cdecl)]
    public static extern void JoystickGetGUIDString(Guid guid, byte[] pszGUID, int cbGUID);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickGetHat", CallingConvention = CallingConvention.Cdecl)]
    public static extern Hat JoystickGetHat(Joystick joystick, int hat);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickInstanceID", CallingConvention = CallingConvention.Cdecl)]
    public static extern JoystickID JoystickInstanceID(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickName", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* JoystickName(Joystick joystick);

    public static string JoystickNameString(Joystick joystick)
    {
        return GetString(JoystickName(joystick));
    }

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickNameForIndex", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* JoystickNameForIndex(int deviceIndex);

    public static string JoystickNameForIndexString(int deviceIndex)
    {
        return GetString(JoystickNameForIndex(deviceIndex));
    }

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickNumAxes", CallingConvention = CallingConvention.Cdecl)]
    public static extern int JoystickNumAxes(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickNumBalls", CallingConvention = CallingConvention.Cdecl)]
    public static extern int JoystickNumBalls(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickNumButtons", CallingConvention = CallingConvention.Cdecl)]
    public static extern int JoystickNumButtons(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickNumHats", CallingConvention = CallingConvention.Cdecl)]
    public static extern int JoystickNumHats(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickOpen", CallingConvention = CallingConvention.Cdecl)]
    public static extern Joystick JoystickOpen(int deviceIndex);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickUpdate", CallingConvention = CallingConvention.Cdecl)]
    public static extern void JoystickUpdate();

    [DllImport(LibraryName, EntryPoint = "SDL_NumJoysticks", CallingConvention = CallingConvention.Cdecl)]
    public static extern int NumJoysticks();
}
