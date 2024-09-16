# SDL-Sharp

Is a SDL2 for c#. The wrapper provides bindings for the following libraries (contains the necessary DLLs for the project in [SDL-Sharp-DLL](https://www.nuget.org/packages//SDL-Sharp-DLL/)):
- [SDL2](https://github.com/libsdl-org/SDL/releases) (2.30.7) in SDL_Sharp
- [SDL2_image](https://github.com/libsdl-org/SDL_Image/releases) (2.8.2) in SDL_Sharp.Image
- [SDL2_mixer](https://github.com/libsdl-org/SDL_Mixer/releases) (2.8.0) in SDL_Sharp.Mixer
- [SDL2_ttf](https://github.com/libsdl-org/SDL_Ttf/releases) (2.22.0) in SDL_Sharp.Ttf
- Utils (functions that facilitate the development)

To use opengl and openal in SDL we recommend using [Silk.NET](https://github.com/dotnet/Silk.NET) and [OpenTK](https://github.com/opentk/opentk)

### New Nuget
 - [SDL-Sharp](https://www.nuget.org/packages//SDL-Sharp/): [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp.svg?style=flat-square)](https://www.nuget.org/packages//SDL-Sharp/)
 - [SDL-Sharp-DLL](https://www.nuget.org/packages//SDL-Sharp-DLL/): [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp-DLL.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp-DLL/)

### Nuget Obsolete
 - [32-bits](https://www.nuget.org/packages/SDL-Sharp_32-bits/): [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp_32-bits.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp_32-bits/)
 - [64-bits](https://www.nuget.org/packages/SDL-Sharp_64-bits/): [![NuGet version (SoftCircuits.Silk)](https://img.shields.io/nuget/v/SDL-Sharp_64-bits.svg?style=flat-square)](https://www.nuget.org/packages/SDL-Sharp_64-bits/)

```
Note1: All extensions have all functions (or should have) updated, and nuget has updated DLLs. 
However the SDL has been down in time since update (2.0.7), and has many new functions between (2.0.8) and (2.24.1).
I'm working to go adding these functions until the latest update, in case it's (2.24.1).
Note2: News are coming in this project, it has been updated again!!!!!
```

# How to setup
First install [SDL-Sharp](https://www.nuget.org/packages//SDL-Sharp/)  nuget in your .NET project

### Linux
Just install the sdl using a package manager of your system that [SDL-Sharp](https://www.nuget.org/packages//SDL-Sharp/)  will already use the sdl binaries

### Windows
Just install [SDL-Sharp-DLL](https://www.nuget.org/packages//SDL-Sharp-DLL/) nuget in yot .NET project

# Base projects for SDL-Sharp

The SDL-Sharp project was made based on other projects:

 - [SharpSDL](https://github.com/hasali19/SharpSDL)
 - [SDL2#](https://github.com/flibitijibibo/SDL2-CS)
 - [SharpFont](https://github.com/Robmaister/SharpFont)
 - [OpenTK](https://github.com/opentk/opentk)
 - [Pencil.Gaming](https://github.com/andykorth/Pencil.Gaming)
 - [Silk.NET](https://github.com/dotnet/Silk.NET)

With some modifications in both

# About this Project

 - This project aims to make SDL2 non-aggressive in c#

 - In SDL-Sharp Window, Renderer, Texture, Font and Music are pointers same as IntPtr. So the SDL.CreateWindow() function returns a Window and not a Window* (exemple)
 - However Surface, Chunk and others are not pointers, so the functions return a Surface* or PSurface (example), in these cases there are P(Structure name) such as PChunk, PSurface...
(P of pointer)
 - To be able to use pointers in C#, you have to enable Unsafe Code and use these pointers (void*) inside an unsafe { //Pointers here// }

# Exemple 1 (SDL2#)

[SDL2#](https://github.com/flibitijibibo/SDL2-CS) code would look like this:
```cs
SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

IntPtr window = SDL.SDL_CreateWindow("Window", SDL.SDL_WINDOWPOS_UNDEFINED, 
  SDL.SDL_WINDOWPOS_UNDEFINED, 800, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

IntPtr renderer = SDL.SDL_CreateRenderer(window, -1,
  SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED | 
  SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
```
                                      
# Exemple 2 (SDL-Sharp)

And on [SDL-Sharp](https://github.com/GabrielFrigo4/SDL-Sharp) like this:
```cs
SDL.Init(SdlInitFlags.Video);
Window window = SDL.CreateWindow("Window", SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, 800, 600, WindowFlags.Shown);
Renderer renderer = SDL.CreateRenderer(window, -1, RendererFlags.Accelerated | RendererFlags.PresentVsync);
```
