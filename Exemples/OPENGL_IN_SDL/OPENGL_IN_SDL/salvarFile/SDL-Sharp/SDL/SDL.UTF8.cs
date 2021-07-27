using System;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SDL_Sharp
{
	public static unsafe partial class SDL
	{
		/* Used for stack allocated string marshaling. */
		internal static int Utf8Size(string str)
		{
			Debug.Assert(str != null);
			return (str.Length * 4) + 1;
		}
		internal static int Utf8SizeNullable(string str)
		{
			return str != null ? (str.Length * 4) + 1 : 0;
		}
		internal static unsafe byte* Utf8Encode(string str, byte* buffer, int bufferSize)
		{
			Debug.Assert(str != null);
			fixed (char* strPtr = str)
			{
				Encoding.UTF8.GetBytes(strPtr, str.Length + 1, buffer, bufferSize);
			}
			return buffer;
		}
		internal static unsafe byte* Utf8EncodeNullable(string str, byte* buffer, int bufferSize)
		{
			if (str == null)
			{
				return (byte*)0;
			}
			fixed (char* strPtr = str)
			{
				Encoding.UTF8.GetBytes(strPtr, str.Length + 1, buffer, bufferSize);
			}
			return buffer;
		}

		/* Used for heap allocated string marshaling.
		 * Returned byte* must be free'd with FreeHGlobal.
		 */
		internal static unsafe byte* Utf8Encode(string str)
		{
			Debug.Assert(str != null);
			int bufferSize = Utf8Size(str);
			byte* buffer = (byte*)Marshal.AllocHGlobal(bufferSize);
			fixed (char* strPtr = str)
			{
				Encoding.UTF8.GetBytes(strPtr, str.Length + 1, buffer, bufferSize);
			}
			return buffer;
		}
		internal static unsafe byte* Utf8EncodeNullable(string str)
		{
			if (str == null)
			{
				return (byte*)0;
			}
			int bufferSize = Utf8Size(str);
			byte* buffer = (byte*)Marshal.AllocHGlobal(bufferSize);
			fixed (char* strPtr = str)
			{
				Encoding.UTF8.GetBytes(
					strPtr,
					(str != null) ? (str.Length + 1) : 0,
					buffer,
					bufferSize
				);
			}
			return buffer;
		}

		/* Get a Free func! */
		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern void Free(IntPtr memblock);

		/* This is public because SDL_DropEvent needs it! */
		public static unsafe string UTF8_ToManaged(IntPtr s, bool freePtr = false)
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

			/* TODO: This #ifdef is only here because the equivalent
			 * .NET 2.0 constructor appears to be less efficient?
			 * Here's the pretty version, maybe steal this instead:
			 *
			string result = new string(
				(sbyte*) s, // Also, why sbyte???
				0,
				(int) (ptr - (byte*) s),
				System.Text.Encoding.UTF8
			);
			 * See the CoreCLR source for more info.
			 * -flibit
			 */
#if NETSTANDARD2_0
			/* Modern C# lets you just send the byte*, nice! */
			string result = System.Text.Encoding.UTF8.GetString(
				(byte*) s,
				(int) (ptr - (byte*) s)
			);
#else
			/* Old C# requires an extra memcpy, bleh! */
			int len = (int)(ptr - (byte*)s);
			if (len == 0)
			{
				return string.Empty;
			}
			char* chars = stackalloc char[len];
			int strLen = System.Text.Encoding.UTF8.GetChars((byte*)s, len, chars, len);
			string result = new string(chars, 0, strLen);
#endif

			/* Some SDL functions will malloc, we have to free! */
			if (freePtr)
			{
				Free(s);
			}
			return result;
		}
	}
}
