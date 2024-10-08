#region License
/* SDL2# - C# Wrapper for SDL2
 *
 * Copyright (c) 2013-2020 Ethan Lee.
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 * claim that you wrote the original software. If you use this software in a
 * product, an acknowledgment in the product documentation would be
 * appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not be
 * misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source distribution.
 *
 * Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
 *
 */
#endregion
#region Using Statements
using SDL_Sharp.Utils;
using System;
using System.Runtime.InteropServices;
#endregion

namespace SDL_Sharp.Image;
public static unsafe partial class IMG
{
	#region SDL2# Variables

	/* Used by DllImport to load the native library. */
	private const string LibraryName = "SDL2_image";

	#endregion

	#region SDL_image.h

	/* Similar to the headers, this is the version we're expecting to be
	 * running with. You will likely want to check this somewhere in your
	 * program!
	 */
	public const int MAJOR_VERSION = 2;
	public const int MINOR_VERSION = 0;
	public const int PATCHLEVEL = 6;

	public static void GetVersion(out Version X)
	{
		X.Major = MAJOR_VERSION;
		X.Minor = MINOR_VERSION;
		X.Patch = PATCHLEVEL;
	}

	public unsafe static void GetVersion(Version* X)
	{
		X->Major = MAJOR_VERSION;
		X->Minor = MINOR_VERSION;
		X->Patch = PATCHLEVEL;
	}

