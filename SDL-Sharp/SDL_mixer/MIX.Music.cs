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
		#region Animated Music Support

		/* IntPtr refers to a Mix_Music* */
		[DllImport(nativeLibName, EntryPoint = "Mix_LoadMUS", CallingConvention = CallingConvention.Cdecl)]
		private static extern Music INTERNAL_Mix_LoadMUS(
			byte* file
		);
		public static Music LoadMUS(string file)
		{
			byte* utf8File = SDL.Utf8Encode(file);
			Music handle = INTERNAL_Mix_LoadMUS(
				utf8File
			);
			Marshal.FreeHGlobal((IntPtr)utf8File);
			return handle;
		}

		/* music refers to a Mix_Music* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FreeMusic")]
		public static extern void FreeMusic(Music music);

		[DllImport(nativeLibName, EntryPoint = "Mix_GetMusicDecoder", CallingConvention = CallingConvention.Cdecl)]
		private static extern Music INTERNAL_Mix_GetMusicDecoder(int index);
		public static string GetMusicDecoder(int index)
		{
			return SDL.UTF8_ToManaged(
				INTERNAL_Mix_GetMusicDecoder(index)
			);
		}

		/* music refers to a Mix_Music* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetMusicType")]
		public static extern MusicType GetMusicType(Music music);

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, EntryPoint = "Mix_GetMusicTitle", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_Mix_GetMusicTitle(Music music);
		public static string GetMusicTitle(Music music)
		{
			return SDL.UTF8_ToManaged(
				INTERNAL_Mix_GetMusicTitle(music)
			);
		}

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, EntryPoint = "Mix_GetMusicTitleTag", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_Mix_GetMusicTitleTag(Music music);
		public static string GetMusicTitleTag(Music music)
		{
			return SDL.UTF8_ToManaged(
				INTERNAL_Mix_GetMusicTitleTag(music)
			);
		}

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, EntryPoint = "Mix_GetMusicArtistTag", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_Mix_GetMusicArtistTag(Music music);
		public static string GetMusicArtistTag(Music music)
		{
			return SDL.UTF8_ToManaged(
				INTERNAL_Mix_GetMusicArtistTag(music)
			);
		}

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, EntryPoint = "Mix_GetMusicAlbumTag", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_Mix_GetMusicAlbumTag(Music music);
		public static string GetMusicAlbumTag(Music music)
		{
			return SDL.UTF8_ToManaged(
				INTERNAL_Mix_GetMusicAlbumTag(music)
			);
		}

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, EntryPoint = "Mix_GetMusicCopyrightTag", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr INTERNAL_Mix_GetMusicCopyrightTag(Music music);
		public static string GetMusicCopyrightTag(Music music)
		{
			return SDL.UTF8_ToManaged(
				INTERNAL_Mix_GetMusicCopyrightTag(music)
			);
		}

		/* music refers to a Mix_Music* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_PlayMusic")]
		public static extern int PlayMusic(Music music, int loops);

		/* music refers to a Mix_Music* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadeInMusic")]
		public static extern int FadeInMusic(
			Music music,
			int loops,
			int ms
		);

		/* music refers to a Mix_Music* */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadeInMusicPos")]
		public static extern int FadeInMusicPos(
			Music music,
			int loops,
			int ms,
			double position
		);

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetVolumeMusicStream")]
		public static extern int GetVolumeMusicStream(Music music);

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetMusicPosition")]
		public static extern double GetMusicPosition(Music music);

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_MusicDuration")]
		public static extern double MusicDuration(Music music);

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetMusicLoopStartTime")]
		public static extern double GetMusicLoopStartTime(Music music);

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetMusicLoopEndTime")]
		public static extern double GetMusicLoopEndTime(Music music);

		/* music refers to a Mix_Music*
		 * Only available in 2.0.5 or higher.
		 */
		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetMusicLoopLengthTime")]
		public static extern double GetMusicLoopLengthTime(Music music);

        #endregion
    }
}
