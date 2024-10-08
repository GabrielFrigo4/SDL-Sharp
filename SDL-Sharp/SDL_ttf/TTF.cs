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
using System.Drawing;
using System.Runtime.InteropServices;
#endregion

namespace SDL_Sharp.Ttf;
public unsafe static partial class TTF
{
	#region SDL2# Variables

	/* Used by DllImport to load the native library. */
	private const string LibraryName = "SDL2_ttf";

	#endregion

	#region SDL_ttf.h

	/* Similar to the headers, this is the version we're expecting to be
	 * running with. You will likely want to check this somewhere in your
	 * program!
	 */
	public const int MAJOR_VERSION = 2;
	public const int MINOR_VERSION = 0;
	public const int PATCHLEVEL = 16;

	public const int UNICODE_BOM_NATIVE = 0xFEFF;
	public const int UNICODE_BOM_SWAPPED = 0xFFFE;

	public const int STYLE_NORMAL = 0x00;
	public const int STYLE_BOLD = 0x01;
	public const int STYLE_ITALIC = 0x02;
	public const int STYLE_UNDERLINE = 0x04;
	public const int STYLE_STRIKETHROUGH = 0x08;

	public const int HINTING_NORMAL = 0;
	public const int HINTING_LIGHT = 1;
	public const int HINTING_MONO = 2;
	public const int HINTING_NONE = 3;
	public const int HINTING_LIGHT_SUBPIXEL = 4; /* >= 2.0.16 */

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

