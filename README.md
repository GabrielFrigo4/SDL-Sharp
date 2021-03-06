Is a SDL2 for c#. The wrapper provides bindings for the following libraries (contains the necessary DLLs for the project in SDL-Sharp-DLL):
- SDL2 (2.0.20) in SDL_Sharp
- SDL2_image (2.0.5) in SDL_Sharp.Image
- SDL2_mixer (2.0.4) in SDL_Sharp.Mixer
- SDL2_ttf (2.0.18) in SDL_Sharp.Ttf
- Utils(functions that facilitate the development)

To use opengl and openal in SDL we recommend using Silk.NET: https://github.com/dotnet/Silk.NET

new nuget(
nuget Sharp-SDL: [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp.svg?style=flat-square)](https://www.nuget.org/packages//SDL-Sharp/)
nuget Sharp-SDL-DLL: [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp-DLL.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp-DLL/))

nuget obsolete(
nuget 32-bits: [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp_32-bits.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp_32-bits/)
nuget 64-bits: [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp_64-bits.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp_64-bits/))

the project was made based on other projects

the SharpSDL (https://github.com/hasali19/SharpSDL)

and the SDL2 # (https://github.com/flibitijibibo/SDL2-CS)

and the SharpFont (https://github.com/Robmaister/SharpFont)

and the OpenTK (https://github.com/opentk/opentk)

and the Pencil.Gaming (https://github.com/andykorth/Pencil.Gaming)

and the Silk.NET (https://github.com/dotnet/Silk.NET)

With some modifications in both

This project aims to make SDL2 non-aggressive in c#


SDL2 code # would look like this:

////// [exemple 1]

SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

IntPtr window = SDL.SDL_CreateWindow("Window", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 800, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

IntPtr renderer = SDL.SDL_CreateRenderer(window,
                                      -1,
                                      SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED |
                                      SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
                                      
////// [exemple 2]

And on SDL-Sharp like this:

SDL.Init(SdlInitFlags.Video);

Window window = SDL.CreateWindow("Window", SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, 800, 600, WindowFlags.Shown);

Renderer renderer = SDL.CreateRenderer(window, -1, RendererFlags.Accelerated | RendererFlags.PresentVsync);

//////

In SDL-Sharp Window, Renderer, Texture, Font and Music are pointers same as IntPtr

So the SDL.CreateWindow() function returns a Window and not a Window* (exemple)

However Surface, Chunk and others are not pointers, so the functions return a Surface* or PSurface (example), in these cases there are P(Structure name) such as PChunk, PSurface...
(P of pointer)

to be able to use pointers in C#, you have to enable Unsafe Code and use these pointers (void*) inside an unsafe { //Pointers here// }
