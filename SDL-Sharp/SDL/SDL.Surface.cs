using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
[StructLayout(LayoutKind.Sequential)]
public unsafe struct Surface
{
    public uint Flags;
    public PixelFormat* Format;
    public int W;
    public int H;
    public int Pitch;
    public void* Pixels;
    public void* UserData;
    public int Locked;
    public void* LockData;
    public Rect ClipRect;
    public IntPtr Map;
    public int RefCount;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct PSurface
{
    private readonly Surface* ptr;

    public PSurface(Surface* ptr)
    {
        this.ptr = ptr;
    }

    public static implicit operator Surface*(PSurface texture)
    {
        return texture.ptr;
    }

    public static implicit operator PSurface(Surface* ptr)
    {
        return new PSurface(ptr);
    }
}

public static unsafe partial class SDL
{
    public const uint SWSURFACE = 0;
    public const uint PREALLOC = 0x00000001;
    public const uint RLEACCEL = 0x00000002;
    public const uint DONTFREE = 0x00000004;

    public static int BlitScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect) => UpperBlitScaled(src, srcrect, dst, dstrect);

    public static int BlitScaled(PSurface src, Rect* srcrect, PSurface dst, Rect* dstrect) => UpperBlitScaled(src, srcrect, dst, dstrect);

    public static int BlitSurface(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect) => UpperBlit(src, srcrect, dst, dstrect);

    public static int BlitSurface(PSurface src, Rect* srcrect, PSurface dst, Rect* dstrect) => UpperBlit(src, srcrect, dst, dstrect);

    public static int BlitScaled(Surface* src, ref Rect srcrect, Surface* dst, ref Rect dstrect) => UpperBlitScaled(src, ref srcrect, dst, ref dstrect);

    public static int BlitScaled(PSurface src, ref Rect srcrect, PSurface dst, ref Rect dstrect) => UpperBlitScaled(src, ref srcrect, dst, ref dstrect);

    public static int BlitSurface(Surface* src, ref Rect srcrect, Surface* dst, ref Rect dstrect) => UpperBlit(src, ref srcrect, dst, ref dstrect);

