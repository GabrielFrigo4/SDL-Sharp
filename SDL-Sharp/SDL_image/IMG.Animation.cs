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

public static unsafe partial class IMG
{
	#region Animated Image Support

	/* This region is only available in 2.0.6 or higher. */

	/* IntPtr refers to an IMG_Animation* */
	[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation")]
	public unsafe static extern Animation* LoadAnimation(
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string file
	);

	/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation_RW")]
	public static extern Animation* LoadAnimation_RW(
		RWops src,
		int freesrc
	);

	/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimationTyped_RW")]
	public static extern Animation* LoadAnimationTyped_RW(
		RWops src,
		int freesrc,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string type
	);

	/* anim refers to an IMG_Animation* */
	[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_FreeAnimation")]
	public static extern void FreeAnimation(Animation* anim);

	/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGIFAnimation_RW")]
	public static extern Animation* LoadGIFAnimation_RW(RWops src);

	#endregion
}
