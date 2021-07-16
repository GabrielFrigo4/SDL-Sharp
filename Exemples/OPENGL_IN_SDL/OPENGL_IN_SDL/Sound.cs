using SDL_Sharp.OpenGL.Mathematics;
using static SDL_Sharp.OpenAL.AL;
using static SDL_Sharp.OpenAL.ALC;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System;

namespace OPENGL_IN_SDL
{
    public class Sound
    {
        //Sound
        float x = 0, y = 0, z = 0;
        uint source, buffer;
        short loop;
        public vec3 GetPos { get { return new vec3(x, y, z); } }

        //thread funcs and vars
        static object locker = new object();
        static Thread thread, mainThread;
        static List<Sound> newSounds = new List<Sound>();
        static List<Sound> updateSounds = new List<Sound>();
        static List<Sound> destroySounds = new List<Sound>();
        static void UpdateSound()
        {
            while (mainThread.IsAlive)
            {
                lock (locker)
                {
                    foreach (var sound in newSounds)
                    {
                        updateSounds.Add(sound);
                    }
                    newSounds.Clear();

                    foreach (var sound in updateSounds)
                    {
                        sound.Update();
                    }

                    foreach (var sound in destroySounds)
                    {
                        sound.Depose();
                        destroySounds.Remove(sound);
                    }
                    destroySounds.Clear();
                }
                Thread.Sleep(16);
            }
            ClearUp();
        }
        void Update()
        {
            int state;
            alGetSourcei(source, AL_SOURCE_STATE, out state);
            if (state == AL_STOPPED && loop != 0)
            {
                Play(loop);
                if (loop > 0)
                {
                    loop--;
                }
            }
        }

        /// <summary>
        /// Create a sound
        /// </summary>
        public Sound(string path, float volume)
        {
            source = alGenSource();
            buffer = LoadSound(path);
            alSourcef(source, AL_GAIN, 1);
            alSourcef(source, AL_PITCH, 1);
            alSource3f(source, AL_POSITION, 0, 0, 0);
            Volume(volume);
            newSounds.Add(this);
        }

        /// <summary>
        /// Set volume of a sound
        /// </summary>
        public void Volume(float volume)
        {
            alSourcef(source, AL_GAIN, volume);
        }

        /// <summary>
        /// Play a sound
        /// </summary>
        public void Play(short loop)
        {
            this.loop = loop;
            alSourcei(source, AL_BUFFER, (int)buffer);
            alSourcePlay(source);
        }

        /// <summary>
        /// Set position of a sound
        /// </summary>
        public void SetPosition(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            alSource3f(source, AL_POSITION, x, y, z);
        }

        /// <summary>
        /// Stop a sound
        /// </summary>
        public void Stop()
        {
            alSourceStop(source);
            loop = 0;
        }

        /// <summary>
        /// Delete a sound
        /// </summary>
        public void Delete()
        {
            destroySounds.Add(this);
        }

        void Depose()
        {
            alDeleteSource(source);
        }

        ~Sound()
        {
            Delete();
        }

        //AudioMaster
        static List<uint> buffers = new List<uint>();
        static IntPtr Device;
        static IntPtr Context;

        /// <summary>
        /// Init a sound system (is called when creating SGL_Window)
        /// </summary>
        public static void Init()
        {
            Device = alcOpenDevice(null);
            Context = alcCreateContext(Device, new int[0]);
            alcMakeContextCurrent(Context);

            mainThread = Thread.CurrentThread;
            thread = new Thread(new ThreadStart(UpdateSound));
            thread.Name = "sound";
            thread.Start();

            SetListenerData();
        }

        /// <summary>
        /// Set listener data (is called int Init)
        /// </summary>
        public static void SetListenerData()
        {
            alListener3f(AL_POSITION, 0f, 0f, 0f);
            alListener3f(AL_VELOCITY, 0f, 0f, 0f);
        }

        /// <summary>
        /// Set listener  position
        /// </summary>
        public static void SetListenerPosition(float x, float y, float z)
        {
            alListener3f(AL_POSITION, x, y, z);
            alListener3f(AL_VELOCITY, 0f, 0f, 0f);
        }

        unsafe static uint LoadSound(string path)
        {
            uint buffer = alGenBuffer();
            buffers.Add(buffer);

            int channels, bits_per_sample, sample_rate;
            byte[] sound_data = LoadWave(File.Open(path, FileMode.Open), out channels, out bits_per_sample, out sample_rate);

            alBufferData(buffer, GetSoundFormat(bits_per_sample), sound_data, sound_data.Length, sample_rate * channels);

            return buffer;
        }

        /// <summary>
        /// Clear up a sound system data (is called on SGL_Window destruction)
        /// </summary>
        static void ClearUp()
        {
            foreach (uint buffer in buffers)
            {
                alDeleteBuffer(buffer);
            }
            alcCloseDevice(Device);
        }

        //SoundMaster
        static byte[] LoadWave(Stream stream, out int channels, out int bits, out int rate)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");

            using (BinaryReader reader = new BinaryReader(stream))
            {
                // RIFF header
                string signature = new string(reader.ReadChars(4));
                if (signature != "RIFF")
                    throw new NotSupportedException("Specified stream is not a wave file.");

                int riff_chunck_size = reader.ReadInt32();

                string format = new string(reader.ReadChars(4));
                if (format != "WAVE")
                    throw new NotSupportedException("Specified stream is not a wave file.");

                // WAVE header
                string format_signature = new string(reader.ReadChars(4));
                if (format_signature != "fmt ")
                    throw new NotSupportedException("Specified wave file is not supported.");

                int format_chunk_size = reader.ReadInt32();
                int audio_format = reader.ReadInt16();
                int num_channels = reader.ReadInt16();
                int sample_rate = reader.ReadInt32();
                int byte_rate = reader.ReadInt32();
                int block_align = reader.ReadInt16();
                int bits_per_sample = reader.ReadInt16();

                string data_signature = new string(reader.ReadChars(4));
                //if (data_signature != "data")
                //    throw new NotSupportedException("Specified wave file is not supported.");

                int data_chunk_size = reader.ReadInt32();

                channels = num_channels;
                bits = bits_per_sample;
                rate = sample_rate;

                return reader.ReadBytes((int)reader.BaseStream.Length);
            }
        }

        static int GetSoundFormat(int bits)
        {
            switch (bits)
            {
                case 8: return AL_FORMAT_MONO8;
                case 16: return AL_FORMAT_MONO16;
                default: throw new NotSupportedException("The specified sound format is not supported.");
            }
        }
    }
}
