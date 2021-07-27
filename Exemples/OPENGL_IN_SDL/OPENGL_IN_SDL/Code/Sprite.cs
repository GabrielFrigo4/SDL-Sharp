using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Collections.Generic;
using SixLabors.ImageSharp;
using SDL_Sharp.OpenGL.Mathematics;
using System.IO;
using System;
using SDL_Sharp.OpenGL;

namespace OPENGL_IN_SDL
{
    public class Sprite
    {
        private int id;
        private Vector2 size;
        private Vector2 division;
        private Vector2 origin;
        private int indMax;
        private bool pixelPerfect;
        private List<int> elementBufferObject = new List<int>();
        private List<int> vertexBufferObject = new List<int>();
        private List<int> vertexArrayObject = new List<int>();
        private readonly float[] vertices =
        {
            // Position         Texture coordinates
             1.0f, -0.0f, 0.0f, 1.0f, 1.0f, // top right
             1.0f,  1.0f, 0.0f, 1.0f, 0.0f, // bottom right
            -0.0f,  1.0f, 0.0f, 0.0f, 0.0f, // bottom left
            -0.0f, -0.0f, 0.0f, 0.0f, 1.0f  // top left
        };
        private readonly uint[] indices =
        {
            0, 1, 3,
            1, 2, 3
        };

