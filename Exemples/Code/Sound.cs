using SDL_Sharp.Mixer;
using System;

namespace SDL_PLUS_EXTENSIONS
{
    unsafe class Sound
    {
        Chunk* chunck;
        int volume = MIX.MAX_VOLUME;

        public static Sound CreateSound(string path)
        {
            return new Sound(path);
        }

        Sound(string path)
        {
            chunck = MIX.LoadWAV(path);
            MIX.VolumeChunk(chunck, volume);
        }

        public void Play(int loop)
        {
            MIX.PlayChannel(-1, chunck, loop);
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
            MIX.VolumeChunk(chunck, volume);
        }
    }
}
