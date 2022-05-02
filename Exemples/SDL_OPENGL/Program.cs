using SDL_Sharp;
using SDL_Sharp.Utility;
using Silk.NET.OpenGL.Legacy;

namespace ConsoleApp1;
internal class Program
{
    static GL? _gl;
    static GL gl
    {
        get
        {
            if(_gl is not null)
                return _gl;

            throw new Exception("OpenGL is not init");
        }

        set
        {
            _gl = value;
        }
    }
    static Window window;

    [Obsolete]
    static void Main()
    {
        WinUtils.SetDpiAwareness(WinHighDpiMode.SystemAware);

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
