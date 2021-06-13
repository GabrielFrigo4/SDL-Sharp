using SDL_Sharp;
using System;

namespace CreateWindow
{
    class Game
    {
        static Window window;
        static Renderer renderer;

        static unsafe void Main(string[] args)
        {
            window = SDL.CreateWindow("Window", SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, 800, 600, WindowFlags.Shown);
            renderer = SDL.CreateRenderer(window, -1, RendererFlags.Accelerated);

            Event e;
            bool running = true;

            while (running)
            {
                while (SDL.PollEvent(&e) == 1)
                {
                    switch (e.Type)
                    {
                        case EventType.Quit:
                            running = false;
                            break;
                    }
                }
            }
        }
    }
}
