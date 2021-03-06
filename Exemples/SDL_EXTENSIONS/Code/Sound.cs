using SDL_Sharp.Mixer;

namespace SDL_PLUS_EXTENSIONS
{
    class Sound
    {
        PChunk chunck;
        int volume = MIX.MAX_VOLUME;

        public static Sound CreateSound(string path)
        {
            return new Sound(path);
        }

        Sound(string path)
        {
            MIX.LoadWAV(path, out chunck);
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
