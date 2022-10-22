using SDL_Sharp.Mixer;
using System;

namespace SDL_PLUS_EXTENSIONS;
class SoundChunk
{
    PChunk chunk;
    int volume = MIX.MAX_VOLUME;

    public static SoundChunk CreateSoundChunk(string path)
    {
        return new SoundChunk(path);
    }

    SoundChunk(string path)
    {
        MIX.LoadWAV(path, out chunk);
        if(chunk.IsNull)
            throw new Exception("PChunk not create");
        MIX.VolumeChunk(chunk, volume);
    }

    public void Play(int loop)
    {
        if (MIX.PlayChannel(0, chunk, loop) == -1)
        {
            Console.WriteLine(MIX.GetError());
        }
    }

    public void SetVolume(int volume)
    {
        this.volume = volume;
        MIX.VolumeChunk(chunk, volume);
    }

    ~SoundChunk()
    {
        MIX.FreeChunk(chunk);
    }
}

class SoundMusic
{
    public Music music;
    public static SoundMusic CurrentMusic { get; private set; }

    static int volume = MIX.MAX_VOLUME;
    public static int CurrentVolume { get => volume; }

    public static SoundMusic CreateSoundMusic(string path)
    {
        return new SoundMusic(path);
    }

    SoundMusic(string path)
    {
        music = MIX.LoadMUS(path);
        if (music.IsNull)
            throw new Exception("Music not create");
    }

    public static void PlayMusic(SoundMusic music, int loop)
    {
        CurrentMusic = music;
        if (MIX.PlayMusic(music.music, loop) == -1)
        {
            Console.WriteLine(MIX.GetError());
        }
    }

    public static void SetVolume(int volume)
    {
        SoundMusic.volume = volume;
        MIX.VolumeMusic(SoundMusic.volume);
    }

    ~SoundMusic()
    {
        MIX.FreeMusic(music);
    }
}
