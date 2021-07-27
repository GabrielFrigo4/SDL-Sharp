using SDL_Sharp.OpenGL;
using System.IO;
using System;
using SDL_Sharp;
using SDL_Sharp.OpenGL.Mathematics;

namespace OPENGL_IN_SDL
{
    class Program
    {
        static Window window;

        static void Main(string[] args)
        {
            //Init SDL & Sound
            Sound.Init();
            Sound sound = new Sound("./Files/sound.wav", 1f);
            sound.Play(-1);

            SDL.Init(SdlInitFlags.Video);

            window = SDL.CreateWindow("OPENGL_IN_SDL",SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, 900, 660, WindowFlags.OpenGL | WindowFlags.Hidden);
            //Init SDL & Sound

            //Init OpenGL
            SDL.GL_SetAttribute(GLAttr.RedSize, 5);
            SDL.GL_SetAttribute(GLAttr.GreenSize, 5);
            SDL.GL_SetAttribute(GLAttr.BlueSize, 5);
            SDL.GL_SetAttribute(GLAttr.DepthSize, 16);
            SDL.GL_SetAttribute(GLAttr.DepthSize, 1);
            GLContext gContext = SDL.GL_CreateContext(window);
            if (gContext == IntPtr.Zero)
            {
                Console.WriteLine("OpenGL context could not be created! SDL Error: %s\n" + SDL.GetErrorString());
            }
            //Init OpenGL

            Shader.asset_shader = new Shader("./Files/Basic/basic.vert", "./Files/Basic/basic.frag");
            Sprite spr = new Sprite("./Files/SDL_Img.png", new Vector2(0.5f,0.5f));

            Event e;
            var running = true;
            const float timeStep = 60f/1000f;
            float accumulator = 0.0f;
            float currentTime = HireTimeInSeconds();
            SDL.ShowWindow(window);

            while (running)
            {
                uint statTicks = SDL.GetTicks();
                float newTime = HireTimeInSeconds();
                float frameTime = newTime - currentTime;

                currentTime = newTime;

                accumulator += frameTime;

                while (accumulator >= timeStep)
                {
                    while (SDL.PollEvent(out e) == 1)
                    {
                        switch (e.Type)
                        {
                            case EventType.Quit:
                                running = false;
                                break;
                            case EventType.KeyDown:
                                if (Keycode.Escape == e.Keyboard.Keysym.Sym)
                                {
                                    running = false;
                                }
                                break;
                        }
                    }
                    accumulator -= timeStep;
                }

                float aplha = accumulator / timeStep;

                GL.Clear(ClearBufferMask.ColorBufferBit);

                DrawSprite(spr, 0, 0);

                SDL.GL_SwapWindow(window);

                uint frashRate = 1000 / (uint)GetRefreshRate();

                uint frameTicks = SDL.GetTicks() - statTicks;
                if (frameTicks < frashRate)
                {
                    SDL.Delay(frashRate - frameTicks);
                }
            }
        }

        public static void DrawSprite(Sprite sprite, float x, float y, int image_index = 0, float image_angle = 0, float scale_x = 1, float scale_y = 1)
        {
            float angRad = MathHelper.DegreesToRadians(image_angle);

            int width, height;
            SDL.GetWindowSize(window, out width, out height);
            Vector2 texel_world = new Vector2(1f / width, 1f / height);

            if (image_index < sprite.IndMax)
                GL.BindVertexArray(sprite.Sprite_Image[image_index]);
            else
                GL.BindVertexArray(sprite.Sprite_Image[sprite.IndMax - 1]);

            var transformImage = Matrix4.Identity;

            transformImage = transformImage * Matrix4.CreateScale(scale_x, scale_y, 1.0f);

            transformImage = transformImage * Matrix4.CreateRotationZ(angRad);

            transformImage = transformImage * Matrix4.CreateTranslation(x, y, 0.0f);

            transformImage = transformImage * Matrix4.CreateScale(texel_world.X * 2, texel_world.Y * 2, 1.0f);

            sprite.Use(TextureUnit.Texture0);
            Shader.asset_shader.Use();

            Shader.asset_shader.SetMatrix4("transform", transformImage);

            GL.DrawElements(BeginMode.Triangles, sprite.Indices.Length, DrawElementsType.UnsignedInt, 0);
        }

        private static float HireTimeInSeconds()
        {
            float t = SDL.GetTicks();
            t *= 0.001f;
            return t;
        }

        private static int GetRefreshRate()
        {
            int displayIndex = SDL.GetWindowDisplayIndex(window);

            DisplayMode mode;

            SDL.GetDisplayMode(displayIndex, 0 ,out mode);

            return mode.RefreshRate;
        }
    }
}