        public int ID { get { return id; } }
        public Vector2 Size { get { return size; } }
        public float Width { get { return size.X; } }
        public float Height { get { return size.Y; } }
        public float ImageWidth { get { return size.X / division.X; } }
        public float ImageHeight { get { return size.Y / division.Y; } }
        public Vector2 Division { get { return division; } }
        public float DivisionX { get { return division.X; } }
        public float DivisionY { get { return division.Y; } }
        public Vector2 Origin { get { return origin; } }
        public float OriginX { get { return origin.X; } }
        public float OriginY { get { return origin.Y; } }
        public int IndMax { get { return indMax; } }
        public bool PixelPerfect { get { return pixelPerfect; } }
        public uint[] Indices { get { return indices; } }
        public float[] Vertices { get { return vertices; } }
        public int[] Sprite_Image { get { return vertexArrayObject.ToArray(); } }

        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(string path, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(path, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = new Vector2(1, 1);
            this.indMax = 1;
            this.origin = new Vector2(0, 0);
            this.pixelPerfect = pixelPerfect;
            vertices = new float[]
            {
                // Position         Texture coordinates
                (1.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 1.0f, 1.0f, // top right
                (1.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 1.0f, 0.0f, // bottom right
                (0.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 0.0f, 0.0f, // bottom left
                (0.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 0.0f, 1.0f  // top left
            };
            VerticeData();
        }
        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(string path, Vector2 origin, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(path, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = new Vector2(1, 1);
            this.indMax = 1;
            this.origin = origin;
            this.pixelPerfect = pixelPerfect;
            for (int i = 1; i <= indMax; i++)
            {
                float Yy = (float)(i / division.X + 0.499999f);
                Yy = (float)Math.Round(Yy, 0);
                float Xx = (i - (Yy - 1) * division.X);
                Xx = (float)Math.Round(Xx, 0);

                vertices = new float[]
                {
                     // Position         Texture coordinates
                     (1.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y, // top right
                     (1.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y - 1 / division.Y, // bottom right
                     (0.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y - 1 / division.Y, // bottom left
                     (0.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y  // top left
                };
                VerticeData();
            }
        }
        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(string path, Vector2 division, int indMax, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(path, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = new Vector2(1, 1);
            this.indMax = 1;
            this.origin = new Vector2(0, 0);
            this.pixelPerfect = pixelPerfect;
            vertices = new float[]
            {
                // Position         Texture coordinates
                (1.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 1.0f, 1.0f, // top right
                (1.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 1.0f, 0.0f, // bottom right
                (0.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 0.0f, 0.0f, // bottom left
                (0.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 0.0f, 1.0f  // top left
            };
            VerticeData();
        }
        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(string path, Vector2 division, Vector2 origin, int indMax, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(path, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = division;
            this.indMax = indMax;
            this.origin = origin;
            this.pixelPerfect = pixelPerfect;
            for (int i = 1; i <= indMax; i++)
            {
                float Yy = (float)(i / division.X + 0.499999f);
                Yy = (float)Math.Round(Yy, 0);
                float Xx = (i - (Yy - 1) * division.X);
                Xx = (float)Math.Round(Xx, 0);

                vertices = new float[]
                {
                     // Position         Texture coordinates
                     (1.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y, // top right
                     (1.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y - 1 / division.Y, // bottom right
                     (0.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y - 1 / division.Y, // bottom left
                     (0.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y  // top left
                };
                VerticeData();
            }
        }
        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(Stream stream, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(stream, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = new Vector2(1, 1);
            this.indMax = 1;
            this.origin = new Vector2(0, 0);
            this.pixelPerfect = pixelPerfect;
            vertices = new float[]
            {
                // Position         Texture coordinates
                (1.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 1.0f, 1.0f, // top right
                (1.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 1.0f, 0.0f, // bottom right
                (0.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 0.0f, 0.0f, // bottom left
                (0.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 0.0f, 1.0f  // top left
            };
            VerticeData();
        }
        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(Stream stream, Vector2 origin, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(stream, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = new Vector2(1, 1);
            this.indMax = 1;
            this.origin = new Vector2(0, 0);
            this.pixelPerfect = pixelPerfect;
            for (int i = 1; i <= indMax; i++)
            {
                float Yy = (float)(i / division.X + 0.499999f);
                Yy = (float)Math.Round(Yy, 0);
                float Xx = (i - (Yy - 1) * division.X);
                Xx = (float)Math.Round(Xx, 0);

                vertices = new float[]
                {
                     // Position         Texture coordinates
                     (1.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y, // top right
                     (1.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y - 1 / division.Y, // bottom right
                     (0.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y - 1 / division.Y, // bottom left
                     (0.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y  // top left
                };
                VerticeData();
            }
        }
        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(Stream stream, Vector2 division, int indMax, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(stream, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = new Vector2(1, 1);
            this.indMax = 1;
            this.origin = new Vector2(0, 0);
            this.pixelPerfect = pixelPerfect;
            vertices = new float[]
            {
                // Position         Texture coordinates
                (1.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 1.0f, 1.0f, // top right
                (1.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 1.0f, 0.0f, // bottom right
                (0.0f - OriginX)*Width,  (-1.0f + OriginY)*Height, 0.0f, 0.0f, 0.0f, // bottom left
                (0.0f - OriginX)*Width,  (0.0f + OriginY)*Height, 0.0f, 0.0f, 1.0f  // top left
            };
            VerticeData();
        }
        /// <summary>
        /// Create a sprite
        /// </summary>
        public Sprite(Stream stream, Vector2 division, Vector2 origin, int indMax, bool pixelPerfect = true)
        {
            int id;
            Vector2 tamanho;
            CreateSprite(stream, pixelPerfect, out id, out tamanho);
            this.id = id;
            this.size = tamanho;
            this.division = division;
            this.indMax = indMax;
            this.origin = origin;
            this.pixelPerfect = pixelPerfect;
            for (int i = 1; i <= indMax; i++)
            {
                float Yy = (float)(i / division.X + 0.499999f);
                Yy = (float)Math.Round(Yy, 0);
                float Xx = (i - (Yy - 1) * division.X);
                Xx = (float)Math.Round(Xx, 0);

                vertices = new float[]
                {
                     // Position         Texture coordinates
                     (1.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y, // top right
                     (1.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X, Yy / division.Y - 1 / division.Y, // bottom right
                     (0.0f - OriginX)*Width/division.X,  (-1.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y - 1 / division.Y, // bottom left
                     (0.0f - OriginX)*Width/division.X,  (0.0f + OriginY)*Height/division.Y, 0.0f, Xx / division.X - 1 / division.X, Yy / division.Y  // top left
                };
                VerticeData();
            }
        }
        void VerticeData()
        {
            int _vertexArrayObject;
            _vertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(_vertexArrayObject);
            vertexArrayObject.Add(_vertexArrayObject);

            int _vertexBufferObject;
            _vertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(Vertices.Length * sizeof(float)), Vertices, BufferUsageHint.StaticDraw);
            vertexBufferObject.Add(_vertexBufferObject);

            int _elementBufferObject;
            _elementBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, _elementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(Indices.Length * sizeof(uint)), Indices, BufferUsageHint.StaticDraw);
            elementBufferObject.Add(_elementBufferObject);

            Shader.asset_shader.Use();

            var vertexLocation = Shader.asset_shader.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);

            var texCoordLocation = Shader.asset_shader.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoordLocation);
            GL.VertexAttribPointer(texCoordLocation, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            Shader.asset_shader.SetInt("sprite", 0);
        }

        static void CreateSprite(string path, bool pixelPerfect, out int id, out Vector2 size)
        {
            float with, heigth;

            id = GL.GenTexture();

            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2D, id);

            //Load the image
            Image<Rgba32> image = Image.Load<Rgba32>(path);
            image.Mutate(x => x.Flip(FlipMode.Vertical));

            //Convert ImageSharp's format into a byte array, so we can use it with OpenGL.
            var pixels = new List<byte>(4 * image.Width * image.Height);
            with = image.Width;
            heigth = image.Height;

            for (int y = 0; y < image.Height; y++)
            {
                var row = image.GetPixelRowSpan(y);

                for (int x = 0; x < image.Width; x++)
                {
                    pixels.Add(row[x].R);
                    pixels.Add(row[x].G);
                    pixels.Add(row[x].B);
                    pixels.Add(row[x].A);
                }
            }

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, image.Width, image.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, pixels.ToArray());

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, pixelPerfect ? (int)TextureMinFilter.Nearest : (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, pixelPerfect ? (int)TextureMinFilter.Nearest : (int)TextureMinFilter.Linear);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);

            size = new Vector2(with, heigth);
        }
        static void CreateSprite(Stream stream, bool pixelPerfect, out int id, out Vector2 size)
        {
            float with, heigth;

            id = GL.GenTexture();

            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2D, id);

            //Load the image
            Image<Rgba32> image = Image.Load<Rgba32>(stream);
            image.Mutate(x => x.Flip(FlipMode.Vertical));

            //Convert ImageSharp's format into a byte array, so we can use it with OpenGL.
            var pixels = new List<byte>(4 * image.Width * image.Height);
            with = image.Width;
            heigth = image.Height;

            for (int y = 0; y < image.Height; y++)
            {
                var row = image.GetPixelRowSpan(y);

                for (int x = 0; x < image.Width; x++)
                {
                    pixels.Add(row[x].R);
                    pixels.Add(row[x].G);
                    pixels.Add(row[x].B);
                    pixels.Add(row[x].A);
                }
            }

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, image.Width, image.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, pixels.ToArray());

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, pixelPerfect ? (int)TextureMinFilter.Nearest : (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, pixelPerfect ? (int)TextureMinFilter.Nearest : (int)TextureMinFilter.Linear);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);

            size = new Vector2(with, heigth);
        }

        /// <summary>
        /// Depose this sprite
        /// </summary>
        public void Depose()
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);
            GL.UseProgram(0);

            foreach (var _vertexBufferObject in vertexBufferObject)
                GL.DeleteBuffer(_vertexBufferObject);
            foreach (var _vertexArrayObject in vertexArrayObject)
                GL.DeleteVertexArray(_vertexArrayObject);
        }
        public void Use(TextureUnit unit)
        {
            GL.ActiveTexture(unit);
            GL.BindTexture(TextureTarget.Texture2D, id);
        }
        ~Sprite()
        {
            Depose();
        }
    }
}