	[DllImport(LibraryName, EntryPoint = "TTF_LinkedVersion", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_TTF_LinkedVersion();
	public static Version LinkedVersion()
	{
		Version result;
		IntPtr result_ptr = INTERNAL_TTF_LinkedVersion();
		result = Marshal.PtrToStructure<Version>(result_ptr);
		return result;
	}

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_ByteSwappedUNICODE")]
	public static extern void ByteSwappedUNICODE(int swapped);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_Init")]
	public static extern int Init();

	/* IntPtr refers to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_OpenFont", CallingConvention = CallingConvention.Cdecl)]
	private static extern unsafe Font INTERNAL_TTF_OpenFont(
		byte* file,
		int ptsize
	);
	public static Font OpenFont(string file, int ptsize)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		Font handle = INTERNAL_TTF_OpenFont(
			utf8File,
			ptsize
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return handle;
	}

	/* src refers to an SDL_RWops*, IntPtr to a TTF_Font* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontRW")]
	public static extern Font OpenFontRW(
		IntPtr src,
		int freesrc,
		int ptsize
	);

	/* IntPtr refers to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_OpenFontIndex", CallingConvention = CallingConvention.Cdecl)]
	private static extern Font INTERNAL_TTF_OpenFontIndex(
		byte* file,
		int ptsize,
		long index
	);
	public static Font OpenFontIndex(
		string file,
		int ptsize,
		long index
	)
	{
		byte* utf8File = InternalUtils.Utf8Encode(file);
		Font handle = INTERNAL_TTF_OpenFontIndex(
			utf8File,
			ptsize,
			index
		);
		Marshal.FreeHGlobal((IntPtr)utf8File);
		return handle;
	}

	/* src refers to an SDL_RWops*, IntPtr to a TTF_Font* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontIndexRW")]
	public static extern Font OpenFontIndexRW(
		IntPtr src,
		int freesrc,
		int ptsize,
		long index
	);

	/* font refers to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontSize")]
	public static extern int SetFontSize(
		Font font,
		int ptsize
	);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontStyle")]
	public static extern int GetFontStyle(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontStyle")]
	public static extern void SetFontStyle(Font font, int style);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontOutline")]
	public static extern int GetFontOutline(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontOutline")]
	public static extern void SetFontOutline(Font font, int outline);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontHinting")]
	public static extern int GetFontHinting(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontHinting")]
	public static extern void SetFontHinting(Font font, int hinting);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontHeight")]
	public static extern int FontHeight(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontAscent")]
	public static extern int FontAscent(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontDescent")]
	public static extern int FontDescent(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontLineSkip")]
	public static extern int FontLineSkip(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontKerning")]
	public static extern int GetFontKerning(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontKerning")]
	public static extern void SetFontKerning(Font font, int allowed);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontFaces")]
	public static extern long FontFaces(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontFaceIsFixedWidth")]
	public static extern int FontFaceIsFixedWidth(Font font);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_FontFaceFamilyName", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_TTF_FontFaceFamilyName(
		Font font
	);
	public static string? FontFaceFamilyName(Font font)
	{
		return SDL.UTF8_ToManaged(
			INTERNAL_TTF_FontFaceFamilyName(font)
		);
	}

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_FontFaceStyleName", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_TTF_FontFaceStyleName(
		Font font
	);
	public static string? FontFaceStyleName(Font font)
	{
		return SDL.UTF8_ToManaged(
			INTERNAL_TTF_FontFaceStyleName(font)
		);
	}

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GlyphIsProvided")]
	public static extern int GlyphIsProvided(Font font, ushort ch);

	/* font refers to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GlyphIsProvided32")]
	public static extern int GlyphIsProvided32(Font font, uint ch);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GlyphMetrics")]
	public static extern int GlyphMetrics(
		Font font,
		ushort ch,
		out int minx,
		out int maxx,
		out int miny,
		out int maxy,
		out int advance
	);
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GlyphMetrics")]
	public static extern int GlyphMetrics(
		Font font,
		ushort ch,
		int* minx,
		int* maxx,
		int* miny,
		int* maxy,
		int* advance
	);

	/* font refers to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GlyphMetrics32")]
	public static extern int GlyphMetrics32(
		Font font,
		uint ch,
		out int minx,
		out int maxx,
		out int miny,
		out int maxy,
		out int advance
	);
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GlyphMetrics32")]
	public static extern int GlyphMetrics32(
		Font font,
		uint ch,
		int* minx,
		int* maxx,
		int* miny,
		int* maxy,
		int* advance
	);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SizeText")]
	public static extern int SizeText(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		out int w,
		out int h
	);
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SizeText")]
	public static extern int SizeText(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		int* w,
		int* h
	);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_SizeUTF8", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_TTF_SizeUTF8(
		Font font,
		byte* text,
		out int w,
		out int h
	);
	public static int SizeUTF8(
		Font font,
		string text,
		out int w,
		out int h
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		int result = INTERNAL_TTF_SizeUTF8(
			font,
			utf8Text,
			out w,
			out h
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	[DllImport(LibraryName, EntryPoint = "TTF_SizeUTF8", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_TTF_SizeUTF8(
		Font font,
		byte* text,
		int* w,
		int* h
	);
	public static int SizeUTF8(
		Font font,
		string text,
		int* w,
		int* h
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		int result = INTERNAL_TTF_SizeUTF8(
			font,
			utf8Text,
			w,
			h
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SizeUNICODE")]
	public static extern int SizeUNICODE(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		out int w,
		out int h
	);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SizeUNICODE")]
	public static extern int SizeUNICODE(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
					string text,
		int* w,
		int* h
	);

	/* font refers to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_MeasureText")]
	public static extern int MeasureText(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		int measure_width,
		out int extent,
		out int count
	);
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_MeasureText")]
	public static extern int MeasureText(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
					string text,
		int measure_width,
		int* extent,
		int* count
	);

	/* font refers to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, EntryPoint = "TTF_MeasureUTF8", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_TTF_MeasureUTF8(
		Font font,
		byte* text,
		int measure_width,
		out int extent,
		out int count
	);
	public static int MeasureUTF8(
		Font font,
		string text,
		int measure_width,
		out int extent,
		out int count
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		int result = INTERNAL_TTF_MeasureUTF8(
			font,
			utf8Text,
			measure_width,
			out extent,
			out count
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	[DllImport(LibraryName, EntryPoint = "TTF_MeasureUTF8", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_TTF_MeasureUTF8(
		Font font,
		byte* text,
		int measure_width,
		int* extent,
		int* count
	);
	public static int MeasureUTF8(
		Font font,
		string text,
		int measure_width,
		int* extent,
		int* count
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		int result = INTERNAL_TTF_MeasureUTF8(
			font,
			utf8Text,
			measure_width,
			extent,
			count
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}

	/* font refers to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_MeasureUNICODE")]
	public static extern int MeasureUNICODE(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		int measure_width,
		out int extent,
		out int count
	);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_MeasureUNICODE")]
	public static extern int MeasureUNICODE(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
					string text,
		int measure_width,
		int* extent,
		int* count
	);

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Solid")]
	public static extern Surface* RenderText_Solid(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg
	);
	public static void RenderText_Solid(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
				string text,
		Color fg,
		out Surface* surface
    )
    {
		surface = RenderText_Solid(font, text, fg);
	}
	public static void RenderText_Solid(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
				string text,
		Color fg,
		out PSurface surface
	)
    {
		surface = RenderText_Solid(font, text, fg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_RenderUTF8_Solid", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_TTF_RenderUTF8_Solid(
		Font font,
		byte* text,
		Color fg
	);
	public static Surface* RenderUTF8_Solid(
		Font font,
		string text,
		Color fg
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		Surface* result = INTERNAL_TTF_RenderUTF8_Solid(
			font,
			utf8Text,
			fg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	public static void RenderUTF8_Solid(
		Font font,
		string text,
		Color fg,
		out Surface* surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Solid(
			font,
			utf8Text,
			fg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}
	public static void RenderUTF8_Solid(
		Font font,
		string text,
		Color fg,
		out PSurface surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Solid(
			font,
			utf8Text,
			fg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderUNICODE_Solid")]
	public static extern Surface* RenderUNICODE_Solid(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg
	);
	public static void RenderUNICODE_Solid(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		out Surface* surface
    )
    {
		surface = RenderUNICODE_Solid(font, text, fg);
	}
	public static void RenderUNICODE_Solid(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
				string text,
		Color fg,
		out PSurface surface
	)
	{
		surface = RenderUNICODE_Solid(font, text, fg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Solid_Wrapped")]
	public static extern Surface* RenderText_Solid_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		uint wrapLength
	);
	public static void RenderText_Solid_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		uint wrapLength,
		out Surface* surface
	)
	{
		surface = RenderText_Solid_Wrapped(font, text, fg, wrapLength);
	}
	public static void RenderText_Solid_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		uint wrapLength,
		out PSurface surface
	)
	{
		surface = RenderText_Solid_Wrapped(font, text, fg, wrapLength);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, EntryPoint = "TTF_RenderUTF8_Solid_Wrapped", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_TTF_RenderUTF8_Solid_Wrapped(
		Font font,
		byte* text,
		Color fg,
		uint wrapLength
	);
	public static Surface* RenderUTF8_Solid_Wrapped(
		Font font,
		string text,
		Color fg,
		uint wrapLength
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		Surface* result = INTERNAL_TTF_RenderUTF8_Solid_Wrapped(
			font,
			utf8Text,
			fg,
			wrapLength
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	public static void RenderUTF8_Solid_Wrapped(
		Font font,
		string text,
		Color fg,
		uint wrapLength,
		out Surface* surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Solid_Wrapped(
			font,
			utf8Text,
			fg,
			wrapLength
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}
	public static void RenderUTF8_Solid_Wrapped(
		Font font,
		string text,
		Color fg,
		uint wrapLength,
		out PSurface surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Solid_Wrapped(
			font,
			utf8Text,
			fg,
			wrapLength
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderUNICODE_Solid_Wrapped")]
	public static extern Surface* RenderUNICODE_Solid_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		uint wrapLength
	);
	public static void RenderUNICODE_Solid_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
				string text,
		Color fg,
		uint wrapLength,
		out Surface* surface
    )
    {
		surface = RenderUNICODE_Solid_Wrapped(font, text, fg, wrapLength);
    }
	public static void RenderUNICODE_Solid_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
					string text,
		Color fg,
		uint wrapLength,
		out PSurface surface
	)
	{
		surface = RenderUNICODE_Solid_Wrapped(font, text, fg, wrapLength);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph_Solid")]
	public static extern Surface* RenderGlyph_Solid(
		Font font,
		ushort ch,
		Color fg
	);
	public static void RenderGlyph_Solid(
		Font font,
		ushort ch,
		Color fg,
		out Surface* surface
    )
    {
		surface = RenderGlyph_Solid(font, ch, fg);	
    }
	public static void RenderGlyph_Solid(
		Font font,
		ushort ch,
		Color fg,
		out PSurface surface
	)
	{
		surface = RenderGlyph_Solid(font, ch, fg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph32_Solid")]
	public static extern Surface* RenderGlyph32_Solid(
		Font font,
		uint ch,
		Color fg
	);
	public static void RenderGlyph32_Solid(
		Font font,
		uint ch,
		Color fg,
		out Surface* surface
	)
	{
		surface = RenderGlyph32_Solid(font, ch, fg);
	}
	public static void RenderGlyph32_Solid(
		Font font,
		uint ch,
		Color fg,
		out PSurface surface
	)
	{
		surface = RenderGlyph32_Solid(font, ch, fg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Shaded")]
	public static extern Surface* RenderText_Shaded(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		Color bg
	);
	public static void RenderText_Shaded(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		Color bg,
		out Surface* surface
    )
    {
		surface = RenderText_Shaded(font, text, fg, bg);
    }
	public static void RenderText_Shaded(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
				string text,
		Color fg,
		Color bg,
		out PSurface surface
	)
	{
		surface = RenderText_Shaded(font, text, fg, bg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_RenderUTF8_Shaded", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_TTF_RenderUTF8_Shaded(
		Font font,
		byte* text,
		Color fg,
		Color bg
	);
	public static Surface* RenderUTF8_Shaded(
		Font font,
		string text,
		Color fg,
		Color bg
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		Surface* result = INTERNAL_TTF_RenderUTF8_Shaded(
			font,
			utf8Text,
			fg,
			bg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	public static void RenderUTF8_Shaded(
		Font font,
		string text,
		Color fg,
		Color bg,
		out Surface* surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Shaded(
			font,
			utf8Text,
			fg,
			bg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}
	public static void RenderUTF8_Shaded(
		Font font,
		string text,
		Color fg,
		Color bg,
		out PSurface surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Shaded(
			font,
			utf8Text,
			fg,
			bg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderUNICODE_Shaded")]
	public static extern Surface* RenderUNICODE_Shaded(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		Color bg
	);
	public static void RenderUNICODE_Shaded(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		Color bg,
		out Surface* surface
    )
    {
		surface = RenderUNICODE_Shaded(font, text, fg, bg);
	}
	public static void RenderUNICODE_Shaded(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
				string text,
		Color fg,
		Color bg,
		out PSurface surface
	)
	{
		surface = RenderUNICODE_Shaded(font, text, fg, bg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Shaded_Wrapped")]
	public static extern Surface* RenderText_Shaded_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		Color bg,
		uint wrapLength
	);
	public static void RenderText_Shaded_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		Color bg,
		uint wrapLength,
		out Surface* surface
    )
    {
		surface = RenderText_Shaded_Wrapped(font, text, fg, bg, wrapLength);
    }
	public static void RenderText_Shaded_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
				string text,
		Color fg,
		Color bg,
		uint wrapLength,
		out PSurface surface
	)
	{
		surface = RenderText_Shaded_Wrapped(font, text, fg, bg, wrapLength);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, EntryPoint = "TTF_RenderUTF8_Shaded_Wrapped", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_TTF_RenderUTF8_Shaded_Wrapped(
		Font font,
		byte* text,
		Color fg,
		Color bg,
		uint wrapLength
	);
	public static Surface* RenderUTF8_Shaded_Wrapped(
		Font font,
		string text,
		Color fg,
		Color bg,
		uint wrapLength
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		Surface* result = INTERNAL_TTF_RenderUTF8_Shaded_Wrapped(
			font,
			utf8Text,
			fg,
			bg,
			wrapLength
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	public static void RenderUTF8_Shaded_Wrapped(
		Font font,
		string text,
		Color fg,
		Color bg,
		uint wrapLength,
		out Surface* surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Shaded_Wrapped(
			font,
			utf8Text,
			fg,
			bg,
			wrapLength
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}
	public static void RenderUTF8_Shaded_Wrapped(
		Font font,
		string text,
		Color fg,
		Color bg,
		uint wrapLength,
		out PSurface surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Shaded_Wrapped(
			font,
			utf8Text,
			fg,
			bg,
			wrapLength
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderUNICODE_Shaded_Wrapped")]
	public static extern Surface* RenderUNICODE_Shaded_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		Color bg,
		uint wrapLength
	);
	public static void RenderUNICODE_Shaded_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		Color bg,
		uint wrapLength,
		out Surface* surface
	)
	{
		surface = RenderUNICODE_Shaded_Wrapped(font, text, fg, bg, wrapLength);
	}
	public static void RenderUNICODE_Shaded_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		Color bg,
		uint wrapLength,
		out PSurface surface
	)
	{
		surface = RenderUNICODE_Shaded_Wrapped(font, text, fg, bg, wrapLength);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph_Shaded")]
	public static extern Surface* RenderGlyph_Shaded(
		Font font,
		ushort ch,
		Color fg,
		Color bg
	);
	public static void RenderGlyph_Shaded(
		Font font,
		ushort ch,
		Color fg,
		Color bg,
		out Surface* surface
	)
	{
		surface = RenderGlyph_Shaded(font, ch, fg, bg);
	}
	public static void RenderGlyph_Shaded(
		Font font,
		ushort ch,
		Color fg,
		Color bg,
		out PSurface surface
	)
	{
		surface = RenderGlyph_Shaded(font, ch, fg, bg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph32_Shaded")]
	public static extern Surface* RenderGlyph32_Shaded(
		Font font,
		uint ch,
		Color fg,
		Color bg
	);
	public static void RenderGlyph32_Shaded(
		Font font,
		uint ch,
		Color fg,
		Color bg,
		out Surface* surface
    )
    {
		surface = RenderGlyph32_Shaded(font, ch, fg, bg);
    }
	public static void RenderGlyph32_Shaded(
		Font font,
		uint ch,
		Color fg,
		Color bg,
		out PSurface surface
	)
	{
		surface = RenderGlyph32_Shaded(font, ch, fg, bg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Blended")]
	public static extern Surface* RenderText_Blended(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg
	);
	public static void RenderText_Blended(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		out Surface* surface
    )
    {
		surface = RenderText_Blended(font, text, fg);
	}
	public static void RenderText_Blended(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
				string text,
		Color fg,
		out PSurface surface
	)
	{
		surface = RenderText_Blended(font, text, fg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_RenderUTF8_Blended", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_TTF_RenderUTF8_Blended(
		Font font,
		byte* text,
		Color fg
	);
	public static Surface* RenderUTF8_Blended(
		Font font,
		string text,
		Color fg
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		Surface* result = INTERNAL_TTF_RenderUTF8_Blended(
			font,
			utf8Text,
			fg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	public static void RenderUTF8_Blended(
		Font font,
		string text,
		Color fg,
		out Surface* surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Blended(
			font,
			utf8Text,
			fg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}
	public static void RenderUTF8_Blended(
		Font font,
		string text,
		Color fg,
		out PSurface surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Blended(
			font,
			utf8Text,
			fg
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderUNICODE_Blended")]
	public static extern Surface* RenderUNICODE_Blended(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg
	);
	public static void RenderUNICODE_Blended(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		out Surface* surface
    )
    {
		surface = RenderUNICODE_Blended(font, text, fg);
	}
	public static void RenderUNICODE_Blended(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
				string text,
		Color fg,
		out PSurface surface
	)
	{
		surface = RenderUNICODE_Blended(font, text, fg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Blended_Wrapped")]
	public static extern Surface* RenderText_Blended_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		uint wrapped
	);
	public static void RenderText_Blended_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string text,
		Color fg,
		uint wrapped,
		out Surface* surface
    )
    {
		surface = RenderText_Blended_Wrapped(font, text, fg, wrapped);
	}
	public static void RenderText_Blended_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPStr)]
				string text,
		Color fg,
		uint wrapped,
		out PSurface surface
	)
	{
		surface = RenderText_Blended_Wrapped(font, text, fg, wrapped);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, EntryPoint = "TTF_RenderUTF8_Blended_Wrapped", CallingConvention = CallingConvention.Cdecl)]
	private static extern Surface* INTERNAL_TTF_RenderUTF8_Blended_Wrapped(
		Font font,
		byte* text,
		Color fg,
		uint wrapped
	);
	public static Surface* RenderUTF8_Blended_Wrapped(
		Font font,
		string text,
		Color fg,
		uint wrapped
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		Surface* result = INTERNAL_TTF_RenderUTF8_Blended_Wrapped(
			font,
			utf8Text,
			fg,
			wrapped
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
		return result;
	}
	public static void RenderUTF8_Blended_Wrapped(
		Font font,
		string text,
		Color fg,
		uint wrapped,
		out Surface* surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Blended_Wrapped(
			font,
			utf8Text,
			fg,
			wrapped
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}
	public static void RenderUTF8_Blended_Wrapped(
		Font font,
		string text,
		Color fg,
		uint wrapped,
		out PSurface surface
	)
	{
		byte* utf8Text = InternalUtils.Utf8Encode(text);
		surface = INTERNAL_TTF_RenderUTF8_Blended_Wrapped(
			font,
			utf8Text,
			fg,
			wrapped
		);
		Marshal.FreeHGlobal((IntPtr)utf8Text);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderUNICODE_Blended_Wrapped")]
	public static extern Surface* RenderUNICODE_Blended_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		uint wrapped
	);
	public static void RenderUNICODE_Blended_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
			string text,
		Color fg,
		uint wrapped,
		out Surface* surface
    )
    {
		surface = RenderUNICODE_Blended_Wrapped(font, text, fg, wrapped);
	}
	public static void RenderUNICODE_Blended_Wrapped(
		Font font,
		[In()] [MarshalAs(UnmanagedType.LPWStr)]
				string text,
		Color fg,
		uint wrapped,
		out PSurface surface
	)
	{
		surface = RenderUNICODE_Blended_Wrapped(font, text, fg, wrapped);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph_Blended")]
	public static extern Surface* RenderGlyph_Blended(
		Font font,
		ushort ch,
		Color fg
	);
	public static void RenderGlyph_Blended(
		Font font,
		ushort ch,
		Color fg,
		out Surface* surface
	)
	{
		surface = RenderGlyph_Blended(font, ch, fg);
	}
	public static void RenderGlyph_Blended(
		Font font,
		ushort ch,
		Color fg,
		out PSurface surface
	)
	{
		surface = RenderGlyph_Blended(font, ch, fg);
	}

	/* IntPtr refers to an SDL_Surface*, font to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph32_Blended")]
	public static extern Surface* RenderGlyph32_Blended(
		Font font,
		uint ch,
		Color fg
	);
	public static void RenderGlyph32_Blended(
		Font font,
		uint ch,
		Color fg,
		out Surface* surface
    )
    {
		surface = RenderGlyph32_Blended(font, ch, fg);
    }
	public static void RenderGlyph32_Blended(
		Font font,
		uint ch,
		Color fg,
		out PSurface surface
	)
	{
		surface = RenderGlyph32_Blended(font, ch, fg);
	}

	/* Only available in 2.0.16 or higher. */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetDirection")]
	public static extern int SetDirection(int direction);

	/* Only available in 2.0.16 or higher. */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetScript")]
	public static extern int SetScript(int script);

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CloseFont")]
	public static extern void CloseFont(Font font);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_Quit")]
	public static extern void Quit();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_WasInit")]
	public static extern int WasInit();

	/* font refers to a TTF_Font* */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFontKerningSize")]
	public static extern int GetFontKerningSize(
		Font font,
		int prev_index,
		int index
	);

	/* font refers to a TTF_Font*
	 * Only available in 2.0.15 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontKerningSizeGlyphs")]
	public static extern int GetFontKerningSizeGlyphs(
		Font font,
		ushort previous_ch,
		ushort ch
	);

	/* font refers to a TTF_Font*
	 * Only available in 2.0.16 or higher.
	 */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontKerningSizeGlyphs32")]
	public static extern int GetFontKerningSizeGlyphs32(
		Font font,
		ushort previous_ch,
		ushort ch
	);

    public static string GetError()
    {
        return SDL.GetError();
    }

    /* font refers to a TTF_Font*
	 * Only available in 2.0.18 or higher.
	 */
    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontDPI")]
    private static extern Font INTERNAL_OpenFontDPI(
        byte* file,
		int ptsize,
		uint hdpi,
		uint vdpi
	);
	public static Font OpenFontDPI(string file, int ptsize, uint hdpi, uint vdpi)
	{
        byte* utf8File = InternalUtils.Utf8Encode(file);
        Font handle = INTERNAL_OpenFontDPI(
            utf8File, 
			ptsize, 
			hdpi, 
			vdpi
        );
        Marshal.FreeHGlobal((IntPtr)utf8File);
        return handle;
    }

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontIndexDPI")]
    private static extern Font INTERNAL_OpenFontIndexDPI(
		byte* file,
		int ptsize,
		long index,
		uint hdpi,
		uint vdpi
	);
    public static Font OpenFontIndexDPI(string file, int ptsize, long index, uint hdpi, uint vdpi)
    {
        byte* utf8File = InternalUtils.Utf8Encode(file);
        Font handle = INTERNAL_OpenFontIndexDPI(
            utf8File,
            ptsize,
            index,
            hdpi,
            vdpi
        );
        Marshal.FreeHGlobal((IntPtr)utf8File);
        return handle;
    }

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontDPIRW")]
    private static extern Font OpenFontDPIRW(
        RWops src, 
		int freesrc, 
		int ptsize, 
		uint hdpi,
		uint vdpi
    );

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontIndexDPIRW")]
    private static extern Font OpenFontIndexDPIRW(
		RWops src,
		int freesrc,
		int ptsize,
        long index,
		uint hdpi,
		uint vdpi
	);

    [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontSizeDPI")]
    private static extern Font SetFontSizeDPI(
		Font font,
		int ptsize,
		uint hdpi,
		uint vdpi
    );

    #endregion
}

[StructLayout(LayoutKind.Sequential)]
public struct Font
{
	private readonly IntPtr ptr;

	public Font(IntPtr ptr)
	{
		this.ptr = ptr;
	}

	public bool IsNull { get { return ptr == IntPtr.Zero; } }

	public static implicit operator IntPtr(Font font)
	{
		return font.ptr;
	}

	public static implicit operator Font(IntPtr ptr)
	{
		return new Font(ptr);
	}
}
