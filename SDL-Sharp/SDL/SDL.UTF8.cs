using System;
using System.Text;
using System.Runtime.InteropServices;

namespace SDL_Sharp;
public static unsafe partial class SDL
{
	/* Get a Free func! */
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	static extern void Free(IntPtr memblock);

	/* This is public because SDL_DropEvent needs it! */
	public static unsafe string? UTF8_ToManaged(IntPtr s, bool freePtr = false)
	{
		if (s == IntPtr.Zero)
		{
			return null;
		}

		/* We get to do strlen ourselves! */
		byte* ptr = (byte*)s;
		while (*ptr != 0)
		{
			ptr++;
		}

        string result = Encoding.UTF8.GetString(
                    (byte*)s,
                    (int)(ptr - (byte*)s)
                );

		/* Some SDL functions will malloc, we have to free! */
		if (freePtr)
		{
			Free(s);
		}
		return result;
	}
}
