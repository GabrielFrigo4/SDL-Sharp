using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Music
	{
		private readonly IntPtr ptr;

		public Music(IntPtr ptr)
		{
			this.ptr = ptr;
		}

		public static implicit operator IntPtr(Music music)
		{
			return music.ptr;
		}

		public static implicit operator Music(IntPtr ptr)
		{
			return new Music(ptr);
		}
	}

	public enum MusicType
	{
		None,
		Cmd,
		Wav,
		Mod,
		Mid,
		Ogg,
		Mp3,
		Mp3_mad_unused,
		Flac,
		ModPlug_unused,
		Opus
	}

	public enum Fading
	{
		Fading,
		Fading_out,
		Fading_in
	}

	public unsafe static partial class MIX
    {

    }
}
