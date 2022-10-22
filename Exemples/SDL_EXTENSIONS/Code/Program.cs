using SDL_Sharp.Ttf;
using SDL_Sharp.Image;
using SDL_Sharp.Mixer;
using SDL_Sharp.Utility;
using SDL_Sharp;
using System;

namespace SDL_PLUS_EXTENSIONS;
class Program
{
    readonly static bool CheckPressed = false;
    static Window window;
    static Renderer renderer;

    static void Main()
    {
        //test save data ;)
        {
            TestData[] data = { 
                new("data1", 0, 0), new("data2", 1, 0), new("data3", 2, 0),
                new("data4", 3, 0), new("data5", 4, 0)
            };

            Utils.SerializeObject(data, "./TestData.html", SerializeType.html);
            Utils.SerializeObject(data, "./TestData.json", SerializeType.json);
            Utils.SerializeObject(data, "./TestData.bin", SerializeType.binary);
            Utils.SerializeObject(data, "./TestData.html.prot", SerializeType.htmlProtect);
            Utils.SerializeObject(data, "./TestData.json.prot", SerializeType.jsonProtect);

            Console.WriteLine(Utils.DeSerializeObject<TestData[]>("./TestData.html", SerializeType.html)[0].Name);
            Console.WriteLine(Utils.DeSerializeObject<TestData[]>("./TestData.json", SerializeType.json)[1].Name);
            Console.WriteLine(Utils.DeSerializeObject<TestData[]>("./TestData.bin", SerializeType.binary)[2].Name);
            Console.WriteLine(Utils.DeSerializeObject<TestData[]>("./TestData.html.prot", SerializeType.htmlProtect)[3].Name);
            Console.WriteLine(Utils.DeSerializeObject<TestData[]>("./TestData.json.prot", SerializeType.jsonProtect)[4].Name);
        }
        //test save data ;)

        WinUtils.SetDpiAwareness(WinHighDpiMode.SystemAware);

        //Init SDL/Image/Mixer/Ttf
        SDL.Init(SdlInitFlags.Video | SdlInitFlags.Video);
        window = SDL.CreateWindow("SDL_EXTENSIONS", SDL.WINDOWPOS_UNDEFINED, SDL.WINDOWPOS_UNDEFINED, 800, 600, WindowFlags.Hidden);
        if (window.IsNull)
            throw new Exception("Window not create");
        renderer = SDL.CreateRenderer(window, -1, RendererFlags.Accelerated | RendererFlags.PresentVsync);
        if (renderer.IsNull)
            throw new Exception("Renderer not create");
        TTF.Init();
        MIX.Init(MixInitFlags.Mod);

        Console.WriteLine(SDL.GetBasePath());

        const int audio_buffer = 4096;
        MIX.OpenAudio(MIX.DEFAULT_FREQUENCY, MIX.DEFAULT_FORMAT, MIX.DEFAULT_CHANNELS, audio_buffer);
        MIX.AllocateChannels(MIX.CHANNELS);
        //Init SDL/Image/Mixer/Ttf

        SoundMusic soundMusic = SoundMusic.CreateSoundMusic("./Files/MUSIC.wav");
        SoundMusic.SetVolume(8);
        SoundMusic.PlayMusic(soundMusic, -1);

        SoundChunk soundChunk = SoundChunk.CreateSoundChunk("./Files/RetroGame.wav");
        soundChunk.SetVolume(32);
        soundChunk.Play(3);


        Texture fegegoso = LoadTexture("./Files/Fedegoso.jpg");
        if (fegegoso.IsNull)
            throw new Exception("Texture not create");

        SDL.ShowWindow(window);
        var running = true;
        while (running)
        {
            Input.Restart();
            while (SDL.PollEvent(out Event e) == 1)
            {
                Input.Update(e);
                switch (e.Type)
                {
                    case EventType.Quit:
                        running = false;
                        break;
                    case EventType.MouseButtonDown:
                        Console.WriteLine(e.Button.Button);
                        if (e.Button.Button == MouseButton.Left)
                        {
                            Console.WriteLine("pressed");
                        }
                        break;
                }
            }

            SDL.RenderClear(renderer);
            SDL.SetRenderDrawColor(renderer, 135, 206, 235, 255);
            Render(fegegoso);

            DrawTextExt("SDL_PLUS_EXTENSIONS", 400, 300, 64, new Color(150, 100, 200, 255), "arial.ttf", true);

            SDL.RenderPresent(renderer);

            if (CheckPressed)
            {
                Console.WriteLine($"Up is pressed: {Input.GetKeyPressed(Keycode.Up)}");
                Console.WriteLine($"Down is pressed: {Input.GetKeyPressed(Keycode.Down)}");
                Console.WriteLine($"Left is pressed: {Input.GetKeyPressed(Keycode.Left)}");
                Console.WriteLine($"Right is pressed: {Input.GetKeyPressed(Keycode.Right)}");
            }
            else
            {
                if (Input.GetKeyDown(Keycode.Space))
                {
                    Console.WriteLine("Key Down Space");
                }
            }
        }

        SDL.DestroyRenderer(renderer);
        SDL.DestroyWindow(window);
        MIX.CloseAudio();
        MIX.Quit();
        SDL.Quit();
        TTF.Quit();
    }

    public static void DrawText(string text, int x, int y, int size)
    {
        Font _font = TTF.OpenFont("C:/Windows/Fonts/arial.ttf", size);
        if (_font.IsNull)
            throw new Exception("Font not create");

        Color color;
        color.R = color.G = color.B = color.A = 0;

        TTF.RenderText_Solid(_font, text, color, out PSurface surfaceMessage);

        Texture message = SDL.CreateTextureFromSurface(renderer, surfaceMessage);
        if (message.IsNull)
            throw new Exception("Texture not create");

        int texW;
        int texH;
        SDL.QueryTexture(message, out _, out _, out texW, out texH);

        Rect dstrect = new Rect(x, y, texW, texH);

        Rect srcrect = new Rect(0, 0, texW, texH);

        SDL.RenderCopy(renderer, message, ref srcrect, ref dstrect);
        TTF.CloseFont(_font);

        SDL.FreeSurface(surfaceMessage);
        SDL.DestroyTexture(message);
    }

    public static void DrawTextExt(string text, int x, int y, int size, Color color, string font, bool center)
    {
        Font _font = TTF.OpenFont("C:/Windows/Fonts/" + font, size);
        if (_font.IsNull)
            throw new Exception("Font not create");

        TTF.RenderText_Solid(_font, text, color, out PSurface surfaceMessage);

        Texture message = SDL.CreateTextureFromSurface(renderer, surfaceMessage);
        if (message.IsNull)
            throw new Exception("Texture not create");

        int texW;
        int texH;
        SDL.QueryTexture(message, out _, out _, out texW, out texH);

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

        SDL.RenderCopy(renderer, message, ref srcrect, ref dstrect);
        TTF.CloseFont(_font);

        SDL.FreeSurface(surfaceMessage);
        SDL.DestroyTexture(message);
    }

    internal static Texture LoadTexture(string path)
    {
        Texture texture = IMG.LoadTexture(renderer, path);
        if (texture.IsNull)
            throw new Exception("Texture not create");
        return texture;
    }

    internal static void Render(Texture texture)
    {
        SDL.RenderCopy(renderer, texture, IntPtr.Zero, IntPtr.Zero);
    }
}

[Serializable]
public struct TestData
{
    public string Name { get; set; }
    public int id;
    public uint leght;

    public TestData(string name, int id, uint leght)
    {
        this.Name = name;
        this.id = id;
        this.leght = leght;
    }
}