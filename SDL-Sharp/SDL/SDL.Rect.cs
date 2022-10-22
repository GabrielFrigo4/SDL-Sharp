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

/* Only available in 2.0.22 or higher */
[StructLayout(LayoutKind.Sequential)]
public struct FRect
{
    public float X;
    public float Y;
    public float Width;
    public float Height;

    public FRect(float X, float Y, float Width, float Height)
    {
        this.X = X;
        this.Y = Y;
        this.Width = Width;
        this.Height = Height;
    }
}

[StructLayout(LayoutKind.Sequential)]
public struct FPoint
{
    public float X;
    public float Y;

    public FPoint(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }
}