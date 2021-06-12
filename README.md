is a SDL2 for c#
The wrapper provides bindings for the following libraries:
- SDL2 (2.0.14)
- SDL2_image (2.0.5)
- SDL2_mixer (2.0.4)
- SDL2_ttf (2.0.15)
and contains the necessary DLLs for the project

nuget 32-bits: [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp_32-bits.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp_32-bits/)
nuget 64-bits: [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp_64-bits.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp_64-bits/)

the project was made based on 2 other projects
the SharpSDL (https://github.com/hasali19/SharpSDL)
and the SDL2 # (https://github.com/flibitijibibo/SDL2-CS)
With some modifications in both

This project aims to make SDL2 non-aggressive in c#
an SDL2 code # would look like this:

//////

SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

IntPtr window = SDL.SDL_CreateWindow(title, SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, height, width, windowFlags);

IntPtr renderer = SDL.SDL_CreateRenderer(window,
                                      -1,
                                      SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED |
                                      SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
                                      
//////

and on SDL-Sharp like this:

SDL.Init(SdlInitFlags.Video);

Window window = SDL.CreateWindow(title, SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, height, width, windowFlags);

Renderer renderer = SDL.CreateRenderer(window, -1, RendererFlags.Accelerated | RendererFlags.PresentVsync);

//////

in SDL-Sharp Window, Renderer, Texture, Font and Music are pointers same as IntPtr

So the SDL.CreateWindow() function returns a Window and not a Window* (exemple)

However Surface, Chunck and others are not pointers, so the functions return a Surface* (example)

to be able to use pointers in C#, you have to enable Unsafe Code and use these pointers (void*) inside an unsafe { //Pointers here// }
