using System;
using System.Runtime.InteropServices;

namespace SDL_EXTENSIONS.Code;
internal unsafe static class WinDark
{
    [DllImport("dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int* attrValue, int attrSize);

    internal static void SetTheme(nint hwnd)
    {
        int useImmersiveDarkMode = 1;
        DwmSetWindowAttribute(hwnd, 20, &useImmersiveDarkMode, sizeof(int));
    }
}
