using System.Runtime.InteropServices;

namespace SDL_Sharp;
[StructLayout(LayoutKind.Sequential)]
public struct Rect
{
    public int X;
    public int Y;
    public int Width;
    public int Height;

    public Rect(int X, int Y, int Width, int Height)
    {
        this.X = X;
        this.Y = Y;
        this.Width = Width;
        this.Height = Height;
    }
}

[StructLayout(LayoutKind.Sequential)]
public struct Point
{
    public int X;
    public int Y;

    public Point(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }
}