	[DllImport(LibraryName, EntryPoint = "IMG_Linked_Version", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_IMG_Linked_Version();
	public static Version Linked_Version()
	{
		Version result;
		IntPtr result_ptr = INTERNAL_IMG_Linked_Version();
		result = Marshal.PtrToStructure<Version>(result_ptr);
		return result;
	}

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Init")]
	public static extern int Init(ImgInitFlags flags);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Quit")]
	public static extern void Quit();

	/* IntPtr refers to an SDL_Surface* */
	[DllImport(LibraryName, EntryPoint = "IMG_Load", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_IMG_Load(
		byte* file
	);
	public static Surface* Load(string file)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		Surface* handle = INTERNAL_IMG_Load(
			utf8File
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return handle;
	}
	public static void Load(string file, out Surface* surface)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		surface = INTERNAL_IMG_Load(
			utf8File
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
	}
	public static void Load(string file, out PSurface surface)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		surface = INTERNAL_IMG_Load(
			utf8File
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
	}

	/* src refers to an SDL_RWops*, IntPtr to an SDL_Surface* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Load_RW")]
	public static extern Surface* Load_RW(
		RWops src,
		int freesrc
	);
	public static void Load_RW(
		RWops src,
		int freesrc,
		out Surface* surface
	)
    {
		surface = Load_RW(src, freesrc);
	}
	public static void Load_RW(
		RWops src,
		int freesrc,
		out PSurface surface
	)
	{
		surface = Load_RW(src, freesrc);
	}

	/* src refers to an SDL_RWops*, IntPtr to an SDL_Surface* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, EntryPoint = "IMG_LoadTyped_RW", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_IMG_LoadTyped_RW(
		RWops src,
		int freesrc,
		byte* type
	);
	public static Surface* LoadTyped_RW(
		RWops src,
		int freesrc,
		string type
	)
	{
		int utf8TypeBufSize = InternalUtils.Utf8Size(type);
		byte* utf8Type = stackalloc byte[utf8TypeBufSize];
		return INTERNAL_IMG_LoadTyped_RW(
			src,
			freesrc,
            InternalUtils.Utf8Encode(type, utf8Type, utf8TypeBufSize)
		);
	}
	public static void LoadTyped_RW(
		RWops src,
		int freesrc,
		string type,
		out Surface* surface
	)
	{
		int utf8TypeBufSize = InternalUtils.Utf8Size(type);
		byte* utf8Type = stackalloc byte[utf8TypeBufSize];
		surface = INTERNAL_IMG_LoadTyped_RW(
			src,
			freesrc,
            InternalUtils.Utf8Encode(type, utf8Type, utf8TypeBufSize)
		);
	}
	public static void LoadTyped_RW(
		RWops src,
		int freesrc,
		string type,
		out PSurface surface
	)
	{
		int utf8TypeBufSize = InternalUtils.Utf8Size(type);
		byte* utf8Type = stackalloc byte[utf8TypeBufSize];
		surface = INTERNAL_IMG_LoadTyped_RW(
			src,
			freesrc,
            InternalUtils.Utf8Encode(type, utf8Type, utf8TypeBufSize)
		);
	}

	/* IntPtr refers to an SDL_Texture*, renderer to an SDL_Renderer* */
	[DllImport(LibraryName, EntryPoint = "IMG_LoadTexture", CallingConvention = CallingConvention.Cdecl)]
	private static extern Texture INTERNAL_IMG_LoadTexture(
		Renderer renderer,
		byte* file
	);
	public static Texture LoadTexture(
		Renderer renderer,
		string file
	)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		IntPtr handle = INTERNAL_IMG_LoadTexture(
			renderer,
			utf8File
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return handle;
	}

	/* renderer refers to an SDL_Renderer*.
	 * src refers to an SDL_RWops*.
	 * IntPtr to an SDL_Texture*.
	 */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTexture_RW")]
	public static extern Texture LoadTexture_RW(
		Renderer renderer,
		RWops src,
		int freesrc
	);

	/* renderer refers to an SDL_Renderer*.
	 * src refers to an SDL_RWops*.
	 * IntPtr to an SDL_Texture*.
	 */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, EntryPoint = "IMG_LoadTextureTyped_RW", CallingConvention = CallingConvention.Cdecl)]
	private static extern Texture INTERNAL_IMG_LoadTextureTyped_RW(
		Renderer renderer,
		RWops src,
		int freesrc,
		byte* type
	);
	public static Texture LoadTextureTyped_RW(
		Renderer renderer,
		RWops src,
		int freesrc,
		string type
	)
	{
		byte* utf8Type = InternalUtils.Utf8Encode(type);
		Texture handle = INTERNAL_IMG_LoadTextureTyped_RW(
			renderer,
			src,
			freesrc,
			utf8Type
		);
		Marshal.FreeHGlobal((IntPtr)utf8Type);
		return handle;
	}

	/* IntPtr refers to an SDL_Surface* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_ReadXPMFromArray")]
	public static extern Surface* ReadXPMFromArray(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
			string[] xpm
	);
	public static void ReadXPMFromArray(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
			string[] xpm,
		out Surface* surface
    )
    {
		surface = ReadXPMFromArray(xpm);
	}
	public static void ReadXPMFromArray(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
			string[] xpm,
		out PSurface surface
	)
	{
		surface = ReadXPMFromArray(xpm);
	}

	/* surface refers to an SDL_Surface* */
	[DllImport(LibraryName, EntryPoint = "IMG_SavePNG", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_IMG_SavePNG(
		Surface* surface,
		byte* file
	);
	public static int SavePNG(Surface* surface, string file)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		int result = INTERNAL_IMG_SavePNG(
			surface,
			utf8File
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return result;
	}
	public static int SavePNG(PSurface surface, string file)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		int result = INTERNAL_IMG_SavePNG(
			surface,
			utf8File
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return result;
	}

	/* surface refers to an SDL_Surface*, dst to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG_RW")]
	public static extern int SavePNG_RW(
		Surface* surface,
		RWops dst,
		int freedst
	);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG_RW")]
	public static extern int SavePNG_RW(
		PSurface surface,
		RWops dst,
		int freedst
	);

	/* surface refers to an SDL_Surface* */
	[DllImport(LibraryName, EntryPoint = "IMG_SaveJPG", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_IMG_SaveJPG(
		Surface* surface,
		byte* file,
		int quality
	);
	public static int SaveJPG(Surface* surface, string file, int quality)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		int result = INTERNAL_IMG_SaveJPG(
			surface,
			utf8File,
			quality
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return result;
	}
	public static int SaveJPG(PSurface surface, string file, int quality)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		int result = INTERNAL_IMG_SaveJPG(
			surface,
			utf8File,
			quality
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return result;
	}

	/* surface refers to an SDL_Surface*, dst to an SDL_RWops* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveJPG_RW")]
	public static extern int SaveJPG_RW(
		Surface* surface,
		RWops dst,
		int freedst,
		int quality
	);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveJPG_RW")]
	public static extern int SaveJPG_RW(
		PSurface surface,
		RWops dst,
		int freedst,
		int quality
	);

    public static string GetError()
    {
		return SDL.GetError();
    }

    /* music refers to a Mix_Music*
	* Only available in 2.6.0 or higher.
	*/
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadSizedSVG_RW")]
    public static extern Surface* LoadSizedSVG_RW(
        RWops src,
		int width,
		int height
    );

	public static void LoadSizedSVG_RW(RWops src, int width, int height, out Surface* surface)
	{
		surface = LoadSizedSVG_RW(src, width, height);
    }

    public static void LoadSizedSVG_RW(RWops src, int width, int height, out PSurface surface)
    {
        surface = LoadSizedSVG_RW(src, width, height);
    }

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_ReadXPMFromArrayToRGB888")]
	public static extern Surface* ReadXPMFromArrayToRGB888(
        [In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
            string[] xpm
    );

    #endregion
}

[Flags]
public enum ImgInitFlags
{
	Jpg = 0x00000001,
	Png = 0x00000002,
	Tif = 0x00000004,
	Webp = 0x00000008
}
