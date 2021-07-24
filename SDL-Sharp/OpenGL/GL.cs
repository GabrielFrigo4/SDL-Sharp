//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif
using System.Runtime.InteropServices;
using System.Text;
using SDL_Sharp.OpenGL.Mathematics;
using static SDL_Sharp.OpenGL.GLFunc;

namespace SDL_Sharp.OpenGL
{
    /// <summary>
    /// Provides access to OpenGL 4.x methods for the core profile.
    /// </summary>
    public sealed partial class GL
    {
        public static void CullFace(CullFaceMode mode)
        {
            glCullFace((int)mode);
        }

        public static void FrontFace(FrontFaceDirection mode)
        {
            glFrontFace((int)mode);
        }

        public static void Hint(HintTarget target, HintMode mode)
        {
            glHint((int)target,(int)mode);
        }

        public static void LineWidth(float width)
        {
            glLineWidth(width);
        }

        public static void PointSize(float size)
        {
            glPointSize(size);
        }

        public static void PolygonMode(MaterialFace face, PolygonMode mode)
        {
            glPolygonMode((int)face, (int)mode);
        }

        public static void Scissor(int x, int y, int width, int height)
        {
            glScissor(x, y, width, height);
        }

        public static void DrawBuffer(DrawBufferMode buffer)
        {
            glDrawBuffer((int)buffer);
        }

        public static void Clear(ClearBufferMask mask)
        {
            glClear((uint)mask);
        }

        public static void ClearColor(Color color)
        {
            glClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void ClearColor(Color4 color)
        {
            glClearColor(color.R, color.G, color.B, color.A);
        }

        public static void ClearStencil(int index)
        {
            glClearStencil(index);
        }

        public static void ClearDepth(double depth)
        {
            glClearDepth(depth);
        }

        public static void BlendColor(Color color)
        {
            glBlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void BlendColor(Color4 color)
        {
            glBlendColor(color.R, color.G, color.B, color.A);
        }

        public static void Uniform1(int location, int v0)
        {
            glUniform1i(location, v0);
        }

        public static void Uniform1(int location, float v0)
        {
            glUniform1f(location, v0);
        }

        public static void Uniform2(int location, Vector2 vector)
        {
            glUniform2f(location, vector.X, vector.Y);
        }

        public static void Uniform2(int location, float v0, float v1)
        {
            glUniform2f(location, v0, v1);
        }

        public static void Uniform3(int location, Vector3 vector)
        {
            glUniform3f(location, vector.X, vector.Y, vector.Z);
        }

        public static void Uniform3(int location, float v0, float v1, float v2)
        {
            glUniform3f(location, v0, v1, v2);
        }

        public static void Uniform4(int location, Vector4 vector)
        {
            glUniform4f(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform4(int location, float v0, float v1, float v2, float v3)
        {
            glUniform4f(location, v0, v1, v2, v3);
        }

        public static void Uniform4(int location, Color4 color)
        {
            glUniform4f(location, color.R, color.G, color.B, color.A);
        }

        public static void Uniform4(int location, Quaternion quaternion)
        {
            glUniform4f(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        public static void UniformMatrix2(int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    glUniformMatrix2fv(location, 1, transpose, matrix_ptr);
                }
            }
        }

        public static void UniformMatrix3(int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    glUniformMatrix3fv(location, 1, transpose, matrix_ptr);
                }
            }
        }

        public static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    glUniformMatrix4fv(location, 1, transpose, matrix_ptr);
                }
            }
        }

        public static int GetUniformLocation(uint program, string name)
        {
            return glGetUniformLocation(program, name);
        }

        public static int GetUniformLocation(int program, string name)
        {
            return glGetUniformLocation((uint)program, name);
        }

        public static string GetActiveAttrib(int program, int index, out int size, out ActiveAttribType type)
        {
            int length;
            unsafe
            {
                glGetProgramiv((uint)program, (int)GetProgramParameterName.ActiveUniformMaxLength, &length);
            }

            string str;
            int intType;
            glGetActiveAttrib((uint)program, (uint)index, length == 0 ? 1 : length * 2, out length, out size, out intType, out str);
            type = (ActiveAttribType)intType;
            return str;
        }

        public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            unsafe
            {
                glGetProgramiv((uint)program, (int)GetProgramParameterName.ActiveUniformMaxLength, &length);
            }