    public static int BlitSurface(PSurface src, ref Rect srcrect, PSurface dst, ref Rect dstrect) => UpperBlit(src, ref srcrect, dst, ref dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertPixels", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ConvertPixels(int width, int height, uint src_format, void* src, int src_pitch, uint dst_format, void* dst, int dst_pitch);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertPixels", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ConvertPixels(int width, int height, uint src_format, IntPtr src, int src_pitch, uint dst_format, IntPtr dst, int dst_pitch);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* ConvertSurface(Surface* src, PixelFormat* fmt, uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern PSurface ConvertSurface(PSurface src, PixelFormat* fmt, uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceFormat", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* ConvertSurfaceFormat(Surface* src, uint pixel_format, uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceFormat", CallingConvention = CallingConvention.Cdecl)]
    public static extern PSurface ConvertSurfaceFormat(PSurface src, uint pixel_format, uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRGBSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* CreateRGBSurface(uint flags, int width, int height, int depth, uint Rmask, uint Gmask, uint Bmask, uint Amask);
    public static void CreateRGBSurface(uint flags, int width, int height, int depth, uint Rmask, uint Gmask, uint Bmask, uint Amask, out Surface* surface)
    {
        surface = CreateRGBSurface(flags, width, height, depth, Rmask, Gmask, Bmask, Amask);
    }
    public static void CreateRGBSurface(uint flags, int width, int height, int depth, uint Rmask, uint Gmask, uint Bmask, uint Amask, out PSurface surface)
    {
        surface = CreateRGBSurface(flags, width, height, depth, Rmask, Gmask, Bmask, Amask);
    }

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRGBSurfaceFrom", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask);
    public static void CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask, out Surface* surface)
    {
        surface = CreateRGBSurfaceFrom(pixels, width, height, depth, pitch, Rmask, Gmask, Bmask, Amask);
    }
    public static void CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask, out PSurface surface)
    {
        surface = CreateRGBSurfaceFrom(pixels, width, height, depth, pitch, Rmask, Gmask, Bmask, Amask);
    }

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRGBSurfaceFrom", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* CreateRGBSurfaceFrom(IntPtr pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask);
    public static void CreateRGBSurfaceFrom(IntPtr pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask, out Surface* surface)
    {
        surface = CreateRGBSurfaceFrom(pixels, width, height, depth, pitch, Rmask, Gmask, Bmask, Amask);
    }
    public static void CreateRGBSurfaceFrom(IntPtr pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask, out PSurface surface)
    {
        surface = CreateRGBSurfaceFrom(pixels, width, height, depth, pitch, Rmask, Gmask, Bmask, Amask);
    }

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRGBSurfaceWithFormat", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format);
    public static void CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format, out Surface* surface)
    {
        surface = CreateRGBSurfaceWithFormat(flags, width, height, depth, format);
    }
    public static void CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format, out PSurface surface)
    {
        surface = CreateRGBSurfaceWithFormat(flags, width, height, depth, format);
    }

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format);
    public static void CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format, out Surface* surface)
    {
        surface = CreateRGBSurfaceWithFormatFrom(pixels, width, height, depth, pitch, format);
    }
    public static void CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format, out PSurface surface)
    {
        surface = CreateRGBSurfaceWithFormatFrom(pixels, width, height, depth, pitch, format);
    }

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom", CallingConvention = CallingConvention.Cdecl)]
    public static extern Surface* CreateRGBSurfaceWithFormatFrom(IntPtr pixels, int width, int height, int depth, int pitch, uint format);
    public static void CreateRGBSurfaceWithFormatFrom(IntPtr pixels, int width, int height, int depth, int pitch, uint format, out Surface* surface)
    {
        surface = CreateRGBSurfaceWithFormatFrom(pixels, width, height, depth, pitch, format);
    }
    public static void CreateRGBSurfaceWithFormatFrom(IntPtr pixels, int width, int height, int depth, int pitch, uint format, out PSurface surface)
    {
        surface = CreateRGBSurfaceWithFormatFrom(pixels, width, height, depth, pitch, format);
    }

    [DllImport(LibraryName, EntryPoint = "SDL_FillRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRect(Surface* dst, Rect* rect, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRect(PSurface dst, Rect* rect, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRect(Surface* dst, ref Rect rect, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRect(PSurface dst, ref Rect rect, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillRects", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRects(Surface* dst, Rect* rects, int count, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillRects", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRects(PSurface dst, Rect* rects, int count, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillRects", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRects(Surface* dst, ref Rect rects, int count, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillRects", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FillRects(PSurface dst, ref Rect rects, int count, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FreeSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern void FreeSurface(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_FreeSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern void FreeSurface(PSurface surface);

    [DllImport(LibraryName, EntryPoint = "SDL_GetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetClipRect(Surface* surface, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetClipRect(PSurface surface, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetClipRect(Surface* surface, out Rect rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetClipRect(PSurface surface, out Rect rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetColorKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetColorKey(Surface* surface, uint* key);

    [DllImport(LibraryName, EntryPoint = "SDL_GetColorKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetColorKey(PSurface surface, uint* key);

    [DllImport(LibraryName, EntryPoint = "SDL_GetColorKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetColorKey(Surface* surface, out uint key);

    [DllImport(LibraryName, EntryPoint = "SDL_GetColorKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetColorKey(PSurface surface, out uint key);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceAlphaMod(Surface* surface, byte* alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceAlphaMod(PSurface surface, byte* alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceAlphaMod(Surface* surface, out byte alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceAlphaMod(PSurface surface, out byte alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceBlendMode(PSurface surface, BlendMode* blendMode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceBlendMode(Surface* surface, out BlendMode blendMode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceBlendMode(PSurface surface, out BlendMode blendMode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceColorMod(PSurface surface, byte* r, byte* g, byte* b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceColorMod(Surface* surface, out byte r, out byte g, out byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetSurfaceColorMod(PSurface surface, out byte r, out byte g, out byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_LockSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LockSurface(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_LockSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LockSurface(PSurface surface);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlit(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlit(PSurface src, Rect* srcrect, PSurface dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlit(Surface* src, ref Rect srcrect, Surface* dst, ref Rect dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlit(PSurface src, ref Rect srcrect, PSurface dst, ref Rect dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlitScaled(Surface* surface, Rect* srcrect, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlitScaled(PSurface surface, Rect* srcrect, PSurface dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlitScaled(Surface* surface, ref Rect srcrect, Surface* dst, ref Rect dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_LowerBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int LowerBlitScaled(PSurface surface, ref Rect srcrect, PSurface dst, ref Rect dstrect);

    public static bool MUSTLOCK(Surface* s) => (s->Flags & 0x00000002) != 0;
    public static bool MUSTLOCK(PSurface s) => (((Surface*)s)->Flags & 0x00000002) != 0;

    [DllImport(LibraryName, EntryPoint = "SDL_SetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SetClipRect(Surface* surface, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SetClipRect(PSurface surface, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SetClipRect(Surface* surface, ref Rect rect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetClipRect", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SetClipRect(PSurface surface, ref Rect rect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetColorKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetColorKey(Surface* surface, bool flag, uint key);

    [DllImport(LibraryName, EntryPoint = "SDL_SetColorKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetColorKey(PSurface surface, bool flag, uint key);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceAlphaMod(Surface* surface, byte alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceAlphaMod(PSurface surface, byte alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceBlendMode(PSurface surface, BlendMode blendMode);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceColorMod(PSurface surface, byte r, byte g, byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfacePalette", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfacePalette(Surface* surface, Palette* palette);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfacePalette", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfacePalette(PSurface surface, Palette* palette);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceRLE", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceRLE(Surface* surface, int flag);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceRLE", CallingConvention = CallingConvention.Cdecl)]
    public static extern int SetSurfaceRLE(PSurface surface, int flag);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UnlockSurface(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UnlockSurface(PSurface surface);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlit(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlit(PSurface src, Rect* srcrect, PSurface dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlit(Surface* src, ref Rect srcrect, Surface* dst, ref Rect dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlit(PSurface src, ref Rect srcrect, PSurface dst, ref Rect dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlitScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlitScaled(PSurface src, Rect* srcrect, PSurface dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlitScaled(Surface* src, ref Rect srcrect, Surface* dst, ref Rect dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpperBlitScaled", CallingConvention = CallingConvention.Cdecl)]
    public static extern int UpperBlitScaled(PSurface src, ref Rect srcrect, PSurface dst, ref Rect dstrect);
}
