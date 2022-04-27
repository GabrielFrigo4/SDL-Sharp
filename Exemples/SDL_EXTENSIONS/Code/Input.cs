using SDL_Sharp;
using System.Collections.Generic;

namespace SDL_PLUS_EXTENSIONS;
internal static class Input
{
    static readonly List<Keycode> KEYS_PRESSED = new();
    static readonly List<Keycode> KEYS_DOWN = new();
    static readonly List<Keycode> KEYS_UP = new();

    internal static void Update(Event @event)
    {
        switch (@event.Type)
        {
            case EventType.KeyDown:
                if (!KEYS_PRESSED.Contains(@event.Keyboard.Keysym.Sym))
                {
                    KEYS_PRESSED.Add(@event.Keyboard.Keysym.Sym);
                    KEYS_DOWN.Add(@event.Keyboard.Keysym.Sym);
                }
                break;
            case EventType.KeyUp:
                if (KEYS_PRESSED.Contains(@event.Keyboard.Keysym.Sym))
                {
                    KEYS_PRESSED.Remove(@event.Keyboard.Keysym.Sym);
                    KEYS_UP.Add(@event.Keyboard.Keysym.Sym);
                }
                break;
        }
    }

    internal static void Restart()
    {
        KEYS_DOWN.Clear();
        KEYS_UP.Clear();
    }

    internal static bool GetKeyDown(Keycode key)
    {
        return KEYS_DOWN.Contains(key);
    }

    internal static bool GetKeyUp(Keycode key)
    {
        return KEYS_UP.Contains(key);
    }

    internal static bool GetKeyPressed(Keycode key)
    {
        return KEYS_PRESSED.Contains(key);
    }

    internal static bool GetKeyNotPressed(Keycode key)
    {
        return !KEYS_PRESSED.Contains(key);
    }
}