using SDL_Sharp;
using Silk.NET.OpenGL.Legacy;

namespace ConsoleApp1;
internal class Program
{
    static GL gl;
    static Window window;

    [Obsolete]
    static void Main()
    {
        SDL.Init(SdlInitFlags.Video);
        window = SDL.CreateWindow("teste", SDL.WINDOWPOS_CENTERED, SDL.WINDOWPOS_CENTERED, 800, 600, WindowFlags.OpenGL);
        GLContext glContext = SDL.GL_CreateContext(window);
        gl = GL.GetApi(SDL.GL_GetProcAddress);

        bool running = true;
        while (running)
        {
            while (SDL.PollEvent(out Event e) == 1)
            {
                switch (e.Type)
                {
                    case EventType.Quit:
                        running = false;
                        break;
                }
            }

            gl.Viewport(0, 0, 800, 600);
            gl.ClearColor(1f, 0f, 1f, 0f);
            gl.Clear(ClearBufferMask.ColorBufferBit);

            gl.Begin(PrimitiveType.Triangles);
            gl.Color3(1f, 0f, 0f);
            gl.Vertex3(-1, -1, 0);
            gl.Vertex3(0, 1, 0);
            gl.Vertex3(1, -1, 0);
            gl.End();

            SDL.GL_SwapWindow(window);
        }
    }
}