            string str;
            int intType;
            glGetActiveUniform((uint)program, (uint)uniformIndex, length == 0 ? 1 : length, out length, out size, out intType, out str);
            type = (ActiveUniformType)intType;
            return str;
        }

        public static int GetAttribLocation(int program, string attribName)
        {
            return glGetAttribLocation((uint)program, attribName);
        }

        public static int CreateProgram()
        {
            return (int)glCreateProgram();
        }

        public static void LinkProgram(int program)
        {
            glLinkProgram((uint)program);
        }

        public static void UseProgram(int program)
        {
            glUseProgram((uint)program);
        }

        public static void GetProgram(int program, GetProgramParameterName pname, out int @params)
        {
            int args;
            unsafe
            {
                glGetProgramiv((uint)program, (int)pname, &args);
            }
            @params = args;
        }

        public static void GetProgram(int program, ProgramParameter pname, out int @params)
        {
            int args;
            unsafe
            {
                glGetProgramiv((uint)program, (int)pname, &args);
            }
            @params = args;
        }

        public static void AttachShader(int program, int shader)
        {
            glAttachShader((uint)program, (uint)shader);
        }

        public static int CreateShader(ShaderType type)
        {
            return (int)glCreateShader((int)type);
        }

        public static void DeleteShader(int shader)
        {
            glDeleteShader((uint)shader);
        }

        public static void ShaderSource(Int32 shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                byte[] bydeData = Encoding.ASCII.GetBytes(@string);
                fixed(byte* ptr = bydeData)
                    glShaderSource((UInt32)shader, 1, &ptr, &length);
            }
        }

        public static void CompileShader(int shader)
        {
            glCompileShader((uint)shader);
        }

        public static void GetShader(int shader, ShaderParameter pname, out int @params)
        {
            int args;
            unsafe
            {
                glGetShaderiv((uint)shader, (int)pname, &args);
            }
            @params = args;
        }

        public static void DetachShader(int program, int shader)
        {
            glDetachShader((uint)program, (uint)shader);
        }

        public static string GetShaderInfoLog(Int32 shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        public static void GetShaderInfoLog(Int32 shader, out string info)
        {
            int length = 0, args = 0;
            unsafe
            {
                int* ptr = &args;
                glGetShaderiv((uint)shader, (int)ShaderParameter.InfoLogLength, ptr);

                int count = 0;
                while (*(ptr + count) != 0)
                {
                    count += 1;
                }

                length = count;

                if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                info = glGetShaderInfoLog((UInt32)shader, length * 2);
            }
        }

        public static string GetProgramInfoLog(Int32 program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        public static void GetProgramInfoLog(Int32 program, out string info)
        {
            int length;
            unsafe
            {
                glGetProgramiv((uint)program, (int)GetProgramParameterName.InfoLogLength, &length);
            }

            if (length == 0)
            {
                info = String.Empty;
                return;
            }
            info = glGetProgramInfoLog((UInt32)program, length * 2);
        }

        public static void VertexAttrib2(Int32 index, Vector2 v)
        {
            glVertexAttrib2f((uint)index, v.X, v.Y);
        }

        public static void VertexAttrib3(Int32 index, Vector3 v)
        {
            glVertexAttrib3f((uint)index, v.X, v.Y, v.Z);
        }

        public static void VertexAttrib4(Int32 index, Vector4 v)
        {
            glVertexAttrib4f((uint)index, v.X, v.Y, v.Z, v.W);
        }

        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            glVertexAttribPointer((uint)index, size, (int)type, normalized, stride, (IntPtr)offset);
        }

        public unsafe static void DrawElements(BeginMode mode, int count, DrawElementsType type, int offset)
        {
            glDrawElements((int)mode, count, (int)type, new IntPtr(offset).ToPointer());
        }

        public static void DrawArrays(PrimitiveType mode, int first, int count)
        {
            glDrawArrays((int)mode, first, count);
        }

        public static float GetFloat(GetPName pname)
        {
            return glGetFloat((int)pname);
        }

        public static void Viewport(Size size)
        {
            glViewport(0, 0, size.Width, size.Height);
        }

        public static void Viewport(Point location, Size size)
        {
            glViewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(Rectangle rectangle)
        {
            glViewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        public static int GenVertexArray()
        {
            return (int)glGenVertexArray();
        }

        public static int GenBuffer()
        {
            return (int)glGenBuffer();
        }

        public static void BindVertexArray(int array)
        {
            glBindVertexArray((uint)array);
        }

        public static void BindBuffer(BufferTarget target, int buffer)
        {
            glBindBuffer((int)target, (uint)buffer);
        }

        public static unsafe void BufferData(BufferTarget target, int size, void* data, BufferUsageHint usage)
        {
            glBufferData((int)target, size, data, (int)usage);
        }

        public static unsafe void BufferData(BufferTarget target, int size, IntPtr data, BufferUsageHint usage)
        {
            glBufferData((int)target, size, data, (int)usage);
        }

        public static void BufferData<T2>(BufferTarget target, int size, [In] T2[] data, BufferUsageHint usage)
        {
            GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();

            glBufferData((int)target, size, ptr, (int)usage);

            handle.Free();
        }

        public static void DeleteBuffer(int buffer)
        {
            glDeleteBuffer((uint)buffer);
        }

        public static void EnableVertexAttribArray(int index)
        {
            glEnableVertexAttribArray((uint)index);
        }

        public static void DeleteVertexArray(int array)
        {
            glDeleteVertexArray((uint)array);
        }

        public static int GenTexture()
        {
            return (int)glGenTexture();
        }

        public static void ActiveTexture(TextureUnit texture)
        {
            glActiveTexture((int)texture);
        }

        public static void BindTexture(TextureTarget target, int texture)
        {
            glBindTexture((int)target, (uint)texture);
        }

        public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int hight, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            glTexImage2D((int)target, level, (int)internalFormat, width, hight ,border, (int)format, (int)type, pixels);
        }

        public static unsafe void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int hight, int border, PixelFormat format, PixelType type, void* pixels)
        {
            glTexImage2D((int)target, level, (int)internalFormat, width, hight, border, (int)format, (int)type, pixels);
        }

        public static void TexImage2D<T2>(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int hight, int border, PixelFormat format, PixelType type, [In] T2[] pixels)
        {
            GCHandle handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();

            glTexImage2D((int)target, level, (int)internalFormat, width, hight, border, (int)format, (int)type, ptr);

            handle.Free();
        }

        public static void TexParameter(TextureTarget target, TextureParameterName pname, int param)
        {
            glTexParameteri((int)target, (int)pname, param);
        }

        public static void GenerateMipmap(GenerateMipmapTarget target)
        {
            glGenerateMipmap((int)target);
        }

        public static void PixelStore(PixelStoreParameter pname, int param)
        {
            glPixelStorei((int)pname, param);
        }

        public static void Flush()
        {
            glFlush();
        }

        public static void Enable(EnableCap cap)
        {
            glEnable((int)cap);
        }

        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
        {
            glBlendFunc((int)sfactor, (int)dfactor);
        }

        public static void DepthFunc(DepthFunction func)
        {
            glDepthFunc((int)func);
        }
    }
}
