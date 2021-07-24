﻿using SDL_Sharp.OpenGL;
using System.IO;
using System;
using SDL_Sharp;

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
            window = SDL.CreateWindow("OPENGL_IN_SDL",SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, 800,600,WindowFlags.OpenGL);
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
            GLFunc.Import(SDL.GL_GetProcAddress);
            //Init OpenGL

            var program = CreateProgram();

            CreateVertices(out var vao, out var vbo);
            rand = new Random();

            var location = GL.GetUniformLocation(program, "color");
            SetRandomColor(location);
            long n = 0;

            Event e;
            var running = true;
            const float timeStep = 60f/1000f;
            float accumulator = 0.0f;
            float currentTime = HireTimeInSeconds();

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
                        }
                    }
                    accumulator -= timeStep;
                }

                float aplha = accumulator / timeStep;

                GL.Clear(ClearBufferMask.ColorBufferBit);

                if (n++ % 60 == 0)
                    SetRandomColor(location);

                // Draw the triangle.
                GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

                SDL.GL_SwapWindow(window);

                uint frashRate = 1000 / (uint)GetRefreshRate();

                uint frameTicks = SDL.GetTicks() - statTicks;
                if (frameTicks < frashRate)
                {
                    SDL.Delay(frashRate - frameTicks);
                }
            }
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

        private static void SetRandomColor(int location)
        {
            var r = (float)rand.NextDouble();
            var g = (float)rand.NextDouble();
            var b = (float)rand.NextDouble();
           GL.Uniform3(location, r, g, b);
        }

        private static int CreateProgram()
        {
            var vertex = CreateShader(ShaderType.VertexShader, File.ReadAllText("./Files/triangle.vert"));
            var fragment = CreateShader(ShaderType.FragmentShader, File.ReadAllText("./Files/triangle.frag"));

            var program = GL.CreateProgram();
            GL.AttachShader(program, vertex);
            GL.AttachShader(program, fragment);

            GL.LinkProgram(program);

            GL.DeleteShader(vertex);
            GL.DeleteShader(fragment);

            GL.UseProgram(program);
            return program;
        }

        /// <summary>
        /// Creates a shader of the specified type from the given source string.
        /// </summary>
        /// <param name="type">An OpenGL enum for the shader type.</param>
        /// <param name="source">The source code of the shader.</param>
        /// <returns>The created shader. No error checking is performed for this basic example.</returns>
        private static int CreateShader(ShaderType type, string source)
        {
            var shader = GL.CreateShader(type);
            GL.ShaderSource(shader, source);
            GL.CompileShader(shader);
            return shader;
        }

        /// <summary>
        /// Creates a VBO and VAO to store the vertices for a triangle.
        /// </summary>
        /// <param name="vao">The created vertex array object for the triangle.</param>
        /// <param name="vbo">The created vertex buffer object for the triangle.</param>
        private static unsafe void CreateVertices(out int vao, out int vbo)
        {

            var vertices = new[] {
                -0.5f, -0.5f, 0.0f,
                0.5f, -0.5f, 0.0f,
                0.0f,  0.5f, 0.0f
            };

            vao = GL.GenVertexArray();
            vbo = GL.GenBuffer();

            GL.BindVertexArray(vao);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            fixed (float* v = &vertices[0])
            {
                GL.BufferData(BufferTarget.ArrayBuffer, sizeof(float) * vertices.Length, v, BufferUsageHint.StaticDraw);
            }

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);
        }

        private static Random rand;
    }
}
