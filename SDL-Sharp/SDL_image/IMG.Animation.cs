using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp
{
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

    }
}
