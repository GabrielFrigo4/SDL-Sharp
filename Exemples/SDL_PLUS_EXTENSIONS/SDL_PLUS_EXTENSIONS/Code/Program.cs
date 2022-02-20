using SDL_Sharp.Ttf;
using SDL_Sharp.Image;
using SDL_Sharp.Mixer;
using SDL_Sharp;
using System;

namespace SDL_PLUS_EXTENSIONS
{
    class Program
    {
        static Window window;
        static Renderer renderer;

        static void Main(string[] args)
        {
            //Init SDL/Image/Mixer/Ttf
            SDL.Init(SdlInitFlags.Video);
            window = SDL.CreateWindow("SDL_PLUS_EXTENSIONS", SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, 800, 600, WindowFlags.Shown);
            renderer = SDL.CreateRenderer(window, -1, RendererFlags.Accelerated | RendererFlags.PresentVsync);
            IMG.Init(ImgInitFlags.Png);
            TTF.Init();

            int audio_rate = 44100, channels = 2, audio_buffer = 4096;
            ushort audio_format = (ushort)AudioFormatFlags.S16LSB;
            MIX.OpenAudio(audio_rate, audio_format, channels, audio_buffer);
            //Init SDL/Image/Mixer/Ttf

            Sound sound = Sound.CreateSound("./Files/sound.wav");
            sound.Play(1);
            sound.SetVolume(16);

            Event e;
            var running = true;
            while (running)
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

                SDL.RenderClear(renderer);
                SDL.SetRenderDrawColor(renderer, 135, 206, 235, 255);

                DrawTextExt("SDL_PLUS_EXTENSIONS", 400, 300, 64, new Color(150, 100, 200, 255), "arial.ttf", true);

                SDL.RenderPresent(renderer);
            }

            SDL.DestroyRenderer(renderer);
            SDL.DestroyWindow(window);
            SDL.Quit();
            TTF.Quit();
            IMG.Quit();
        }

        public unsafe static void DrawText(string text, int x, int y, int size)
        {
            Font _font = TTF.OpenFont("C:/Windows/Fonts/arial.ttf", size);

            Color color;
            color.R = color.G = color.B = color.A = 0;

            Surface* surfaceMessage = TTF.RenderText_Solid(_font, text, color);

            Texture Message = SDL.CreateTextureFromSurface(renderer, surfaceMessage);

            int texW;
            int texH;
            uint format;
            TextureAccess access;
            SDL.QueryTexture(Message, &format, &access, &texW, &texH);

            Rect dstrect = new Rect(x, y, texW, texH);

            Rect srcrect = new Rect(0, 0, texW, texH);

            SDL.RenderCopy(renderer, Message, &srcrect, &dstrect);
            TTF.CloseFont(_font);

            SDL.FreeSurface(surfaceMessage);
            SDL.DestroyTexture(Message);
        }

        public unsafe static void DrawTextExt(string text, int x, int y, int size, Color color, string font, bool center)
        {
            Font _font = TTF.OpenFont("C:/Windows/Fonts/" + font, size);
            Surface* surfaceMessage = TTF.RenderText_Solid(_font, text, color);

            Texture Message = SDL.CreateTextureFromSurface(renderer, surfaceMessage);

            int texW;
            int texH;
            uint format;
            TextureAccess access;
            SDL.QueryTexture(Message, &format, &access, &texW, &texH);

            Rect dstrect;

            Rect srcrect = new Rect(0, 0, texW, texH);

            if (!center)
            {
                dstrect = new Rect(x, y, texW, texH);
            }
            else
            {
                dstrect = new Rect(x - (texW / 2), y - (texH / 2), texW, texH);
            }

            SDL.RenderCopy(renderer, Message, &srcrect, &dstrect);
            TTF.CloseFont(_font);

            SDL.FreeSurface(surfaceMessage);
            SDL.DestroyTexture(Message);
        }
    }
}
