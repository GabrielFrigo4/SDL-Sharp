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
using System;
using System.Runtime.InteropServices;
#endregion

namespace SDL_Sharp
{
	public static class IMG
	{
		#region SDL2# Variables

		/* Used by DllImport to load the native library. */
		private const string nativeLibName = "SDL2_image";

		#endregion

		#region SDL_image.h

		/* Similar to the headers, this is the version we're expecting to be
		 * running with. You will likely want to check this somewhere in your
		 * program!
		 */
		public const int IMAGE_MAJOR_VERSION = 2;
		public const int IMAGE_MINOR_VERSION = 0;
		public const int IMAGE_PATCHLEVEL = 6;

		public static void GetVersion(out Version X)
		{
			X.Major = IMAGE_MAJOR_VERSION;
			X.Minor = IMAGE_MINOR_VERSION;
			X.Patch = IMAGE_PATCHLEVEL;
		}

		[DllImport(nativeLibName, EntryPoint = "IMG_Linked_Version", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_IMG_Linked_Version();
		public static Version Linked_Version()
		{
			Version result;
			IntPtr result_ptr = INTERNAL_IMG_Linked_Version();
			result = (Version)Marshal.PtrToStructure(
				result_ptr,
				typeof(Version)
			);
			return result;
		}

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Init")]
		public static extern int Init(ImgInitFlags flags);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Quit")]
		public static extern void Quit();

		/* IntPtr refers to an SDL_Surface* */
		[DllImport(nativeLibName, EntryPoint = "IMG_Load", CallingConvention = CallingConvention.Cdecl)]
		private static extern unsafe IntPtr INTERNAL_IMG_Load(
			byte* file
		);
		public static unsafe IntPtr Load(string file)
		{
			byte* utf8File = SDL.Utf8Encode(file);
			IntPtr handle = INTERNAL_IMG_Load(
				utf8File
			);
			Marshal.FreeHGlobal((IntPtr)utf8File);
			return handle;
		}

		/* src refers to an SDL_RWops*, IntPtr to an SDL_Surface* */
		/* THIS IS A PUBLIC RWops FUNCTION! */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Load_RW")]
		public static extern IntPtr Load_RW(
			IntPtr src,
			int freesrc
		);

		/* src refers to an SDL_RWops*, IntPtr to an SDL_Surface* */
		/* THIS IS A PUBLIC RWops FUNCTION! */
		[DllImport(nativeLibName, EntryPoint = "IMG_LoadTyped_RW", CallingConvention = CallingConvention.Cdecl)]
		private static extern unsafe IntPtr INTERNAL_IMG_LoadTyped_RW(
			IntPtr src,
			int freesrc,
			byte* type
		);
		public static unsafe IntPtr LoadTyped_RW(
			IntPtr src,
			int freesrc,
			string type
		)
		{
			int utf8TypeBufSize = SDL.Utf8Size(type);
			byte* utf8Type = stackalloc byte[utf8TypeBufSize];
			return INTERNAL_IMG_LoadTyped_RW(
				src,
				freesrc,
				SDL.Utf8Encode(type, utf8Type, utf8TypeBufSize)
			);
		}

		/* IntPtr refers to an SDL_Texture*, renderer to an SDL_Renderer* */
		[DllImport(nativeLibName, EntryPoint = "IMG_LoadTexture", CallingConvention = CallingConvention.Cdecl)]
		private static extern unsafe IntPtr INTERNAL_IMG_LoadTexture(
			Renderer renderer,
			byte* file
		);
		public static unsafe Texture LoadTexture(
			Renderer renderer,
			string file
		)
		{
			byte* utf8File = SDL.Utf8Encode(file);
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
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTexture_RW")]
		public static extern IntPtr LoadTexture_RW(
			Renderer renderer,
			IntPtr src,
			int freesrc
		);

		/* renderer refers to an SDL_Renderer*.
		 * src refers to an SDL_RWops*.
		 * IntPtr to an SDL_Texture*.
		 */
		/* THIS IS A PUBLIC RWops FUNCTION! */
		[DllImport(nativeLibName, EntryPoint = "IMG_LoadTextureTyped_RW", CallingConvention = CallingConvention.Cdecl)]
		private static extern unsafe IntPtr INTERNAL_IMG_LoadTextureTyped_RW(
			Renderer renderer,
			IntPtr src,
			int freesrc,
			byte* type
		);
		public static unsafe IntPtr LoadTextureTyped_RW(
			Renderer renderer,
			IntPtr src,
			int freesrc,
			string type
		)
		{
			byte* utf8Type = SDL.Utf8Encode(type);
			IntPtr handle = INTERNAL_IMG_LoadTextureTyped_RW(
				renderer,
				src,
				freesrc,
				utf8Type
			);
			Marshal.FreeHGlobal((IntPtr)utf8Type);
			return handle;
		}

		/* IntPtr refers to an SDL_Surface* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_ReadXPMFromArray")]
		public static extern IntPtr ReadXPMFromArray(
			[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
				string[] xpm
		);

		/* surface refers to an SDL_Surface* */
		[DllImport(nativeLibName, EntryPoint = "IMG_SavePNG", CallingConvention = CallingConvention.Cdecl)]
		private static extern unsafe int INTERNAL_IMG_SavePNG(
			Surface* surface,
			byte* file
		);
		public static unsafe int SavePNG(Surface* surface, string file)
		{
			byte* utf8File = SDL.Utf8Encode(file);
			int result = INTERNAL_IMG_SavePNG(
				surface,
				utf8File
			);
			Marshal.FreeHGlobal((IntPtr)utf8File);
			return result;
		}

		/* surface refers to an SDL_Surface*, dst to an SDL_RWops* */
		/* THIS IS A PUBLIC RWops FUNCTION! */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG_RW")]
		public unsafe static extern int SavePNG_RW(
			Surface* surface,
			IntPtr dst,
			int freedst
		);

		/* surface refers to an SDL_Surface* */
		[DllImport(nativeLibName, EntryPoint = "IMG_SaveJPG", CallingConvention = CallingConvention.Cdecl)]
		private static extern unsafe int INTERNAL_IMG_SaveJPG(
			Surface* surface,
			byte* file,
			int quality
		);
		public static unsafe int SaveJPG(Surface* surface, string file, int quality)
		{
			byte* utf8File = SDL.Utf8Encode(file);
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
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveJPG_RW")]
		public unsafe static extern int SaveJPG_RW(
			Surface* surface,
			IntPtr dst,
			int freedst,
			int quality
		);

		public unsafe static string GetError()
		{
			return SDL.GetErrorString();
		}

		#region Animated Image Support

		/* This region is only available in 2.0.6 or higher. */

		/* IntPtr refers to an IMG_Animation* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation")]
		public static extern IntPtr LoadAnimation(
			[In()] [MarshalAs(UnmanagedType.LPStr)]
				string file
		);

		/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
		/* THIS IS A PUBLIC RWops FUNCTION! */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation_RW")]
		public static extern IntPtr LoadAnimation_RW(
			IntPtr src,
			int freesrc
		);

		/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
		/* THIS IS A PUBLIC RWops FUNCTION! */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimationTyped_RW")]
		public static extern IntPtr LoadAnimationTyped_RW(
			IntPtr src,
			int freesrc,
			[In()] [MarshalAs(UnmanagedType.LPStr)]
				string type
		);

		/* anim refers to an IMG_Animation* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_FreeAnimation")]
		public static extern void FreeAnimation(IntPtr anim);

		/* IntPtr refers to an IMG_Animation*, src to an SDL_RWops* */
		/* THIS IS A PUBLIC RWops FUNCTION! */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGIFAnimation_RW")]
		public static extern IntPtr LoadGIFAnimation_RW(IntPtr src);

		#endregion

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

	public struct Animation
	{
		public int Width;
		public int Height;
		public IntPtr Frames; /* SDL_Surface** */
		public IntPtr Delays; /* int* */
	}
}