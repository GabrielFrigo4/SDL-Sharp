using SDL_Sharp.OpenGL.Mathematics;
using SDL_Sharp.OpenAL;
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
        public Vector3 GetPos { get { return new Vector3(x, y, z); } }

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
            AL.GetSource(source, ALSourcei.SourceType, out state);
            if ((ALSourceState)state == ALSourceState.Stopped && loop != 0)
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
            source = AL.GenSource();
            buffer = LoadSound(path);
            AL.Source(source, ALSourcef.Gain, 1);
            AL.Source(source, ALSourcef.Pitch, 1);
            AL.Source(source, ALSource3f.Position, 0, 0, 0);
            Volume(volume);
            newSounds.Add(this);
        }

        /// <summary>
        /// Set volume of a sound
        /// </summary>
        public void Volume(float volume)
        {
            AL.Source(source, ALSourcef.Gain, volume);
        }

        /// <summary>
        /// Play a sound
        /// </summary>
        public void Play(short loop)
        {
            this.loop = loop;
            AL.Source(source, ALSourcei.Buffer, (int)buffer);
            AL.SourcePlay(source);
        }

        /// <summary>
        /// Set position of a sound
        /// </summary>
        public void SetPosition(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            AL.Source(source, ALSource3f.Position, x, y, z);
        }

        /// <summary>
        /// Stop a sound
        /// </summary>
        public void Stop()
        {
            AL.SourceStop(source);
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
            AL.DeleteSource(source);
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
            Device = ALC.OpenDevice(null);
            Context = ALC.CreateContext(Device, new int[0]);
            ALC.MakeContextCurrent(Context);

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
            AL.Listener(ALListener3f.Position, 0f, 0f, 0f);
            AL.Listener(ALListener3f.Velocity, 0f, 0f, 0f);
        }

        /// <summary>
        /// Set listener  position
        /// </summary>
        public static void SetListenerPosition(float x, float y, float z)
        {
            AL.Listener(ALListener3f.Position, x, y, z);
            AL.Listener(ALListener3f.Velocity, 0f, 0f, 0f);
        }

        unsafe static uint LoadSound(string path)
        {
            uint buffer = AL.GenBuffer();
            buffers.Add(buffer);

            int channels, bits_per_sample, sample_rate;
            byte[] sound_data = LoadWave(File.Open(path, FileMode.Open), out channels, out bits_per_sample, out sample_rate);

            fixed(void* pointer = sound_data)
            {
                IntPtr ptr = new IntPtr(pointer);
                AL.BufferData(buffer, GetSoundFormat(bits_per_sample), ptr, sound_data.Length, sample_rate * channels);
            }

            return buffer;
        }

        /// <summary>
        /// Clear up a sound system data (is called on SGL_Window destruction)
        /// </summary>
        static void ClearUp()
        {
            foreach (uint buffer in buffers)
            {
                AL.DeleteBuffer(buffer);
            }
            ALC.CloseDevice(Device);
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

        static ALFormat GetSoundFormat(int bits)
        {
            switch (bits)
            {
                case 8: return ALFormat.Mono8;
                case 16: return ALFormat.Mono16;
                default: throw new NotSupportedException("The specified sound format is not supported.");
            }
        }
    }
}
