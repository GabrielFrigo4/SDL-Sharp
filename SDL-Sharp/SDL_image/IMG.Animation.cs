using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp.Image;
[StructLayout(LayoutKind.Sequential)]
public struct Animation
{
	public int Width;
	public int Height;
	public IntPtr Frames; /* SDL_Surface** */
	public IntPtr Delays; /* int* */
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct PAnimation
{
	private readonly Animation* ptr;

	public PAnimation(Animation* ptr)
	{
		this.ptr = ptr;
	}

	public static implicit operator Animation*(PAnimation font)
	{
		return font.ptr;
	}

	public static implicit operator PAnimation(Animation* ptr)
	{
		return new PAnimation(ptr);
	}
}

public static unsafe partial class IMG
{
	#region Animated Image Support

	/* This region is only available in 2.0.6 or higher. */

	/* IntPtr refers to an IMG_Animation* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation")]
	public unsafe static extern Animation* LoadAnimation(
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string file
	);
	public static void LoadAnimation(
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string file,
		out Animation* animation
	)
	{
		animation = LoadAnimation(file);
	}
	public static void LoadAnimation(
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string file,
		out PAnimation animation
	)
	{
		animation = LoadAnimation(file);
	}

	/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation_RW")]
	public static extern Animation* LoadAnimation_RW(
		RWops src,
		int freesrc
	);
	public static void LoadAnimation_RW(
		RWops src,
		int freesrc,
		out Animation* animation
	)
	{
		animation = LoadAnimation_RW(src, freesrc);
	}
	public static void LoadAnimation_RW(
		RWops src,
		int freesrc,
		out PAnimation animation
	)
	{
		animation = LoadAnimation_RW(src, freesrc);
	}

	/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimationTyped_RW")]
	public static extern Animation* LoadAnimationTyped_RW(
		RWops src,
		int freesrc,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string type
	);
	public static void LoadAnimationTyped_RW(
		RWops src,
		int freesrc,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string type,
		out Animation* animation
	)
    {
		animation = LoadAnimationTyped_RW(src, freesrc, type);
	}
	public static void LoadAnimationTyped_RW(
		RWops src,
		int freesrc,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
				string type,
		out PAnimation animation
	)
	{
		animation = LoadAnimationTyped_RW(src, freesrc, type);
	}

	/* anim refers to an IMG_Animation* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_FreeAnimation")]
	public static extern void FreeAnimation(Animation* anim);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_FreeAnimation")]
	public static extern void FreeAnimation(PAnimation anim);

	/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGIFAnimation_RW")]
	public static extern Animation* LoadGIFAnimation_RW(RWops src);
	public static void LoadGIFAnimation_RW(RWops src, out Animation* animation)
    {
		animation = LoadGIFAnimation_RW(src);
	}
	public static void LoadGIFAnimation_RW(RWops src, out PAnimation animation)
	{
		animation = LoadGIFAnimation_RW(src);
	}

	#endregion
}
