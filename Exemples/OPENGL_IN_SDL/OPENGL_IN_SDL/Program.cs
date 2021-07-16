using System;

namespace OPENGL_IN_SDL
{
    class Program
    {
        static void Main(string[] args)
        {
            Sound.Init();
            Sound sound = new Sound("./sound.wav", 1f);
            sound.Volume(1);
            sound.Play(-1);
            Console.WriteLine("Hello World!");
            while (true)
            {

            }
        }
    }
}
