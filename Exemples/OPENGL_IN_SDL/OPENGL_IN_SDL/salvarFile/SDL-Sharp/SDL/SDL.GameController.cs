using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp
{
    public enum GameControllerBindType
    {
        None = 0,
        Button,
        Axis,
        Hat
    }

    public enum GameControllerAxis
    {
        Invalid = -1,
        LeftX,
        LeftY,
        RightX,
        RightY,
        TriggerLeft,
        TriggerRight,
        Max
    }

    public enum GameControllerButton
    {
        Invalid = -1,
        A,
        B,
        X,
        Y,
        Back,
        Guide,
        Start,
        LeftStick,
        RightStick,
        LeftShoulder,
        RightShoulder,
        DpadUp,
        DpadDown,
        DpadLeft,
        DpadRight,
        Max
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GameControllerButtonBind
    {
        public GameControllerBindType BindType;
        public GameControllerButtonBindUnion Value;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GameControllerButtonBindUnion
    {
        [FieldOffset(0)]
        public int Button;
        [FieldOffset(0)]
        public int Axis;
        [FieldOffset(0)]
        public HatStruct Hat;

        [StructLayout(LayoutKind.Sequential)]
        public struct HatStruct
        {
            public int Hat;
            public int HatMask;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GameController
    {
        private readonly IntPtr ptr;

        public GameController(IntPtr ptr)
        {
            this.ptr = ptr;
        }

        public static implicit operator IntPtr(GameController gameController)
        {
            return gameController.ptr;
        }

        public static implicit operator GameController(IntPtr ptr)
        {
            return new GameController(ptr);
        }
    }

    public static unsafe partial class SDL
    {
        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerAddMapping", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int GameControllerAddMapping(string mappingString);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerClose", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GameControllerClose(GameController gamecontroller);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerFromInstanceID", CallingConvention = CallingConvention.Cdecl)]
        public static extern GameController GameControllerFromInstanceID(JoystickID joyid);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetAttached", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool GameControllerGetAttached(GameController gamecontroller);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetAxis", CallingConvention = CallingConvention.Cdecl)]
        public static extern short GameControllerGetAxis(GameController gameController, GameControllerAxis axis);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetAxisFromString", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern GameControllerAxis GameControllerGetAxisFromString(string pchString);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetBindForAxis", CallingConvention = CallingConvention.Cdecl)]
        public static extern GameControllerButtonBind GameControllerGetBindForAxis(GameController gameController, GameControllerAxis axis);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetBindForButton", CallingConvention = CallingConvention.Cdecl)]
        public static extern GameControllerButtonBind GameControllerGetBindForButton(GameController gameController, GameControllerButton buttons);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetButton", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte GameControllerGetButton(GameController gameController, GameControllerButton button);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetButtonFromString", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern GameControllerButton GameControllerGetButtonFromString(string pchString);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetJoystick", CallingConvention = CallingConvention.Cdecl)]
        public static extern Joystick GameControllerGetJoystick(GameController gameController);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetStringForAxis", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GameControllerGetStringForAxis(GameControllerAxis axis);

        public static string GameControllerGetStringForAxisString(GameControllerAxis axis)
        {
            return GetString(GameControllerGetStringForAxis(axis));
        }

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerGetStringForButton", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GameControllerGetStringForButton(GameControllerButton button);

        public static string GameControllerGetStringForButtonString(GameControllerButton button)
        {
            return GetString(GameControllerGetStringForButton(button));
        }

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GameControllerMapping(GameController gameController);

        public static string GameControllerMappingString(GameController gameController)
        {
            return GetString(GameControllerMapping(gameController));
        }

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerMappingForGUID", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GameControllerMappingForGUID(Guid guid);

        public static string GameControllerMappingForGUIDString(Guid guid)
        {
            return GetString(GameControllerMappingForGUID(guid));
        }

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerName", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GameControllerName(GameController gameController);

        public static string GameControllerNameString(GameController gameController)
        {
            return GetString(GameControllerName(gameController));
        }

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerNameForIndex", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GameControllerNameForIndex(int joystickIndex);

        public static string GameControllerNameForIndexString(int joystickIndex)
        {
            return GetString(GameControllerNameForIndex(joystickIndex));
        }

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerOpen", CallingConvention = CallingConvention.Cdecl)]
        public static extern GameController GameControllerOpen(int joystickIndex);

        [DllImport(LibraryName, EntryPoint = "SDL_GameControllerUpdate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GameControllerUpdate();

        [DllImport(LibraryName, EntryPoint = "SDL_IsGameController", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool IsGameController(int joystickIndex);
    }
}
