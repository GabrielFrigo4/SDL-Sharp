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

namespace SDL_Sharp.Mixer;
public unsafe static partial class MIX
{
	#region SDL2# Variables

	/* Used by DllImport to load the native library. */
	private const string NativeLibName = "SDL2_mixer";

	#endregion

	#region SDL_mixer.h

	/* Similar to the headers, this is the version we're expecting to be
	 * running with. You will likely want to check this somewhere in your
	 * program!
	 */
	public const int MAJOR_VERSION = 2;
	public const int MINOR_VERSION = 0;
	public const int PATCHLEVEL = 5;

	/* In C, you can redefine this value before including SDL_mixer.h.
	 * We're not going to allow this in SDL2#, since the value of this
	 * variable is persistent and not dependent on preprocessor ordering.
	 */
	public const int CHANNELS = 8;

	public static readonly int DEFAULT_FREQUENCY = 44100;
	public static readonly ushort DEFAULT_FORMAT =
		BitConverter.IsLittleEndian ? (ushort)AudioFormatFlags.S16LSB : (ushort)AudioFormatFlags.S16MSB;
	public static readonly int DEFAULT_CHANNELS = 2;
	public static readonly byte MAX_VOLUME = 128;

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MixFuncDelegate(
		IntPtr udata, // void*
		IntPtr stream, // Uint8*
		int len
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Mix_EffectFunc_t(
		int chan,
		IntPtr stream, // void*
		int len,
		IntPtr udata // void*
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Mix_EffectDone_t(
		int chan,
		IntPtr udata // void*
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MusicFinishedDelegate();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ChannelFinishedDelegate(int channel);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int SoundFontDelegate(
		IntPtr a, // const char*
		IntPtr b // void*
	);

	public static void GetVersion(out Version X)
	{
		X.Major = MAJOR_VERSION;
		X.Minor = MINOR_VERSION;
		X.Patch = PATCHLEVEL;
	}

	public static void GetVersion(Version* X)
	{
		X->Major = MAJOR_VERSION;
		X->Minor = MINOR_VERSION;
		X->Patch = PATCHLEVEL;
	}

	[DllImport(NativeLibName, EntryPoint = "MIX_Linked_Version", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_MIX_Linked_Version();
	public static Version Linked_Version()
	{
		Version result;
		IntPtr result_ptr = INTERNAL_MIX_Linked_Version();
		result = (Version)Marshal.PtrToStructure(
			result_ptr,
			typeof(Version)
		);
		return result;
	}

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_Init")]
	public static extern int Init(MixInitFlags flags);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_Quit")]
	public static extern void Quit();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_OpenAudio")]
	public static extern int OpenAudio(
		int frequency,
		ushort format,
		int channels,
		int chunksize
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_AllocateChannels")]
	public static extern int AllocateChannels(int numchans);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_QuerySpec")]
	public static extern int QuerySpec(
		out int frequency,
		out ushort format,
		out int channels
	);
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_QuerySpec")]
	public static extern int QuerySpec(
		int* frequency,
		ushort* format,
		int* channels
	);

	/* src refers to an SDL_RWops*, IntPtr to a Mix_Chunk* */
	/* THIS IS A PUBLIC RWops FUNCTION! */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_LoadWAV_RW")]
	public static extern Chunk* LoadWAV_RW(
		RWops src,
		int freesrc
	);
	public static void LoadWAV_RW(
		RWops src,
		int freesrc,
		out Chunk* chunk
    )
    {
		chunk = LoadWAV_RW(src, freesrc);
	}
	public static void LoadWAV_RW(
	RWops src,
	int freesrc,
	out PChunk chunk
)
	{
		chunk = LoadWAV_RW(src, freesrc);
	}

	/* IntPtr refers to a Mix_Chunk* */
	/* This is an RWops macro in the C header. */
	public static Chunk* LoadWAV(string file)
	{
		RWops rwops = SDL.RWFromFile(file, "rb");
		return LoadWAV_RW(rwops, 1);
	}
	public static void LoadWAV(string file, out Chunk* chunk)
	{
		RWops rwops = SDL.RWFromFile(file, "rb");
		chunk = LoadWAV_RW(rwops, 1);
	}
	public static void LoadWAV(string file, out PChunk chunk)
	{
		RWops rwops = SDL.RWFromFile(file, "rb");
		chunk = LoadWAV_RW(rwops, 1);
	}

	/* IntPtr refers to a Mix_Chunk* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_QuickLoad_WAV")]
	public static extern Chunk* QuickLoad_WAV(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
			byte[] mem
	);
	public static void QuickLoad_WAV(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
			byte[] mem,
		out Chunk* chunk
    )
    {
		chunk = QuickLoad_WAV(mem);
	}
	public static void QuickLoad_WAV(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1)]
			byte[] mem,
		out PChunk chunk
	)
	{
		chunk = QuickLoad_WAV(mem);
	}

	/* IntPtr refers to a Mix_Chunk* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_QuickLoad_RAW")]
	public static extern Chunk* QuickLoad_RAW(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)]
			byte[] mem,
		uint len
	);
	public static void QuickLoad_RAW(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)]
			byte[] mem,
		uint len,
		out Chunk* chunk
    )
    {
		chunk = QuickLoad_RAW(mem, len);
	}
	public static void QuickLoad_RAW(
		[In()] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)]
			byte[] mem,
		uint len,
		out PChunk chunk
    )
    {
		chunk = QuickLoad_RAW(mem, len);
	}

	/* chunk refers to a Mix_Chunk* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FreeChunk")]
	public static extern void FreeChunk(Chunk* chunk);
	
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FreeChunk")]
	public static extern void FreeChunk(PChunk chunk);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetNumChunkDecoders")]
	public static extern int GetNumChunkDecoders();

	[DllImport(NativeLibName, EntryPoint = "Mix_GetChunkDecoder", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_Mix_GetChunkDecoder(int index);
	public static string GetChunkDecoder(int index)
	{
		return SDL.UTF8_ToManaged(
			INTERNAL_Mix_GetChunkDecoder(index)
		);
	}

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetNumMusicDecoders")]
	public static extern int GetNumMusicDecoders();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetPostMix")]
	public static extern void SetPostMix(
		MixFuncDelegate mix_func,
		IntPtr arg // void*
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_HookMusic")]
	public static extern void HookMusic(
		MixFuncDelegate mix_func,
		IntPtr arg // void*
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_HookMusicFinished")]
	public static extern void HookMusicFinished(
		MusicFinishedDelegate music_finished
	);

	/* IntPtr refers to a void* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetMusicHookData")]
	public static extern IntPtr GetMusicHookData();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_ChannelFinished")]
	public static extern void ChannelFinished(
		ChannelFinishedDelegate channel_finished
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_RegisterEffect")]
	public static extern int RegisterEffect(
		int chan,
		Mix_EffectFunc_t f,
		Mix_EffectDone_t d,
		IntPtr arg // void*
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_UnregisterEffect")]
	public static extern int UnregisterEffect(
		int channel,
		Mix_EffectFunc_t f
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_UnregisterAllEffects")]
	public static extern int UnregisterAllEffects(int channel);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetPanning")]
	public static extern int SetPanning(
		int channel,
		byte left,
		byte right
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetPosition")]
	public static extern int SetPosition(
		int channel,
		short angle,
		byte distance
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetDistance")]
	public static extern int SetDistance(int channel, byte distance);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetReverseStereo")]
	public static extern int SetReverseStereo(int channel, int flip);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_ReserveChannels")]
	public static extern int ReserveChannels(int num);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GroupChannel")]
	public static extern int GroupChannel(int which, int tag);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GroupChannels")]
	public static extern int GroupChannels(int from, int to, int tag);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GroupAvailable")]
	public static extern int GroupAvailable(int tag);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GroupCount")]
	public static extern int GroupCount(int tag);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GroupOldest")]
	public static extern int GroupOldest(int tag);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GroupNewer")]
	public static extern int GroupNewer(int tag);

	/* chunk refers to a Mix_Chunk* */
	public static int PlayChannel(
		int channel,
		Chunk* chunk,
		int loops
	)
	{
		return PlayChannelTimed(channel, chunk, loops, -1);
	}
	public static int PlayChannel(
		int channel,
		PChunk chunk,
		int loops
	)
	{
		return PlayChannelTimed(channel, chunk, loops, -1);
	}

	/* chunk refers to a Mix_Chunk* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_PlayChannelTimed")]
	public static extern int PlayChannelTimed(
		int channel,
		Chunk* chunk,
		int loops,
		int ticks
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_PlayChannelTimed")]
	public static extern int PlayChannelTimed(
		int channel,
		PChunk chunk,
		int loops,
		int ticks
	);

	/* chunk refers to a Mix_Chunk* */
	public static int FadeInChannel(
		int channel,
		Chunk* chunk,
		int loops,
		int ms
	)
	{
		return FadeInChannelTimed(channel, chunk, loops, ms, -1);
	}
	public static int FadeInChannel(
	int channel,
	PChunk chunk,
	int loops,
	int ms
	)
	{
		return FadeInChannelTimed(channel, chunk, loops, ms, -1);
	}

	/* chunk refers to a Mix_Chunk* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadeInChannelTimed")]
	public static extern int FadeInChannelTimed(
		int channel,
		Chunk* chunk,
		int loops,
		int ms,
		int ticks
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadeInChannelTimed")]
	public static extern int FadeInChannelTimed(
		int channel,
		PChunk chunk,
		int loops,
		int ms,
		int ticks
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_Volume")]
	public static extern int Volume(int channel, int volume);

	/* chunk refers to a Mix_Chunk* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_VolumeChunk")]
	public static extern int VolumeChunk(
		Chunk* chunk,
		int volume
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_VolumeChunk")]
	public static extern int VolumeChunk(
		PChunk chunk,
		int volume
	);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_VolumeMusic")]
	public static extern int VolumeMusic(int volume);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_HaltChannel")]
	public static extern int HaltChannel(int channel);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_HaltGroup")]
	public static extern int HaltGroup(int tag);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_HaltMusic")]
	public static extern int HaltMusic();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_ExpireChannel")]
	public static extern int ExpireChannel(int channel, int ticks);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadeOutChannel")]
	public static extern int FadeOutChannel(int which, int ms);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadeOutGroup")]
	public static extern int FadeOutGroup(int tag, int ms);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadeOutMusic")]
	public static extern int FadeOutMusic(int ms);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadingMusic")]
	public static extern Fading FadingMusic();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_FadingChannel")]
	public static extern Fading FadingChannel(int which);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_Pause")]
	public static extern void Pause(int channel);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_Resume")]
	public static extern void Resume(int channel);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_Paused")]
	public static extern int Paused(int channel);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_PauseMusic")]
	public static extern void PauseMusic();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_ResumeMusic")]
	public static extern void ResumeMusic();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_RewindMusic")]
	public static extern void RewindMusic();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_PausedMusic")]
	public static extern int PausedMusic();

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetMusicPosition")]
	public static extern int SetMusicPosition(double position);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_Playing")]
	public static extern int Playing(int channel);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_PlayingMusic")]
	public static extern int PlayingMusic();

	[DllImport(NativeLibName, EntryPoint = "Mix_SetMusicCMD", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_Mix_SetMusicCMD(
		byte* command
	);
	public static int SetMusicCMD(string command)
	{
		byte* utf8Cmd = SDL.Utf8Encode(command);
		int result = INTERNAL_Mix_SetMusicCMD(
			utf8Cmd
		);
		Marshal.FreeHGlobal((IntPtr)utf8Cmd);
		return result;
	}

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetSynchroValue")]
	public static extern int SetSynchroValue(int value);

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetSynchroValue")]
	public static extern int GetSynchroValue();

	[DllImport(NativeLibName, EntryPoint = "Mix_SetSoundFonts", CallingConvention = CallingConvention.Cdecl)]
	private static extern int INTERNAL_Mix_SetSoundFonts(
		byte* paths
	);
	public static int SetSoundFonts(string paths)
	{
		byte* utf8Paths = SDL.Utf8Encode(paths);
		int result = INTERNAL_Mix_SetSoundFonts(
			utf8Paths
		);
		Marshal.FreeHGlobal((IntPtr)utf8Paths);
		return result;
	}

	[DllImport(NativeLibName, EntryPoint = "Mix_GetSoundFonts", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_Mix_GetSoundFonts();
	public static string GetSoundFonts()
	{
		return SDL.UTF8_ToManaged(
			INTERNAL_Mix_GetSoundFonts()
		);
	}

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_EachSoundFont")]
	public static extern int EachSoundFont(
		SoundFontDelegate function,
		IntPtr data // void*
	);

	/* Only available in 2.0.5 or later. */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_SetTimidityCfg")]
	public static extern int SetTimidityCfg(
		[In()] [MarshalAs(UnmanagedType.LPStr)]
			string path
	);

	/* Only available in 2.0.5 or later. */
	[DllImport(NativeLibName, EntryPoint = "Mix_GetTimidityCfg", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr INTERNAL_Mix_GetTimidityCfg();
	public static string GetTimidityCfg()
	{
		return SDL.UTF8_ToManaged(
			INTERNAL_Mix_GetTimidityCfg()
		);
	}

	/* IntPtr refers to a Mix_Chunk* */
	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_GetChunk")]
	public static extern Chunk* GetChunk(int channel);
	public static void GetChunk(int channel, out Chunk* chunk)
	{
		chunk = GetChunk(channel);
	}
	public static void GetChunk(int channel, out PChunk chunk)
    {
		chunk = GetChunk(channel);
    }

	[DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Mix_CloseAudio")]
	public static extern void CloseAudio();

	#endregion
}

[Flags]
public enum MixInitFlags
{
	Flac = 0x00000001,
	Mod = 0x00000002,
	Mp3 = 0x00000008,
	Ogg = 0x00000010,
	Mid = 0x00000020,
	Opus = 0x00000040
}

[StructLayout(LayoutKind.Sequential)]
public struct Chunk
{
    public int Allocated;
    public IntPtr Abuf; /* Uint8* */
    public uint Alen;
    public byte Volume;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct PChunk
{
    private readonly Chunk* ptr;

    public PChunk(Chunk* ptr)
    {
        this.ptr = ptr;
    }

    public static implicit operator Chunk*(PChunk chunk)
    {
        return chunk.ptr;
    }

    public static implicit operator PChunk(Chunk* ptr)
    {
        return new PChunk(ptr);
    }
}