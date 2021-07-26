using System;
using System.Linq;
using System.Runtime.InteropServices;
using SDL_Sharp.OpenGL.Mathematics;
using System.Security;
using System.Text;
using draw = System.Drawing;

namespace SDL_Sharp.OpenGL
{
    /// <summary>
    ///     Returns a function pointer for the OpenGL function with the specified name. 
    /// </summary>
    /// <param name="funcName">The name of the function to lookup.</param>
    public delegate IntPtr GetProcAddressHandler(string funcName);

    /// <summary>
    ///     Provides bindings for OpenGL 3.3 Core Profile.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "IdentifierTypo")]
    [SuppressUnmanagedCodeSecurity]
    public static unsafe partial class GL
    {
        private static string PtrToStringUtf8(IntPtr ptr)
        {
            var length = 0;
            while (Marshal.ReadByte(ptr, length) != 0)
                length++;
            var buffer = new byte[length];
            Marshal.Copy(ptr, buffer, 0, length);
            return Encoding.UTF8.GetString(buffer);
        }

        private static string PtrToStringUtf8(IntPtr ptr, int length)
        {
            var buffer = new byte[length];
            Marshal.Copy(ptr, buffer, 0, length);
            return Encoding.UTF8.GetString(buffer);
        }

        /// <summary>
        ///     The unsafe NULL pointer.
        ///     <para>Analog of IntPtr.Zero.</para>
        /// </summary>
        public static readonly void* NULL = (void*)0;

        #region GlFunc
        /// <summary>
        ///     Specify whether front- or back-facing facets can be culled.
        /// </summary>
        /// <param name="mode">
        ///     Specifies whether front- or back-facing facets are candidates for culling.
        ///     <para>GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.</para>
        /// </param>
        /// <remarks>If mode is GL_FRONT_AND_BACK, no facets are drawn, but other primitives such as points and lines are drawn.</remarks>
        public static void CullFace(CullFaceMode mode) => _glCullFace((int)mode);

        /// <summary>
        ///     Define front- and back-facing polygons.
        /// </summary>
        /// <param name="mode">
        ///     Specifies the orientation of front-facing polygons.
        ///     <para>GL_CW and GL_CCW are accepted. The initial value is GL_CCW.</para>
        /// </param>
        public static void FrontFace(FrontFaceDirection mode) => _glFrontFace((int)mode);

        /// <summary>
        ///     Specify implementation-specific hints.
        /// </summary>
        /// <param name="target">
        ///     Specifies a symbolic constant indicating the behavior to be controlled.
        ///     <para>
        ///         GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, GL_TEXTURE_COMPRESSION_HINT, and
        ///         GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
        ///     </para>
        /// </param>
        /// <param name="mode">Specifies a symbolic constant indicating the desired behavior.</param>
        public static void Hint(HintTarget target, HintMode mode) => _glHint((int)target, (int)mode);

        /// <summary>
        ///     Specify the width of rasterized lines.
        /// </summary>
        /// <param name="width">Specifies the width of rasterized lines.<para>The initial value is <c>1.0f</c></para>.</param>
        public static void LineWidth(float width) => _glLineWidth(width);

        /// <summary>
        ///     Specify the diameter of rasterized points.
        /// </summary>
        /// <param name="size">Specifies the diameter of rasterized points.<para>The initial value is <c>1.0f</c>.</para></param>
        public static void PointSize(float size) => _glPointSize(size);

        /// <summary>
        ///     Select a polygon rasterization mode
        /// </summary>
        /// <param name="face">
        ///     Specifies the polygons that mode applies to. Must be GL_FRONT_AND_BACK for front- and back-facing
        ///     polygons
        /// </param>
        /// <param name="mode">
        ///     Specifies how polygons will be rasterized.
        ///     <para>Accepted values are GL_POINT, GL_LINE, and GL_FILL.</para>
        ///     The initial value is GL_FILL for both front- and back-facing polygons.
        /// </param>
        public static void PolygonMode(MaterialFace face, PolygonMode mode) => _glPolygonMode((int)face, (int)mode);

        /// <summary>
        ///     Define the scissor box.
        /// </summary>
        /// <param name="x">
        ///     Specify the lower left corner of the scissor box on the x-axis
        ///     <para>Initially <c>0</c>.</para>
        /// </param>
        /// <param name="y">
        ///     Specify the lower left corner of the scissor box on the y-axis
        ///     <para>Initially <c>0</c>.</para>
        /// </param>
        /// <param name="width">Specify the width of the scissor box.</param>
        /// <param name="height">Specify the height of the scissor box.</param>
        /// <remarks>When a GL context is first attached to a window, width and height are set to the dimensions of that window.</remarks>
        public static void Scissor(int x, int y, int width, int height) => _glScissor(x, y, width, height);

        /// <summary>
        ///     Specify clear values for the color buffers.
        /// </summary>
        /// <param name="red">The red component value, a value between <c>0.0f</c> and <c>1.0f</c>.</param>
        /// <param name="green">The green component value, a value between <c>0.0f</c> and <c>1.0f</c>.</param>
        /// <param name="blue">The blue component value, a value between <c>0.0f</c> and <c>1.0f</c>.</param>
        /// <param name="alpha">The alpha component value, a value between <c>0.0f</c> and <c>1.0f</c>.</param>
        /// <remarks>Initial values are (0, 0, 0, 0)</remarks>
        public static void ClearColor(float red, float green, float blue, float alpha) => _glClearColor(red, green, blue, alpha);

        public static void ClearColor(Color color)
        {
            ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void ClearColor(Color4 color)
        {
            ClearColor(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        ///     Clear buffers to preset values.
        ///     <para>The value to which each buffer is cleared depends on the setting of the clear value for that buffer.</para>
        /// </summary>
        /// <param name="mask">
        ///     Bitwise OR of masks that indicate the buffers to be cleared.
        ///     <para>The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT,, and GL_STENCIL_BUFFER_BIT.</para>
        /// </param>
        public static void Clear(ClearBufferMask mask) => _glClear((uint)mask);

        /// <summary>
        ///     Block until all GL execution is complete.
        ///     <para>
        ///         Does not return until the effects of all previously called GL commands are complete. Such effects include all
        ///         changes to GL state, all changes to connection state, and all changes to the frame buffer contents.
        ///     </para>
        /// </summary>
        public static void Finish() => _glFinish();

        /// <summary>
        ///     Force execution of GL commands in finite time.
        /// </summary>
        public static void Flush() => _glFlush();

        /// <summary>
        ///     Enable server-side GL capabilities.
        /// </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        public static void Enable(EnableCap cap) => _glEnable((int)cap);

        /// <summary>
        ///     Disable server-side GL capabilities.
        /// </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        public static void Disable(EnableCap cap) => _glDisable((int)cap);

        /// <summary>
        ///     Specify the clear value for the stencil buffer.
        /// </summary>
        /// <param name="index">
        ///     Specifies the index used when the stencil buffer is cleared.
        ///     <para>The initial value is 0.</para>
        /// </param>
        public static void ClearStencil(int index) => _glClearStencil(index);

        /// <summary>
        ///     Specify the clear value for the depth buffer.
        /// </summary>
        /// <param name="depth">
        ///     Specifies the depth value used when the depth buffer is cleared.
        ///     <para>he initial value is <c>1.0</c>.</para>
        /// </param>
        public static void ClearDepth(double depth) => _glClearDepth(depth);

        /// <summary>
        ///     Control the front and back writing of individual bits in the stencil planes.
        /// </summary>
        /// <param name="mask">
        ///     Specifies a bit mask to enable and disable writing of individual bits in the stencil planes.
        ///     <para>Initially, the mask is all 1's</para>
        ///     .
        /// </param>
        public static void StencilMask(uint mask) => _glStencilMask(mask);

        /// <summary>
        ///     Enable and disable writing of frame buffer color components
        /// </summary>
        /// <param name="red">Specify whether red will be written into the frame buffer.</param>
        /// <param name="green">Specify whether green will be written into the frame buffer.</param>
        /// <param name="blue">Specify whether blue will be written into the frame buffer.</param>
        /// <param name="alpha">Specify whether alpha will be written into the frame buffer.</param>
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) => _glColorMask(red, green, blue, alpha);

        /// <summary>
        ///     Enable and disable writing of frame buffer color components
        /// </summary>
        /// <param name="index">Specifies the index of the draw buffer whose color mask to set.</param>
        /// <param name="red">Specify whether red will be written into the frame buffer.</param>
        /// <param name="green">Specify whether green will be written into the frame buffer.</param>
        /// <param name="blue">Specify whether blue will be written into the frame buffer.</param>
        /// <param name="alpha">Specify whether alpha will be written into the frame buffer.</param>
        public static void ColorMask(int index, bool red, bool green, bool blue, bool alpha) => _glColorMaski((uint)index, red, green, blue, alpha);

        /// <summary>
        ///     Enable or disable writing into the depth buffer.
        /// </summary>
        /// <param name="enabled">Specifies whether the depth buffer is enabled for writing.</param>
        public static void DepthMask(bool enabled) => _glDepthMask(enabled);

        /// <summary>
        ///     Set the blend color.
        /// </summary>
        /// <param name="red">Specify the red component of the color to blend.</param>
        /// <param name="green">Specify the green component of the color to blend.</param>
        /// <param name="blue">Specify the blue component of the color to blend.</param>
        /// <param name="alpha">Specify the alpha component of the color to blend.</param>
        public static void BlendColor(float red, float green, float blue, float alpha) => _glBlendColor(red, green, blue, alpha);

        public static void BlendColor(Color color)
        {
            BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void BlendColor(Color4 color)
        {
            BlendColor(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        ///     Specify pixel arithmetic.
        /// </summary>
        /// <param name="srcFactor">
        ///     Specifies how the red, green, blue, and alpha source blending factors are computed.
        ///     <para>The initial value is GL_ONE.</para>
        /// </param>
        /// <param name="dstFactor">
        ///     Specifies how the red, green, blue, and alpha destination blending factors are computed.
        ///     <para>The initial value is GL_ZERO.</para>
        /// </param>
        public static void BlendFunc(BlendingFactor srcFactor, BlendingFactor dstFactor) => _glBlendFunc((int)srcFactor, (int)dstFactor);

        /// <summary>
        ///     Specify the equation used for both the RGB blend equation and the Alpha blend equation.
        /// </summary>
        /// <param name="mode">Specifies how source and destination colors are combined.</param>
        public static void BlendEquation(BlendEquationMode mode) => _glBlendEquation((int)mode);

        /// <summary>
        ///     Set the viewport.
        /// </summary>
        /// <param name="x">The lower left corner of the viewport rectangle on the x-axis, in pixels.</param>
        /// <param name="y">The lower left corner of the viewport rectangle on the y-axis, in pixels.</param>
        /// <param name="width">The width of the viewport, in pixels.</param>
        /// <param name="height">The height of the viewport.</param>
        public static void Viewport(int x, int y, int width, int height) => _glViewport(x, y, width, height);

        public static void Viewport(draw.Size size)
        {
            Viewport(0, 0, size.Width, size.Height);
        }

        public static void Viewport(draw.Point location, draw.Size size)
        {
            Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(draw.Rectangle rectangle)
        {
            Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        /// <summary>
        ///     Test whether a capability is enabled.
        /// </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <returns><c>true</c> if capability is enabled, otherwise <c>false</c>.</returns>
        public static bool IsEnabled(EnableCap cap) => _glIsEnabled((int)cap);

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="first">Specifies the starting index in the enabled arrays.</param>
        /// <param name="count">Specifies the number of indices to be rendered.</param>
        public static void DrawArrays(PrimitiveType mode, int first, int count) => _glDrawArrays((int)mode, first, count);

        /// <summary>
        ///     Specify which color buffers are to be drawn into.
        /// </summary>
        /// <param name="buffer">Specifies the color buffer to be drawn into.</param>
        public static void DrawBuffer(DrawBufferMode buffer) => _glDrawBuffer((int)buffer);

        /// <summary>
        ///     Select a color buffer source for pixels.
        /// </summary>
        /// <param name="buffer">Specifies a color buffer.</param>
        public static void ReadBuffer(ReadBufferMode buffer) => _glReadBuffer((int)buffer);

        /// <summary>
        ///     Specify a logical pixel operation for rendering.
        /// </summary>
        /// <param name="opcode"></param>
        public static void LogicOp(LogicOp opcode) => _glLogicOp((int)opcode);

        /// <summary>
        ///     Set front and back function and reference value for stencil testing.
        /// </summary>
        /// <param name="func">Specifies the test function.</param>
        /// <param name="reference">Specifies the reference value for the stencil test.</param>
        /// <param name="mask">
        ///     Specifies a mask that is ANDed with both the reference value and the stored stencil value when the
        ///     test is done.
        ///     <para>The initial value is all 1's.</para>
        /// </param>
        public static void StencilFunc(StencilFunction func, int reference, int mask) => _glStencilFunc((int)func, reference, (uint)mask);

        /// <summary>
        ///     Set front and back stencil test actions.
        /// </summary>
        /// <param name="fail">Specifies the action to take when the stencil test fail.</param>
        /// <param name="zfail">Specifies the stencil action when the stencil test passes, but the depth test fails.</param>
        /// <param name="zpass">
        ///     Specifies the stencil action when both the stencil test and the depth test pass, or when the
        ///     stencil test passes and either there is no depth buffer or depth testing is not enabled
        /// </param>
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => _glStencilOp((int)fail, (int)zfail, (int)zpass);

        /// <summary>
        ///     Specify the value used for depth buffer comparisons.
        /// </summary>
        /// <param name="func">Specifies the depth comparison function.</param>
        public static void DepthFunc(DepthFunction func) => _glDepthFunc((int)func);

        /// <summary>
        ///     Start conditional rendering.
        /// </summary>
        /// <param name="id">
        ///     Specifies the name of an occlusion query object whose results are used to determine if the rendering
        ///     commands are discarded.
        /// </param>
        /// <param name="mode">Specifies how the results of the occlusion query is interpreted.</param>
        public static void BeginConditionalRender(int id, ConditionalRenderType mode) => _glBeginConditionalRender((uint)id, (int)mode);

        /// <summary>
        ///     Ends conditional rendering.
        /// </summary>
        public static void EndConditionalRender() => _glEndConditionalRender();

        /// <summary>
        ///     Specify whether data read via ReadPixels should be clamped.
        /// </summary>
        /// <param name="clamp">Specifies whether to apply color clamping.</param>
        public static void ClampColor(ClampColorTarget target, ClampColorMode mode) => _glClampColor((int)target, (int)mode);

        /// <summary>
        ///     Return a string describing the current GL connection.
        /// </summary>
        /// <param name="name">
        ///     Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or
        ///     GL_SHADING_LANGUAGE_VERSION
        /// </param>
        /// <returns>The requested value.</returns>


        public static string GetString(StringName name)
        {
            var buffer = new IntPtr(_glGetString((int)name));
            return PtrToStringUtf8(buffer);
        }

        /// <summary>
        ///     Return a string describing the current GL connection.
        /// </summary>
        /// <param name="name">
        ///     Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, GL_SHADING_LANGUAGE_VERSION, or GL_EXTENSIONS.
        /// </param>
        /// <param name="index">The index of the string to return.</param>
        /// <returns>The requested value.</returns>


        public static string GetString(StringNameIndexed name, int index)
        {
            var buffer = new IntPtr(_glGetStringi((int)name, (uint)index));
            return PtrToStringUtf8(buffer);
        }

        /// <summary>
        ///     Set pixel storage modes.
        /// </summary>
        /// <param name="paramName">
        ///     Specifies the symbolic name of the parameter to be set. One value affects the packing of pixel data
        ///     into memory: GL_PACK_ALIGNMENT. The other affects the unpacking of pixel data from memory: GL_UNPACK_ALIGNMENT.
        /// </param>
        /// <param name="param">Specifies the value that <paramref name="paramName" /> is set to. Valid values are 1, 2, 4, or 8.</param>
        public static void PixelStore(PixelStoreParameter paramName, int param) => _glPixelStorei((int)paramName, param);

        /// <summary>
        ///     Set pixel storage modes.
        /// </summary>
        /// <param name="paramName">Specifies the symbolic name of the parameter to be set.</param>
        /// <param name="param">Specifies the value that <paramref name="paramName" /> is set to.</param>
        public static void PixelStore(PixelStoreParameter paramName, float param) => _glPixelStoref((int)paramName, param);

        /// <summary>
        ///     Creates and initializes a buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="size">Specifies the size in bytes of the buffer object's new data store.</param>
        /// <param name="data">
        ///     Specifies a pointer to data that will be copied into the data store for initialization, or NULL if
        ///     no data is to be copied.
        /// </param>
        /// <param name="usage">
        ///     Specifies the expected usage pattern of the data store.
        ///     <para>
        ///         Must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY,
        ///         GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        ///     </para>
        ///     .
        /// </param>
        public static void BufferData(BufferTarget target, int size, IntPtr data, BufferUsageHint usage) => _glBufferData((int)target, new IntPtr(size), data.ToPointer(), (int)usage);

        /// <summary>
        ///     Creates and initializes a buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="size">Specifies the size in bytes of the buffer object's new data store.</param>
        /// <param name="data">
        ///     Specifies a pointer to data that will be copied into the data store for initialization, or NULL if
        ///     no data is to be copied.
        /// </param>
        /// <param name="usage">
        ///     Specifies the expected usage pattern of the data store.
        ///     <para>
        ///         Must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY,
        ///         GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        ///     </para>
        ///     .
        /// </param>
        public static void BufferData(BufferTarget target, int size, /*const*/ void* data, BufferUsageHint usage) => _glBufferData((int)target, new IntPtr(size), data, (int)usage);

        public static void BufferData<T2>(BufferTarget target, int size, [In] T2[] data, BufferUsageHint usage)
        {
            GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();

            BufferData(target, size, ptr, usage);

            handle.Free();
        }

        /// <summary>
        ///     Gets the stored error code information.
        /// </summary>
        /// <returns>An OpenGL error code.</returns>
        public static int GetError() => _glGetError();

        /// <summary>
        ///     Set texture parameters.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target texture of the active texture unit, which must be either GL_TEXTURE_2D or
        ///     GL_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="paramName">
        ///     Specifies the symbolic name of a single-valued texture parameter. <paramref name="paramName" /> can be
        ///     one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, or GL_TEXTURE_WRAP_T.
        /// </param>
        /// <param name="param">Specifies the value of <paramref name="paramName" />.</param>
        public static void TexParameter(TextureTarget target, TextureParameterName paramName, float param) => _glTexParameterf((int)target, (int)paramName, param);

        /// <summary>
        ///     Set texture parameters.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target texture of the active texture unit, which must be either GL_TEXTURE_2D or
        ///     GL_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="paramName">
        ///     Specifies the symbolic name of a single-valued texture parameter. <paramref name="paramName" /> can be
        ///     one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, or GL_TEXTURE_WRAP_T.
        /// </param>
        /// <param name="param">Specifies the value of <paramref name="paramName" />.</param>
        public static void TexParameter(TextureTarget target, TextureParameterName paramName, int param) => _glTexParameteri((int)target, (int)paramName, param);

        /// <summary>
        ///     Set texture parameters.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target texture of the active texture unit, which must be either GL_TEXTURE_2D or
        ///     GL_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="paramName">
        ///     Specifies the symbolic name of a single-valued texture parameter. <paramref name="paramName" /> can be
        ///     one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, or GL_TEXTURE_WRAP_T.
        /// </param>
        /// <param name="param">Specifies the value of <paramref name="paramName" />.</param>
        public static void TexParameter(TextureTarget target, TextureParameterName paramName, float* param) => _glTexParameterfv((int)target, (int)paramName, param);

        /// <summary>
        ///     Set texture parameters.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target texture of the active texture unit, which must be either GL_TEXTURE_2D or
        ///     GL_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="paramName">
        ///     Specifies the symbolic name of a single-valued texture parameter. <paramref name="paramName" /> can be
        ///     one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, or GL_TEXTURE_WRAP_T.
        /// </param>
        /// <param name="param">Specifies the value of <paramref name="paramName" />.</param>
        public static void TexParameter(TextureTarget target, TextureParameterName paramName, int* param) => _glTexParameteriv((int)target, (int)paramName, param);

        /// <summary>
        ///     Set texture parameters.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target texture of the active texture unit, which must be either GL_TEXTURE_2D or
        ///     GL_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="paramName">
        ///     Specifies the symbolic name of a single-valued texture parameter. <paramref name="paramName" /> can be
        ///     one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, or GL_TEXTURE_WRAP_T.
        /// </param>
        /// <param name="param">Specifies the value of <paramref name="paramName" />.</param>
        public static void TexParameter(TextureTarget target, TextureParameterName paramName, float[] param)
        {
            fixed (float* p = &param[0])
            {
                _glTexParameterfv((int)target, (int)paramName, p);
            }
        }

        /// <summary>
        ///     Set texture parameters.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target texture of the active texture unit, which must be either GL_TEXTURE_2D or
        ///     GL_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="paramName">
        ///     Specifies the symbolic name of a single-valued texture parameter. <paramref name="paramName" /> can be
        ///     one of the following: GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_WRAP_S, or GL_TEXTURE_WRAP_T.
        /// </param>
        /// <param name="param">Specifies the value of <paramref name="paramName" />.</param>
        public static void TexParameter(TextureTarget target, TextureParameterName paramName, int[] param)
        {
            fixed (int* p = &param[0])
            {
                _glTexParameteriv((int)target, (int)paramName, p);
            }
        }

        /// <summary>
        ///     Specify mapping of depth values from normalized device coordinates to window coordinates.
        /// </summary>
        /// <param name="near">
        ///     Specifies the mapping of the near clipping plane to window coordinates.
        ///     <c>The initial value is 0.</c>
        /// </param>
        /// <param name="far">
        ///     Specifies the mapping of the far clipping plane to window coordinates.<c>The initial value is 1.</c>
        /// </param>
        public static void DepthRange(double near, double far) => _glDepthRange(near, far);

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">
        ///     Specifies the type of the values in indices.
        ///     <para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para>
        /// </param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, /*const*/ int offset) => _glDrawElements((int)mode, count, (int)type, new IntPtr(offset).ToPointer());

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="indices">An array containing the indices.</param>
        public static void DrawElements(PrimitiveType mode, byte[] indices)
        {
            fixed (void* pointer = &indices[0])
            {
                _glDrawElements((int)mode, indices.Length, (int)DrawElementsType.UnsignedByte, pointer);
            }
        }

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="indices">An array containing the indices.</param>
        public static void DrawElements(PrimitiveType mode, ushort[] indices)
        {
            fixed (void* pointer = &indices[0])
            {
                _glDrawElements((int)mode, indices.Length, (int)DrawElementsType.UnsignedShort, pointer);
            }
        }

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="indices">An array containing the indices.</param>
        public static void DrawElements(PrimitiveType mode, uint[] indices)
        {
            fixed (void* pointer = &indices[0])
            {
                _glDrawElements((int)mode, indices.Length, (int)DrawElementsType.UnsignedInt, pointer);
            }
        }

        public static void DrawElements(BeginMode mode, int count, DrawElementsType type, /*const*/ int offset) => _glDrawElements((int)mode, count, (int)type, new IntPtr(offset).ToPointer());

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="indices">An array containing the indices.</param>
        public static void DrawElements(BeginMode mode, byte[] indices)
        {
            fixed (void* pointer = &indices[0])
            {
                _glDrawElements((int)mode, indices.Length, (int)DrawElementsType.UnsignedByte, pointer);
            }
        }

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="indices">An array containing the indices.</param>
        public static void DrawElements(BeginMode mode, ushort[] indices)
        {
            fixed (void* pointer = &indices[0])
            {
                _glDrawElements((int)mode, indices.Length, (int)DrawElementsType.UnsignedShort, pointer);
            }
        }

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="indices">An array containing the indices.</param>
        public static void DrawElements(BeginMode mode, uint[] indices)
        {
            fixed (void* pointer = &indices[0])
            {
                _glDrawElements((int)mode, indices.Length, (int)DrawElementsType.UnsignedInt, pointer);
            }
        }

        /// <summary>
        ///     Return a texture image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="format">Specifies a pixel format for the returned data. </param>
        /// <param name="type">Specifies a pixel type for the returned data.</param>
        /// <param name="pixels">Returns the texture image. Should be a pointer to an array of the type specified by type.</param>
        public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, void* pixels) => _glGetTexImage((int)target, level, (int)format, (int)type, pixels);

        /// <summary>
        ///     Return a texture image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="format">Specifies a pixel format for the returned data. </param>
        /// <param name="type">Specifies a pixel type for the returned data.</param>
        /// <param name="pixels">Returns the texture image. Should be a pointer to an array of the type specified by type.</param>
        public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr pixels) => _glGetTexImage((int)target, level, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Read a block of pixels from the frame buffer.
        /// </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the frame buffer on the x-axis.<para>This location is the lower left corner of a rectangular block of pixels.</para></param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the frame buffer on the y-axis.<para>This location is the lower left corner of a rectangular block of pixels.</para></param>
        /// <param name="width">Specify the width of the pixel rectangle, in pixels.</param>
        /// <param name="height">Specify the height of the pixel rectangle, in pixels.</param>
        /// <param name="format">Specifies the format of the pixel data.<para>The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.</para></param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">A pointer where the pixel data will be written.<para>Must have enough memory allocated for the desired dimensions and pixel format.</para></param>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => _glReadPixels(x, y, width, height, (int)format, (int)type, pixels);

        /// <summary>
        ///     Read a block of pixels from the frame buffer.
        /// </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the frame buffer on the x-axis.<para>This location is the lower left corner of a rectangular block of pixels.</para></param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the frame buffer on the y-axis.<para>This location is the lower left corner of a rectangular block of pixels.</para></param>
        /// <param name="width">Specify the width of the pixel rectangle, in pixels.</param>
        /// <param name="height">Specify the height of the pixel rectangle, in pixels.</param>
        /// <param name="format">Specifies the format of the pixel data.</param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">A pointer where the pixel data will be written.<para>Must have enough memory allocated for the desired dimensions and pixel format.</para></param>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels) => _glReadPixels(x, y, width, height, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Read a block of pixels from the frame buffer.
        /// </summary>
        /// <param name="x">Specify the window coordinates of the first pixel that is read from the frame buffer on the x-axis.<para>This location is the lower left corner of a rectangular block of pixels.</para></param>
        /// <param name="y">Specify the window coordinates of the first pixel that is read from the frame buffer on the y-axis.<para>This location is the lower left corner of a rectangular block of pixels.</para></param>
        /// <param name="width">Specify the width of the pixel rectangle, in pixels.</param>
        /// <param name="height">Specify the height of the pixel rectangle, in pixels.</param>
        /// <param name="format">Specifies the format of the pixel data.</param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">A buffer where the pixel data will be written.<para>Must have enough memory allocated for the desired dimensions and pixel format.</para></param>
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, byte[] pixels)
        {
            var handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            var ptr = handle.AddrOfPinnedObject();
            _glReadPixels(x, y, width, height, (int)format, (int)type, ptr.ToPointer());
            handle.Free();
        }

        /// <summary>
        ///     Specifies a list of color buffers to be drawn into.
        /// </summary>
        /// <param name="n">Specifies the number of buffers.</param>
        /// <param name="buffers">Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        public static void DrawBuffers(int n, /*const*/ DrawBuffersEnum* buffers) => _glDrawBuffers(n, (int*)buffers);

        /// <summary>
        ///     Specifies a list of color buffers to be drawn into.
        /// </summary>
        /// <param name="buffers">PAn array of symbolic constants specifying the buffers into which fragment colors or data values will be written.</param>
        public static void DrawBuffers(DrawBuffersEnum[] buffers)
        {
            fixed (DrawBuffersEnum* buf = &buffers[0])
            {
                _glDrawBuffers(buffers.Length, (int*)buf);
            }
        }

        /// <summary>
        ///     Specify a one-dimensional texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap
        ///     reduction image.
        /// </param>
        /// <param name="internalFormat">Specifies the number of color components in the texture. </param>
        /// <param name="width">
        ///     Specifies the width of the texture image.
        ///     <para>All implementations support texture images that are at least 1024 texels wide.</para>
        /// </param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="format">
        ///     Specifies the format of the pixel data.
        /// </param>
        /// <param name="type">
        ///     Specifies the data type of the pixel data.
        /// </param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexImage1D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int border, PixelFormat format, PixelType type, /*const*/ IntPtr pixels) => _glTexImage1D((int)target, level, (int)internalFormat, width, border, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Specify a one-dimensional texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap
        ///     reduction image.
        /// </param>
        /// <param name="internalFormat">Specifies the number of color components in the texture. </param>
        /// <param name="width">
        ///     Specifies the width of the texture image.
        ///     <para>All implementations support texture images that are at least 1024 texels wide.</para>
        /// </param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="format">
        ///     Specifies the format of the pixel data.
        /// </param>
        /// <param name="type">
        ///     Specifies the data type of the pixel data.
        /// </param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexImage1D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int border, PixelFormat format, PixelType type, /*const*/ void* pixels) => _glTexImage1D((int)target, level, (int)internalFormat, width, border, (int)format, (int)type, pixels);

        public static void TexImage1D<T7>(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int border, PixelFormat format, PixelType type, [In] T7[] pixels)
        {
            GCHandle handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();

            TexImage1D(target, level, internalFormat, width, border, format, type, ptr);

            handle.Free();
        }

        /// <summary>
        ///     Specify a two-dimensional texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap
        ///     reduction image.
        /// </param>
        /// <param name="internalFormat">Specifies the number of color components in the texture. </param>
        /// <param name="width">
        ///     Specifies the width of the texture image.
        ///     <para>All implementations support texture images that are at least 1024 texels wide.</para>
        /// </param>
        /// <param name="height">
        ///     Specifies the height of the texture image, or the number of layers in a texture array.
        ///     <para>
        ///         All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are
        ///         at least 256 layers deep.
        ///     </para>
        /// </param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="format">
        ///     Specifies the format of the pixel data.
        /// </param>
        /// <param name="type">
        ///     Specifies the data type of the pixel data.
        /// </param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels) => _glTexImage2D((int)target, level, (int)internalFormat, width, height, border, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Specify a two-dimensional texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap
        ///     reduction image.
        /// </param>
        /// <param name="internalFormat">Specifies the number of color components in the texture. </param>
        /// <param name="width">
        ///     Specifies the width of the texture image.
        ///     <para>All implementations support texture images that are at least 1024 texels wide.</para>
        /// </param>
        /// <param name="height">
        ///     Specifies the height of the texture image, or the number of layers in a texture array.
        ///     <para>
        ///         All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are
        ///         at least 256 layers deep.
        ///     </para>
        /// </param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="format">
        ///     Specifies the format of the pixel data.
        /// </param>
        /// <param name="type">
        ///     Specifies the data type of the pixel data.
        /// </param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => _glTexImage2D((int)target, level, (int)internalFormat, width, height, border, (int)format, (int)type, pixels);

        public static void TexImage2D<T8>(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int hight, int border, PixelFormat format, PixelType type, [In] T8[] pixels)
        {
            GCHandle handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();

            TexImage2D(target, level, internalFormat, width, hight, border, format, type, ptr);

            handle.Free();
        }

        /// <summary>
        ///     Specify a three-dimensional texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap
        ///     reduction image.
        /// </param>
        /// <param name="internalFormat">Specifies the number of color components in the texture. </param>
        /// <param name="width">
        ///     Specifies the width of the texture image.
        ///     <para>All implementations support texture images that are at least 1024 texels wide.</para>
        /// </param>
        /// <param name="height">
        ///     Specifies the height of the texture image, or the number of layers in a texture array.
        ///     <para>
        ///         All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are
        ///         at least 256 layers deep.
        ///     </para>
        /// </param>
        /// <param name="depth">Specifies the depth of the texture image, or the number of layers in a texture array.<para>All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="format">
        ///     Specifies the format of the pixel data.
        /// </param>
        /// <param name="type">
        ///     Specifies the data type of the pixel data.
        /// </param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexImage3D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels) => _glTexImage3D((int)target, level, (int)internalFormat, width, height, depth, border, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Specify a three-dimensional texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap
        ///     reduction image.
        /// </param>
        /// <param name="internalFormat">Specifies the number of color components in the texture. </param>
        /// <param name="width">
        ///     Specifies the width of the texture image.
        ///     <para>All implementations support texture images that are at least 1024 texels wide.</para>
        /// </param>
        /// <param name="height">
        ///     Specifies the height of the texture image, or the number of layers in a texture array.
        ///     <para>
        ///         All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are
        ///         at least 256 layers deep.
        ///     </para>
        /// </param>
        /// <param name="depth">Specifies the depth of the texture image, or the number of layers in a texture array.<para>All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="format">
        ///     Specifies the format of the pixel data.
        /// </param>
        /// <param name="type">
        ///     Specifies the data type of the pixel data.
        /// </param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexImage3D(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int height, int depth, int border, PixelFormat format, PixelType type, void* pixels) => _glTexImage3D((int)target, level, (int)internalFormat, width, height, depth, border, (int)format, (int)type, pixels);

        public static void TexImage3D<T9>(TextureTarget target, int level, PixelInternalFormat internalFormat, int width, int hight, int depth, int border, PixelFormat format, PixelType type, [In] T9[] pixels)
        {
            GCHandle handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();

            TexImage3D(target, level, internalFormat, width, hight, depth, border, format, type, ptr);

            handle.Free();
        }

        /// <summary>
        ///     Bind a named texture to a texturing target.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="texture">Specifies the name of a texture.</param>
        public static void BindTexture(TextureTarget target, int texture) => _glBindTexture((int)target, (uint)texture);

        /// <summary>
        ///     Select active texture unit.
        /// </summary>
        /// <param name="texture">Specifies which texture unit to make active.</param>
        public static void ActiveTexture(TextureUnit texture) => _glActiveTexture((int)texture);

        /// <summary>
        ///     Delete named textures.
        /// </summary>
        /// <param name="n">Specifies the number of textures to be deleted.</param>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        public static void DeleteTextures(int n, /*const*/ int* textures) => _glDeleteTextures(n, (uint*)textures);

        /// <summary>
        ///     Delete named textures.
        /// </summary>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        public static void DeleteTextures(int[] textures)
        {
            if (textures is null)
                return;
            fixed (int* ids = &textures[0])
            {
                _glDeleteTextures(textures.Length, (uint*)ids);
            }
        }

        /// <summary>
        ///     Deletes a single texture object.
        /// </summary>
        /// <param name="texture">A texture to delete.</param>
        public static void DeleteTexture(int texture) => _glDeleteTextures(1, (uint*)&texture);

        /// <summary>
        ///     Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">Specifies a value that may be the name of a texture.</param>
        /// <returns><c>true</c> if object is a texture, otherwise false.</returns>
        public static bool IsTexture(int texture) => _glIsTexture((uint)texture);

        /// <summary>
        ///     Generate texture names.
        /// </summary>
        /// <param name="n">Specifies the number of texture names to be generated.</param>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        public static void GenTextures(int n, int* textures) => _glGenTextures(n, (uint*)textures);

        /// <summary>
        ///     Generate texture names.
        /// </summary>
        /// <param name="n">Specifies the number of texture names to be generated.</param>
        /// <returns>Generated texture names.</returns>


        public static int[] GenTextures(int n)
        {
            var textures = new int[n];
            fixed (int* ids = &textures[0])
            {
                _glGenTextures(n, (uint*)ids);
            }

            return textures;
        }

        /// <summary>
        ///     Generates a single texture name.
        /// </summary>
        /// <returns>The generated texture name.</returns>
        public static int GenTexture()
        {
            int texture;
            _glGenTextures(1, (uint*)&texture);
            return texture;
        }


        /// <summary>
        ///     Generate a single query object name.
        /// </summary>
        /// <returns>The query object name.</returns>

        public static int GenQuery()
        {
            int id;
            _glGenQueries(1, (uint*)&id);
            return id;
        }

        /// <summary>
        ///     Generate query object names.
        /// </summary>
        /// <param name="n">Specifies the number of query object names to be generated.</param>
        /// <param name="ids">Specifies an array in which the generated query object names are stored.</param>
        public static void GenQueries(int n, int* ids) => _glGenQueries(n, (uint*)ids);

        /// <summary>
        ///     Generate query object names.
        /// </summary>
        /// <param name="n">Specifies the number of query object names to be generated.</param>
        /// <returns>An array of generated query object names.</returns>


        public static int[] GenQueries(int n)
        {
            var queries = new int[n];
            fixed (int* ids = &queries[0])
            {
                _glGenQueries(n, (uint*)ids);
            }

            return queries;
        }

        /// <summary>
        ///     Set the scale and units used to calculate depth values.
        /// </summary>
        /// <param name="factor">
        ///     Specifies a scale factor that is used to create a variable depth offset for each polygon.
        ///     <para>The initial value is 0.</para>
        /// </param>
        /// <param name="units">
        ///     Is multiplied by an implementation-specific value to create a constant depth offset.
        ///     <para>The initial value is 0.</para>
        /// </param>
        public static void PolygonOffset(float factor, float units) => _glPolygonOffset(factor, units);

        /// <summary>
        /// Specify the vertex to be used as the source of data for flat shaded varyings.
        /// </summary>
        /// <param name="mode">Specifies the vertex to be used as the source of data for flat shaded varyings.</param>
        public static void ProvokingVertex(ProvokingVertexMode mode) => _glProvokingVertex((int)mode);

        /// <summary>
        ///     Returns a compressed texture image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the n-th mipmap reduction image.</para>
        /// </param>
        /// <param name="pixels">
        ///     A pointer where the pixel data will be written.
        ///     <para>Enough memory must be allocated at this location for the data to written.</para>
        /// </param>
        public static void GetCompressedTexImage(TextureTarget target, int level, IntPtr pixels) => _glGetCompressedTexImage((int)target, level, pixels.ToPointer());

        /// <summary>
        ///     Returns a compressed texture image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the n-th mipmap reduction image.</para>
        /// </param>
        /// <param name="pixels">
        ///     A pointer where the pixel data will be written.
        ///     <para>Enough memory must be allocated at this location for the data to written.</para>
        /// </param>
        public static void GetCompressedTexImage(TextureTarget target, int level, void* pixels) => _glGetCompressedTexImage((int)target, level, pixels);

        public static void GetCompressedTexImage<T2>(TextureTarget target, int level, [In] T2[] pixels)
        {
            GCHandle handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            IntPtr ptr = handle.AddrOfPinnedObject();

            GetCompressedTexImage(target, level, ptr);

            handle.Free();
        }

        /// <summary>
        ///     Specify multisample coverage parameters.
        /// </summary>
        /// <param name="value">
        ///     Specify a single floating-point sample coverage value.
        ///     <para>The value is clamped to the range 0 and 1. The initial value is 1.0.</para>
        /// </param>
        /// <param name="invert">
        ///     Specify a single boolean value representing if the coverage masks should be inverted.
        ///     <para>The initial value is <c>false</c>.</para>
        /// </param>
        public static void SampleCoverage(float value, bool invert) => _glSampleCoverage(value, invert);

        /// <summary>
        ///     Delimit the boundaries of a query object.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target type of query object established between <see cref="glBeginQuery" /> and the subsequent
        ///     <see cref="glEndQuery" />.
        ///     <para>
        ///         Must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE,
        ///         GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
        ///     </para>
        /// </param>
        /// <param name="id">Specifies the name of a query object.</param>
        public static void BeginQuery(QueryTarget target, uint id) => _glBeginQuery((int)target, id);

        /// <summary>
        ///     Delimit the boundaries of a query object.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target type of query object to be concluded.
        ///     <para>
        ///         Must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE,
        ///         GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
        ///     </para>
        /// </param>
        public static void EndQuery(QueryTarget target) => _glEndQuery((int)target);

        /// <summary>
        ///     Determine if a name corresponds to a query object.
        /// </summary>
        /// <param name="id">Specifies a value that may be the name of a query object.</param>
        /// <returns><c>true</c> if object is a query object object, otherwise <c>false</c>.</returns>
        public static bool IsQuery(int id) => _glIsQuery((uint)id);

        /// <summary>
        ///     Delete named query objects.
        /// </summary>
        /// <param name="n">Specifies the number of query objects to be deleted.</param>
        /// <param name="ids">Specifies an array of query objects to be deleted.</param>
        public static void DeleteQueries(int n, /*const*/ int* ids) => _glDeleteQueries(n, (uint*)ids);

        /// <summary>
        ///     Delete named query objects.
        /// </summary>
        /// <param name="ids">An array of query objects to be deleted.</param>
        public static void DeleteQueries(int[] ids)
        {
            fixed (int* names = &ids[0])
            {
                _glDeleteQueries(ids.Length, (uint*)names);
            }
        }

        /// <summary>
        ///     Deletes a single query object.
        /// </summary>
        /// <param name="id">The query to delete.</param>
        public static void DeleteQuery(int id) => _glDeleteQueries(1, (uint*)&id);

        /// <summary>
        ///     Set the RGB blend equation and the alpha blend equation separately.
        /// </summary>
        /// <param name="modeRGB">
        ///     Specifies the RGB blend equation, how the red, green, and blue components of the source and
        ///     destination colors are combined.
        ///     <para>Must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.</para>
        /// </param>
        /// <param name="modeAlpha">
        ///     Specifies the alpha blend equation, how the alpha component of the source and destination
        ///     colors are combined.
        ///     <para>Must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.</para>
        /// </param>
        public static void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha) => _glBlendEquationSeparate((int)modeRGB, (int)modeAlpha);

        /// <summary>
        ///     Set front and/or back function and reference value for stencil testing
        /// </summary>
        /// <param name="face">
        ///     Specifies whether front and/or back stencil state is updated.
        ///     <para>Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK.</para>
        /// </param>
        /// <param name="func">
        ///     Specifies the test function.
        ///     <para>
        ///         Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL,
        ///         GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS
        ///     </para>
        ///     .
        /// </param>
        /// <param name="reference">
        ///     Specifies the reference value for the stencil test.
        ///     <para>
        ///         Clamped to the range [0, 2n - 1], where n is the number of bitplanes in the stencil buffer. The initial value
        ///         is 0.
        ///     </para>
        /// </param>
        /// <param name="mask">
        ///     Specifies a mask that is ANDed with both the reference value and the stored stencil value when the
        ///     test is done.
        ///     <para>The initial value is all 1's.</para>
        /// </param>
        public static void StencilFuncSeparate(StencilFace face, StencilFunction func, int reference, int mask) => _glStencilFuncSeparate((int)face, (int)func, reference, (uint)mask);

        /// <summary>
        ///     Set front and/or back stencil test actions.
        /// </summary>
        /// <param name="face">
        ///     Specifies whether front and/or back stencil state is updated.
        ///     <para>Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK.</para>
        /// </param>
        /// <param name="sfail">
        ///     Specifies the action to take when the stencil test fails.
        ///     <para>
        ///         Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR,
        ///         GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP.
        ///     </para>
        /// </param>
        /// <param name="dpfail">
        ///     Specifies the stencil action when the stencil test passes, but the depth test fails.
        ///     <paramref name="dpfail" /> accepts the same symbolic constants as <paramref name="sfail" />.
        ///     <para>The initial value is GL_KEEP.</para>
        /// </param>
        /// <param name="dppass">
        ///     Specifies the stencil action when both the stencil test and the depth test pass, or when the
        ///     stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass​ accepts the same
        ///     symbolic constants as <paramref name="sfail"/>​.
        ///     <para>The initial value is GL_KEEP.</para>
        /// </param>
        public static void StencilOpSeparate(StencilFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) => _glStencilOpSeparate((int)face, (int)sfail, (int)dpfail, (int)dppass);

        /// <summary>
        ///     Control the front and/or back writing of individual bits in the stencil planes.
        /// </summary>
        /// <param name="face">
        ///     Specifies whether the front and/or back stencil writemask is updated.
        ///     <para>Three symbolic constants are valid: GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK.</para>
        /// </param>
        /// <param name="mask">
        ///     Specifies a bit mask to enable and disable writing of individual bits in the stencil planes.
        ///     Initially, the mask is all 1's.
        /// </param>
        public static void StencilMaskSeparate(StencilFace face, int mask) => _glStencilMaskSeparate((int)face, (uint)mask);

        /// <summary>
        ///     Instruct the GL server to block until the specified sync object becomes signaled.
        /// </summary>
        /// <param name="sync">Specifies the sync object whose status to wait on.</param>
        /// <param name="flags">A bitfield controlling the command flushing behavior.
        ///     <para>May be zero.</para>
        /// </param>
        /// <param name="timeout">
        ///     Specifies the timeout that the server should wait before continuing.
        ///     <para>Must be GL_TIMEOUT_IGNORED.</para>
        /// </param>
        public static void WaitSync(IntPtr sync, WaitSyncFlags flags, long timeout) => _glWaitSync(sync, (uint)flags, (ulong)timeout);

        /// <summary>
        ///     Create a new sync object and insert it into the GL command stream.
        /// </summary>
        /// <param name="condition">Specifies the condition that must be met to set the sync object's state to signaled.
        ///     <para>Must be GL_SYNC_GPU_COMMANDS_COMPLETE.</para>
        /// </param>
        /// <param name="flags">Specifies a bitwise combination of flags controlling the behavior of the sync object.
        ///     <para>No flags are presently defined for this operation and flags must be zero.</para>
        /// </param>
        /// <returns>The sync object reference.</returns>
        public static IntPtr FenceSync(SyncCondition condition, WaitSyncFlags flags = WaitSyncFlags.None) => _glFenceSync((int)condition, (uint)flags);

        /// <summary>
        ///     Delete a sync object
        /// </summary>
        /// <param name="sync">The sync object to be deleted.</param>
        public static void DeleteSync(IntPtr sync) => _glDeleteSync(sync);

        /// <summary>
        ///     Determines if a name corresponds to a sync object.
        /// </summary>
        /// <param name="sync">Specifies a value that may be the name of a sync object.</param>
        /// <returns><c>true</c> if sync is currently the name of a sync object, otherwise <c>false</c>.</returns>
        public static bool IsSync(IntPtr sync) => _glIsSync(sync);

        /// <summary>
        ///     Block and wait for a sync object to become signaled.
        /// </summary>
        /// <param name="sync">The sync object whose status to wait on.</param>
        /// <param name="flags">A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.</param>
        /// <param name="timeout">
        ///     The timeout, specified in nanoseconds, for which the implementation should wait for sync to
        ///     become signaled.
        /// </param>
        /// <returns>The status, which will be GL_ALREADY_SIGNALED, GL_TIMEOUT_EXPIRED, GL_CONDITION_SATISFIED, or GL_WAIT_FAILED.</returns>
        public static int ClientWaitSync(IntPtr sync, ClientWaitSyncFlags flags, long timeout) => _glClientWaitSync(sync, (uint)flags, (ulong)timeout);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void GetBooleanv(GetPName paramName, bool* data) => _glGetBooleanv((int)paramName, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <returns>The request parameter value.</returns>

        public static bool GetBoolean(GetPName paramName)
        {
            bool value;
            _glGetBooleanv((int)paramName, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>


        public static bool[] GetBoolean(GetPName paramName, int count)
        {
            var value = new bool[count];
            fixed (bool* v = &value[0])
            {
                _glGetBooleanv((int)paramName, v);
            }
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void GetDouble(GetPName paramName, double* data) => _glGetDoublev((int)paramName, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <returns>The request parameter value.</returns>

        public static double GetDouble(GetPName paramName)
        {
            double value;
            _glGetDoublev((int)paramName, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>


        public static double[] GetDoublev(GetPName paramName, int count)
        {
            var value = new double[count];
            fixed (double* v = &value[0])
            {
                _glGetDoublev((int)paramName, v);
            }
            return value;
        }


        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void GetFloat(GetPName paramName, float* data) => _glGetFloatv((int)paramName, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <returns>The request parameter value.</returns>

        public static float GetFloat(GetPName paramName)
        {
            float value;
            _glGetFloatv((int)paramName, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>


        public static float[] GetFloat(GetPName paramName, int count)
        {
            var value = new float[count];
            fixed (float* v = &value[0])
            {
                _glGetFloatv((int)paramName, v);
            }
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void GetInteger(GetPName paramName, int* data) => _glGetIntegerv((int)paramName, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <returns>The request parameter value.</returns>

        public static int GetInteger(GetPName paramName)
        {
            int value;
            _glGetIntegerv((int)paramName, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>


        public static int[] GetInteger(GetPName paramName, int count)
        {
            var value = new int[count];
            fixed (int* v = &value[0])
            {
                _glGetIntegerv((int)paramName, v);
            }
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void GetInteger64(GetPName paramName, long* data) => _glGetInteger64v((int)paramName, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <returns>The request parameter value.</returns>

        public static long GetInteger64(GetPName paramName)
        {
            long value;
            _glGetInteger64v((int)paramName, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="paramName">Specifies the parameter value to be returned.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>


        public static long[] GetInteger64(GetPName paramName, int count)
        {
            var value = new long[count];
            fixed (long* v = &value[0])
            {
                _glGetInteger64v((int)paramName, v);
            }
            return value;
        }

        /// <summary>
        ///     Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="count">The number of values to get.</param>
        /// <remarks>Array must have enough space allocated to contain the requested value(s).</remarks>


        public static void GetTexParameter(TextureTarget target, GetTextureParameter paramName, int count, float[] args)
        {
            var _args = new float[count];
            fixed (float* a = &_args[0])
            {
                _glGetTexParameterfv((int)target, (int)paramName, a);
            }
            args = _args;
        }

        /// <summary>
        ///     Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="count">The number of values to get.</param>
        /// <remarks>Array must have enough space allocated to contain the requested value(s).</remarks>


        public static void GetTexParameter(TextureTarget target, GetTextureParameter paramName, int count, int[] args)
        {
            var _args = new int[count];
            fixed (int* a = &_args[0])
            {
                _glGetTexParameteriv((int)target, (int)paramName, a);
            }
            args = _args;
        }

        /// <summary>
        ///     Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="args">An pointer to an array where the texture parameters will be stored.</param>
        public static void GetTexParameter(TextureTarget target, GetTextureParameter paramName, float* args) => _glGetTexParameterfv((int)target, (int)paramName, args);

        /// <summary>
        ///     Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="args">An pointer to an array where the texture parameters will be stored.</param>
        public static void GetTexParameter(TextureTarget target, GetTextureParameter paramName, int* args) => _glGetTexParameteriv((int)target, (int)paramName, args);

        /// <summary>
        ///     Return a single texture parameter value.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <returns>The value of the parameter.</returns>
        public static void GetTexParameter(TextureTarget target, GetTextureParameter paramName, out float args)
        {
            float _args;
            _glGetTexParameterfv((int)target, (int)paramName, &_args);
            args = _args;
        }

        /// <summary>
        ///     Return a single texture parameter value.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <returns>The value of the parameter.</returns>
        public static void GetTexParameter(TextureTarget target, GetTextureParameter paramName, out int args)
        {
            int _args;
            _glGetTexParameteriv((int)target, (int)paramName, &_args);
            args = _args;
        }

        /// <summary>
        ///     Return texture parameter values for a specific level of detail.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="count">The number of values to get.</param>
        /// <remarks>Array must have enough space allocated to contain the requested value(s).</remarks>
        

        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter paramName, int count, float[] args)
        {
            var _args = new float[count];
            fixed (float* a = &_args[0])
            {
                _glGetTexLevelParameterfv((int)target, level, (int)paramName, a);
            }
            args = _args;
        }

        /// <summary>
        ///     Return texture parameter values for a specific level of detail.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="count">The number of values to get.</param>
        /// <remarks>Array must have enough space allocated to contain the requested value(s).</remarks>


        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter paramName, int count, int[] args)
        {
            var _args = new int[count];
            fixed (int* a = &_args[0])
            {
                _glGetTexLevelParameteriv((int)target, level, (int)paramName, a);
            }
            args = _args;
        }

        /// <summary>
        ///     Return texture parameter values for a specific level of detail.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="args">An pointer to an array where the texture parameters will be stored.</param>
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter paramName, float* args) => _glGetTexLevelParameterfv((int)target, level, (int)paramName, args);

        /// <summary>
        ///     Return texture parameter values for a specific level of detail.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="args">An pointer to an array where the texture parameters will be stored.</param>
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter paramName, int* args) => _glGetTexLevelParameteriv((int)target, level, (int)paramName, args);

        /// <summary>
        ///     Return a single texture parameter value for a specific level of detail.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <returns>The value of the parameter.</returns>
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter paramName, out float args)
        {
            float _args;
            _glGetTexLevelParameterfv((int)target, level, (int)paramName, &_args);
            args = _args;
        }

        /// <summary>
        ///     Return a single texture parameter value for a specific level of detail.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">
        ///     Specifies the level-of-detail number of the desired image.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="paramName">Specifies the symbolic name of a texture parameter.</param>
        /// <returns>The value of the parameter.</returns>
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter paramName, out int args)
        {
            int _args;
            _glGetTexLevelParameteriv((int)target, level, (int)paramName, &_args);
            args = _args;
        }

        /// <summary>
        /// Copy pixels into a 1D texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the internal format of the texture.</param>
        /// <param name="x">Specify the window coordinates of the left corner of the row of pixels to be copied.</param>
        /// <param name="y">Specify the window coordinates of the left corner of the row of pixels to be copied.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 0 or 2 n + 2 ⁡ border for some integer n. The height of the texture image is 1.</param>
        /// <param name="border">Specifies the width of the border. Must be either 0 or 1.</param>
        public static void CopyTexImage1D(TextureTarget target, int level, InternalFormat internalFormat, int x, int y, int width, int border) => _glCopyTexImage1D((int)target, level, (int)internalFormat, x, y, width, border);

        /// <summary>
        /// Copy pixels into a 2D texture image.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the internal format of the texture.</param>
        /// <param name="x">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="y">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        /// <param name="width">Specifies the width of the texture image. Must be 0 or 2 n + 2 ⁡ border for some integer n.</param>
        /// <param name="height">Specifies the height of the texture image. Must be 0 or 2 n + 2 ⁡ border for some integer n.</param>
        /// <param name="border">Specifies the width of the border. Must be either 0 or 1.</param>
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalFormat, int x, int y, int width, int height, int border) => _glCopyTexImage2D((int)target, level, (int)internalFormat, x, y, width, height, border);

        /// <summary>
        ///     Copy a one-dimensional texture sub-image
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies the texel offset within the texture array.</param>
        /// <param name="x">Specify the window coordinates of the left corner of the row of pixels to be copied.</param>
        /// <param name="y">Specify the window coordinates of the left corner of the row of pixels to be copied.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        public static void CopyTexSubImage1D(TextureTarget target, int level, int xOffset, int x, int y, int width) => _glCopyTexSubImage1D((int)target, level, xOffset, x, y, width);

        /// <summary>
        ///     Copy a two-dimensional texture sub-image
        /// </summary>
        /// <param name="target">
        ///     Specifies the target to which the texture object is bound.
        ///     <para>
        ///         Must be GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X,
        ///         GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z,
        ///         GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_RECTANGLE.
        ///     </para>
        /// </param>
        /// <param name="level">
        ///     Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="x">
        ///     Specify the window coordinates of the lower left corner on the x-axis of the rectangular region of
        ///     pixels to be copied.
        /// </param>
        /// <param name="y">
        ///     Specify the window coordinates of the lower left corner on the y-axis of the rectangular region of
        ///     pixels to be copied.
        /// </param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xOffset, int yOffset, int x, int y, int width, int height) => _glCopyTexSubImage2D((int)target, level, xOffset, yOffset, x, y, width, height);

        /// <summary>
        ///     Specify a one-dimensional texture sub-image.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the pixel data.
        ///     <para>Must be GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, or GL_STENCIL_INDEX.</para>
        /// </param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexSubImage1D(TextureTarget target, int level, int xOffset, int width, PixelFormat format, PixelType type, IntPtr pixels) => _glTexSubImage1D((int)target, level, xOffset, width, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Specify a two-dimensional texture sub-image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the pixel data.
        ///     <para>Must be GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, or GL_STENCIL_INDEX.</para>
        /// </param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexSubImage2D(TextureTarget target, int level, int xOffset, int yOffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels) => _glTexSubImage2D((int)target, level, xOffset, yOffset, width, height, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Specify a three-dimensional texture sub-image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.
        ///     <para>Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_TEXTURE_CUBE_MAP_ARRAY.</para>
        /// </param>
        /// <param name="level">Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zOffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="depth">Specifies the depth of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the pixel data.
        ///     <para>Must be GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, or GL_STENCIL_INDEX.</para>
        /// </param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexSubImage3D(TextureTarget target, int level, int xOffset, int yOffset, int zOffset, int width,
            int height, int depth, PixelFormat format, PixelType type, IntPtr pixels) => _glTexSubImage3D((int)target, level,
            xOffset, yOffset, zOffset, width, height, depth, (int)format, (int)type, pixels.ToPointer());

        /// <summary>
        ///     Specify a one-dimensional texture sub-image.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the pixel data.
        ///     <para>Must be GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, or GL_STENCIL_INDEX.</para>
        /// </param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexSubImage1D(TextureTarget target, int level, int xOffset, int width, PixelFormat format, PixelType type, /*const*/ void* pixels) => _glTexSubImage1D((int)target, level, xOffset, width, (int)format, (int)type, pixels);

        /// <summary>
        ///     Specify a two-dimensional texture sub-image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the pixel data.
        ///     <para>Must be GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, or GL_STENCIL_INDEX.</para>
        /// </param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexSubImage2D(TextureTarget target, int level, int xOffset, int yOffset, int width, int height, PixelFormat format, PixelType type, /*const*/ void* pixels) => _glTexSubImage2D((int)target, level, xOffset, yOffset, width, height, (int)format, (int)type, pixels);

        /// <summary>
        ///     Specify a three-dimensional texture sub-image.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.
        ///     <para>Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_TEXTURE_CUBE_MAP_ARRAY.</para>
        /// </param>
        /// <param name="level">Specifies the level-of-detail number.
        ///     <para>Level 0 is the base image level. Level n is the nth mipmap reduction image.</para>
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zOffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="depth">Specifies the depth of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the pixel data.
        ///     <para>Must be GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, or GL_STENCIL_INDEX.</para>
        /// </param>
        /// <param name="type">Specifies the data type of the pixel data.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        public static void TexSubImage3D(TextureTarget target, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, PixelType type, /*const*/ void* pixels) => _glTexSubImage3D((int)target, level, xOffset, yOffset, zOffset, width, height, depth, (int)format, (int)type, pixels);

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">
        ///     Specifies what kind of primitives to render.
        ///     <para>
        ///         GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY,
        ///         GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and
        ///         GL_PATCHES are accepted.
        ///     </para>
        /// </param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices" />.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices" />.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The source indices.</param>
        public static void DrawRangeElements(PrimitiveType mode, int start, int end, int count, byte[] indices)
        {
            fixed (void* i = &indices[0])
            {
                _glDrawRangeElements((int)mode, (uint)start, (uint)end, count, (int)DrawElementsType.UnsignedByte, i);
            }
        }

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">
        ///     Specifies what kind of primitives to render.
        ///     <para>
        ///         GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY,
        ///         GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and
        ///         GL_PATCHES are accepted.
        ///     </para>
        /// </param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices" />.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices" />.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The source indices.</param>
        public static void DrawRangeElements(PrimitiveType mode, int start, int end, int count, short[] indices)
        {
            fixed (void* i = &indices[0])
            {
                _glDrawRangeElements((int)mode, (uint)start, (uint)end, count, (int)DrawElementsType.UnsignedShort, i);
            }
        }

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">
        ///     Specifies what kind of primitives to render.
        ///     <para>
        ///         GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY,
        ///         GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and
        ///         GL_PATCHES are accepted.
        ///     </para>
        /// </param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices" />.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices" />.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The source indices.</param>
        public static void DrawRangeElements(PrimitiveType mode, int start, int end, int count, int[] indices)
        {
            fixed (void* i = &indices[0])
            {
                _glDrawRangeElements((int)mode, (uint)start, (uint)end, count, (int)DrawElementsType.UnsignedInt, i);
            }
        }

        /// <summary>
        ///     Render primitives from array data.
        /// </summary>
        /// <param name="mode">
        ///     Specifies what kind of primitives to render.
        ///     <para>
        ///         GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY,
        ///         GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and
        ///         GL_PATCHES are accepted.
        ///     </para>
        /// </param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices" />.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices" />.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">
        ///     Specifies the type of the values in indices.
        ///     <para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para>
        /// </param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        public static void DrawRangeElements(PrimitiveType mode, int start, int end, int count, DrawElementsType type, /*const*/void* indices) => _glDrawRangeElements((int)mode, (uint)start, (uint)end, count, (int)type, indices);

        /// <summary>
        ///     Map all of a buffer object's data store into the client's address space.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="access">
        ///     Specifies the access policy, indicating whether it will be possible to read from, write to, or
        ///     both read from and write to the buffer object's mapped data store.
        ///     <para>The symbolic constant must be GL_READ_ONLY, GL_WRITE_ONLY, or GL_READ_WRITE.</para>
        /// </param>
        /// <returns>A pointer to the beginning of the mapped range.</returns>
        public static IntPtr MapBuffer(BufferTarget target, BufferAccess access) => new IntPtr(_glMapBuffer((int)target, (int)access));

        /// <summary>
        ///     Release the mapping of a buffer object's data store into the client's address space.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <returns><c>true</c> unless the data store contents have become corrupt during the time the data store was mapped.</returns>
        public static bool UnmapBuffer(BufferTarget target) => _glUnmapBuffer((int)target);

        /// <summary>
        ///     Copy a three-dimensional texture sub-image.
        /// </summary>
        /// <param name="target">
        ///     Specifies the target to which the texture object is bound.
        ///     <para>Must be GL_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_TEXTURE_CUBE_MAP_ARRAY.</para>
        /// </param>
        /// <param name="level">
        ///     Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap
        ///     reduction image.
        /// </param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zOffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="x">
        ///     Specify the window coordinates of the lower left corner of the rectangular region of pixels to be
        ///     copied.
        /// </param>
        /// <param name="y">
        ///     Specify the window coordinates of the lower left corner of the rectangular region of pixels to be
        ///     copied.
        /// </param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xOffset, int yOffset, int zOffset, int x, int y, int width, int height) => _glCopyTexSubImage3D((int)target, level, xOffset, yOffset, zOffset, x, y, width, height);

        /// <summary>
        /// Specify a three-dimensional texture image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_PROXY_TEXTURE_2D_ARRAY.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the format of the compressed image data stored at address data.</param>
        /// <param name="width">Specifies the width of the texture image.<para>All implementations support 3D texture images that are at least 16 texels wide.</para></param>
        /// <param name="height">Specifies the height of the texture image.<para>All implementations support 3D texture images that are at least 16 texels high.</para></param>
        /// <param name="depth">Specifies the depth of the texture image.<para>All implementations support 3D texture images that are at least 16 texels deep.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int depth, int border, int imageSize, IntPtr data) => _glCompressedTexImage3D((int)target, level, (int)internalFormat, width, height, depth, border, imageSize, data.ToPointer());

        /// <summary>
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the format of the compressed image data stored at address data.</param>
        /// <param name="width">Specifies the width of the texture image.<para>All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.</para></param>
        /// <param name="height">Specifies the height of the texture image.<para>All implementations support 2D texture and cube map texture images that are at least 16384 texels high.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int border, int imageSize, IntPtr data) => _glCompressedTexImage2D((int)target, level, (int)internalFormat, width, height, border, imageSize, data.ToPointer());

        /// <summary>
        /// Specify a one-dimensional texture image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the format of the compressed image data stored at address data.</param>
        /// <param name="width">Specifies the width of the texture image.<para>All implementations support texture images that are at least 64 texels wide. The height of the 1D texture image is 1.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexImage1D(TextureTarget target, int level, InternalFormat internalFormat, int width, int border, int imageSize, IntPtr data) => _glCompressedTexImage1D((int)target, level, (int)internalFormat, width, border, imageSize, data.ToPointer());

        /// <summary>
        /// Specify a three-dimensional texture image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_PROXY_TEXTURE_2D_ARRAY.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the format of the compressed image data stored at address data.</param>
        /// <param name="width">Specifies the width of the texture image.<para>All implementations support 3D texture images that are at least 16 texels wide.</para></param>
        /// <param name="height">Specifies the height of the texture image.<para>All implementations support 3D texture images that are at least 16 texels high.</para></param>
        /// <param name="depth">Specifies the depth of the texture image.<para>All implementations support 3D texture images that are at least 16 texels deep.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int depth, int border, int imageSize, /*const*/ void* data) => _glCompressedTexImage3D((int)target, level, (int)internalFormat, width, height, depth, border, imageSize, data);

        /// <summary>
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the format of the compressed image data stored at address data.</param>
        /// <param name="width">Specifies the width of the texture image.<para>All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.</para></param>
        /// <param name="height">Specifies the height of the texture image.<para>All implementations support 2D texture and cube map texture images that are at least 16384 texels high.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int border, int imageSize, /*const*/ void* data) => _glCompressedTexImage2D((int)target, level, (int)internalFormat, width, height, border, imageSize, data);

        /// <summary>
        /// Specify a one-dimensional texture image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="internalFormat">Specifies the format of the compressed image data stored at address data.</param>
        /// <param name="width">Specifies the width of the texture image.<para>All implementations support texture images that are at least 64 texels wide. The height of the 1D texture image is 1.</para></param>
        /// <param name="border">This value must be 0.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexImage1D(TextureTarget target, int level, InternalFormat internalFormat, int width, int border, int imageSize, /*const*/ void* data) => _glCompressedTexImage1D((int)target, level, (int)internalFormat, width, border, imageSize, data);

        /// <summary>
        /// Specify a three-dimensional texture sub-image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.<para>Must be GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, or GL_TEXTURE_CUBE_MAP_ARRAY.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="depth">Specifies the depth of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the compressed image data stored at address <paramref name="data"/>.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data) => _glCompressedTexSubImage3D((int)target, level, xOffset, yOffset, zOffset, width, height, depth, (int)format, imageSize, data.ToPointer());

        /// <summary>
        /// Specify a two-dimensional texture sub-image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the compressed image data stored at address <paramref name="data"/>.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xOffset, int yOffset, int width, int height, PixelFormat format, int imageSize, IntPtr data) => _glCompressedTexSubImage2D((int)target, level, xOffset, yOffset, width, height, (int)format, imageSize, data.ToPointer());

        /// <summary>
        /// Specify a one-dimensional texture sub-image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the compressed image data stored at address <paramref name="data"/>.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xOffset, int width, PixelFormat format, int imageSize, IntPtr data) => _glCompressedTexSubImage1D((int)target, level, xOffset, width, (int)format, imageSize, data.ToPointer());

        /// <summary>
        /// Specify a three-dimensional texture sub-image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.<para>Must be GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, or GL_TEXTURE_CUBE_MAP_ARRAY.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="depth">Specifies the depth of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the compressed image data stored at address <paramref name="data"/>.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xOffset, int yOffset, int zOffset, int width, int height, int depth, PixelFormat format, int imageSize, /*const*/ void* data) => _glCompressedTexSubImage3D((int)target, level, xOffset, yOffset, zOffset, width, height, depth, (int)format, imageSize, data);

        /// <summary>
        /// Specify a two-dimensional texture sub-image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yOffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="height">Specifies the height of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the compressed image data stored at address <paramref name="data"/>.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xOffset, int yOffset, int width, int height, PixelFormat format, int imageSize, /*const*/ void* data) => _glCompressedTexSubImage2D((int)target, level, xOffset, yOffset, width, height, (int)format, imageSize, data);

        /// <summary>
        /// Specify a one-dimensional texture sub-image in a compressed format.
        /// </summary>
        /// <param name="target">Specifies the target texture.<para>Must be GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.</para></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xOffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture sub-image.</param>
        /// <param name="format">Specifies the format of the compressed image data stored at address <paramref name="data"/>.</param>
        /// <param name="imageSize">Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.</param>
        /// <param name="data">Specifies a pointer to the compressed image data in memory.</param>
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xOffset, int width, PixelFormat format, int imageSize, /*const*/ void* data) => _glCompressedTexSubImage1D((int)target, level, xOffset, width, (int)format, imageSize, data);

        /// <summary>
        ///     Specify pixel arithmetic for RGB and alpha components separately.
        /// </summary>
        /// <param name="sFactorRgb">
        ///     Specifies how the red, green, and blue blending factors are computed.
        ///     <para>The initial value is GL_ONE.</para>
        /// </param>
        /// <param name="dFactorRgb">
        ///     Specifies how the red, green, and blue destination blending factors are computed.
        ///     <para>The initial value is GL_ZERO.</para>
        /// </param>
        /// <param name="sFactorAlpha">
        ///     Specified how the alpha source blending factor is computed.
        ///     <para>The initial value is GL_ONE.</para>
        /// </param>
        /// <param name="dFactorAlpha">
        ///     Specified how the alpha destination blending factor is computed.
        ///     <para>The initial value is GL_ZERO.</para>
        /// </param>
        public static void BlendFuncSeparate(BlendingFactorSrc sFactorRgb, BlendingFactorDest dFactorRgb, BlendingFactorSrc sFactorAlpha, BlendingFactorDest dFactorAlpha) => _glBlendFuncSeparate((int)sFactorRgb, (int)dFactorRgb, (int)sFactorAlpha, (int)dFactorAlpha);

        /// <summary>
        ///     Delete named framebuffer objects.
        /// </summary>
        /// <param name="n">Specifies the number of framebuffer objects to be deleted.</param>
        /// <param name="buffers">Specifies an array of framebuffer objects to be deleted.</param>
        public static void DeleteFramebuffers(int n, /*const*/ int* buffers) => _glDeleteFramebuffers(n, (uint*)buffers);

        /// <summary>
        ///     Delete named framebuffer objects.
        /// </summary>
        /// <param name="buffers">Specifies an array of framebuffer objects to be deleted.</param>
        public static void DeleteFramebuffers(int[] buffers)
        {
            if (buffers is null)
                return;
            fixed (int* ids = &buffers[0])
            {
                _glDeleteFramebuffers(buffers.Length, (uint*)ids);
            }
        }

        /// <summary>
        ///     Deletes a single framebuffer object.
        /// </summary>
        /// <param name="buffer">A framebuffer to be deleted.</param>
        public static void DeleteFramebuffer(int buffer) => _glDeleteFramebuffers(1, (uint*)&buffer);

        /// <summary>
        ///     Bind a named buffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="buffer">Specifies the name of a buffer object.</param>
        public static void BindBuffer(BufferTarget target, int buffer) => _glBindBuffer((int)target, (uint)buffer);

        /// <summary>
        /// Bind a named framebuffer object.
        /// </summary>
        /// <param name="framebuffer">Specifies the name of a framebuffer object.</param>
        public static void BindFramebuffer(int framebuffer) => _glBindFramebuffer((int)FramebufferTarget.Framebuffer, (uint)framebuffer);

        /// <summary>
        /// Bind a named renderbuffer object.
        /// </summary>
        /// <param name="renderbuffer">Specifies the name of a renderbuffer object.</param>
        public static void BindRenderbuffer(int renderbuffer) => _glBindRenderbuffer((int)RenderbufferTarget.Renderbuffer, (uint)renderbuffer);

        /// <summary>
        ///     Deletes a single buffer object.
        /// </summary>
        /// <param name="buffer">A buffer to be deleted.</param>
        public static void DeleteBuffer(int buffer) => _glDeleteBuffers(1, (uint*)&buffer);

        /// <summary>
        ///     Deletes a single renderbuffer object.
        /// </summary>
        /// <param name="renderbuffer">A renderbuffer to be deleted.</param>
        public static void DeleteRenderbuffer(int renderbuffer) => _glDeleteRenderbuffers(1, (uint*)&renderbuffer);

        /// <summary>
        ///     Delete named renderbuffer objects.
        /// </summary>
        /// <param name="n">Specifies the number of renderbuffer objects to be deleted.</param>
        /// <param name="buffers">Specifies an array of renderbuffer objects to be deleted.</param>
        public static void DeleteRenderbuffers(int n, /*const*/ int* buffers) => _glDeleteRenderbuffers(n, (uint*)buffers);

        /// <summary>
        ///     Delete named renderbuffer objects.
        /// </summary>
        /// <param name="buffers">Specifies an array of renderbuffer objects to be deleted.</param>
        public static void DeleteRenderbuffers(int[] buffers)
        {
            if (buffers is null)
                return;
            fixed (int* ids = &buffers[0])
            {
                _glDeleteRenderbuffers(buffers.Length, (uint*)ids);
            }
        }

        /// <summary>
        ///     Delete named buffer objects.
        /// </summary>
        /// <param name="n">Specifies the number of buffer objects to be deleted.</param>
        /// <param name="buffers">Specifies an array of buffer objects to be deleted.</param>
        public static void DeleteBuffers(int n, /*const*/ int* buffers) => _glDeleteBuffers(n, (uint*)buffers);

        /// <summary>
        ///     Delete named buffer objects.
        /// </summary>
        /// <param name="buffers">Specifies an array of buffer objects to be deleted.</param>
        public static void DeleteBuffers(int[] buffers)
        {
            if (buffers is null)
                return;
            fixed (int* ids = &buffers[0])
            {
                _glDeleteBuffers(buffers.Length, (uint*)ids);
            }
        }

        /// <summary>
        ///     Generate framebuffer object names.
        /// </summary>
        /// <param name="n">Specifies the number of framebuffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated framebuffer object names are stored.</param>
        public static void GenFramebuffers(int n, int* buffers) => _glGenFramebuffers(n, (uint*)buffers);

        /// <summary>
        ///     Generate a single framebuffer object name.
        /// </summary>
        /// <returns>The framebuffer object name.</returns>

        public static int GenFramebuffer()
        {
            int id;
            _glGenFramebuffers(1, (uint*)&id);
            return id;
        }

        /// <summary>
        ///     Generate framebuffer object names.
        /// </summary>
        /// <param name="n">Specifies the number of framebuffer object names to be generated.</param>
        /// <returns>An array of generated framebuffer object names.</returns>


        public static int[] GenFramebuffers(int n)
        {
            var buffers = new int[n];
            fixed (int* ids = &buffers[0])
            {
                _glGenFramebuffers(n, (uint*)ids);
            }
            return buffers;
        }

        /// <summary>
        ///     Generate renderbuffer object names.
        /// </summary>
        /// <param name="n">Specifies the number of renderbuffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated renderbuffer object names are stored.</param>
        public static void GenRenderbuffers(int n, uint* buffers) => _glGenRenderbuffers(n, buffers);

        /// <summary>
        ///     Generate a single renderbuffer object name.
        /// </summary>
        /// <returns>The renderbuffer object name.</returns>

        public static int GenRenderbuffer()
        {
            int id;
            _glGenRenderbuffers(1, (uint*)&id);
            return id;
        }

        /// <summary>
        ///     Generate renderbuffer object names.
        /// </summary>
        /// <param name="n">Specifies the number of renderbuffer object names to be generated.</param>
        /// <returns>An array of generated renderbuffer object names.</returns>


        public static int[] GenRenderbuffers(int n)
        {
            var buffers = new int[n];
            fixed (int* ids = &buffers[0])
            {
                _glGenRenderbuffers(n, (uint*)ids);
            }
            return buffers;
        }

        /// <summary>
        ///     Generate buffer object names.
        /// </summary>
        /// <param name="n">Specifies the number of buffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        public static void GenBuffers(int n, int* buffers) => _glGenBuffers(n, (uint*)buffers);

        /// <summary>
        ///     Generate a single buffer object name.
        /// </summary>
        /// <returns>The buffer object name.</returns>

        public static int GenBuffer()
        {
            int id;
            _glGenBuffers(1, (uint*)&id);
            return id;
        }

        /// <summary>
        ///     Generate buffer object names.
        /// </summary>
        /// <param name="n">Specifies the number of buffer object names to be generated.</param>
        /// <returns>An array of generated buffer object names.</returns>


        public static int[] GenBuffers(int n)
        {
            var buffers = new int[n];
            fixed (int* ids = &buffers[0])
            {
                _glGenBuffers(n, (uint*)ids);
            }
            return buffers;
        }

        /// <summary>
        /// Determine if a name corresponds to a buffer object.
        /// </summary>
        /// <param name="buffer">Specifies a value that may be the name of a buffer object.</param>
        /// <returns><c>true</c> if object is a buffer, otherwise <c>false</c>.</returns>
        public static bool IsBuffer(int buffer) => _glIsBuffer((uint)buffer);

        /// <summary>
        /// Determine if a name corresponds to a framebuffer object.
        /// </summary>
        /// <param name="framebuffer">Specifies a value that may be the name of a framebuffer object.</param>
        /// <returns><c>true</c> if value is a framebuffer object, otherwise <c>false</c>.</returns>
        public static bool IsFramebuffer(int framebuffer) => _glIsFramebuffer((uint)framebuffer);

        /// <summary>
        /// Determine if a name corresponds to a renderbuffer object.
        /// </summary>
        /// <param name="renderbuffer">Specifies a value that may be the name of a renderbuffer object.</param>
        /// <returns><c>true</c> if object is a renderbuffer, otherwise <c>false</c>.</returns>
        public static bool IsRenderbuffer(int renderbuffer) => _glIsRenderbuffer((uint)renderbuffer);

        /// <summary>
        ///     Generate sampler object names.
        /// </summary>
        /// <param name="count">Specifies the number of sampler object names to generate.</param>
        /// <param name="samplers">Specifies an array in which the generated sampler object names are stored.</param>
        public static void GenSamplers(int count, int* samplers) => _glGenSamplers(count, (uint*)samplers);

        /// <summary>
        ///     Generate sampler object names.
        /// </summary>
        /// <param name="count">Specifies the number of sampler object names to generate.</param>
        /// <returns>An array containing the generated sampler object names.</returns>

        public static int[] GenSamplers(int count)
        {
            var samplers = new int[count];
            fixed (int* s = &samplers[0])
            {
                _glGenSamplers(count, (uint*)s);
            }

            return samplers;
        }

        /// <summary>
        ///     Generate a single sampler object name.
        /// </summary>
        /// <returns>The generated sampler object name.</returns>
        public static int GenSampler()
        {
            int sampler;
            _glGenSamplers(1, (uint*)&sampler);
            return sampler;
        }

        /// <summary>
        ///     Determine if a name corresponds to a sampler object.
        /// </summary>
        /// <param name="sampler">Specifies a value that may be the name of a sampler object.</param>
        /// <returns><c>true</c> if object is a sampler object, otherwise <c>false</c>.</returns>
        public static bool IsSampler(int sampler) => _glIsSampler((uint)sampler);

        /// <summary>
        ///     Delete named sampler objects.
        /// </summary>
        /// <param name="samplers">Specifies an array of sampler objects to be deleted.</param>
        public static void DeleteSamplers(int[] samplers)
        {
            fixed (int* s = &samplers[0])
            {
                _glDeleteSamplers(samplers.Length, (uint*)s);
            }
        }

        /// <summary>
        ///     Delete named sampler objects.
        /// </summary>
        /// <param name="count">Specifies the number of sampler objects to be deleted.</param>
        /// <param name="samplers">Specifies an array of sampler objects to be deleted.</param>
        public static void DeleteSamplers(int count, /*const*/ int* samplers) => _glDeleteSamplers(count, (uint*)samplers);

        /// <summary>
        ///     Delete a single named sampler object.
        /// </summary>
        /// <param name="sampler">Sampler object to delete.</param>
        public static void DeleteSampler(int sampler) => _glDeleteSamplers(1, (uint*)&sampler);

        /// <summary>
        ///     Bind a named sampler to a texturing target.
        /// </summary>
        /// <param name="unit">Specifies the index of the texture unit to which the sampler is bound.</param>
        /// <param name="sampler">Specifies the name of a sampler.</param>
        public static void BindSampler(int unit, int sampler) => _glBindSampler((uint)unit, (uint)sampler);

        /// <summary>
        /// Attach a level of a texture object as a logical buffer of a framebuffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the framebuffer is bound.</param>
        /// <param name="attachment">Specifies the attachment point of the framebuffer.</param>
        /// <param name="texTarget">Specifies what type of texture is expected in the texture parameter, or for cube map textures, which face is to be attached.</param>
        /// <param name="texture">Specifies the name of an existing texture object to attach.</param>
        /// <param name="level">Specifies the mipmap level of the texture object to attach.</param>
        public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget texTarget, int texture, int level) => _glFramebufferTexture1D((int)target, (int)attachment, (int)texTarget, (uint)texture, level);

        /// <summary>
        /// Attach a level of a texture object as a logical buffer of a framebuffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the framebuffer is bound.</param>
        /// <param name="attachment">Specifies the attachment point of the framebuffer.</param>
        /// <param name="texTarget">Specifies what type of texture is expected in the texture parameter, or for cube map textures, which face is to be attached.</param>
        /// <param name="texture">Specifies the name of an existing texture object to attach.</param>
        /// <param name="level">Specifies the mipmap level of the texture object to attach.</param>
        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget texTarget, int texture, int level) => _glFramebufferTexture2D((int)target, (int)attachment, (int)texTarget, (uint)texture, level);

        /// <summary>
        /// Attach a level of a texture object as a logical buffer of a framebuffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the framebuffer is bound.</param>
        /// <param name="attachment">Specifies the attachment point of the framebuffer.</param>
        /// <param name="texTarget">Specifies what type of texture is expected in the texture parameter, or for cube map textures, which face is to be attached.</param>
        /// <param name="texture">Specifies the name of an existing texture object to attach.</param>
        /// <param name="level">Specifies the mipmap level of the texture object to attach.</param>
        /// <param name="zOffset">The offset on the z-axis.</param>
        public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget texTarget, int texture, int level, int zOffset) => _glFramebufferTexture3D((int)target, (int)attachment, (int)texTarget, (uint)texture, level, zOffset);

        /// <summary>
        ///     Check the completeness status of a framebuffer.
        /// </summary>
        /// <param name="target">Specify the target to which the framebuffer is bound to check.</param>
        /// <returns></returns> 
        public static int CheckFramebufferStatus(FramebufferTarget target) => _glCheckFramebufferStatus((int)target);

        /// <summary>
        /// Clear individual buffers of a framebuffer.
        /// </summary>
        /// <param name="buffer">Specify the buffer to clear.</param>
        /// <param name="drawbuffer">Specify a particular draw buffer to clear.</param>
        /// <param name="value">The value or values to clear the buffer to.</param>
        public static void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glClearBufferiv((int)buffer, drawbuffer, v);
            }
        }

        /// <summary>
        /// Clear individual buffers of a framebuffer.
        /// </summary>
        /// <param name="buffer">Specify the buffer to clear.</param>
        /// <param name="drawbuffer">Specify a particular draw buffer to clear.</param>
        /// <param name="value">The value or values to clear the buffer to.</param>
        public static void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glClearBufferuiv((int)buffer, drawbuffer, v);
            }
        }

        /// <summary>
        /// Clear individual buffers of a framebuffer.
        /// </summary>
        /// <param name="buffer">Specify the buffer to clear.</param>
        /// <param name="drawbuffer">Specify a particular draw buffer to clear.</param>
        /// <param name="value">The value or values to clear the buffer to.</param>
        public static void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glClearBufferfv((int)buffer, drawbuffer, v);
            }
        }

        /// <summary>
        /// Clear individual buffers of a framebuffer.
        /// </summary>
        /// <param name="buffer">Specify the buffer to clear.</param>
        /// <param name="drawbuffer">Specify a particular draw buffer to clear.</param>
        /// <param name="value">A pointer to the value or values to clear the buffer to.</param>
        public static void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, /*const*/ int* value) => _glClearBufferiv((int)buffer, drawbuffer, value);

        /// <summary>
        /// Clear individual buffers of a framebuffer.
        /// </summary>
        /// <param name="buffer">Specify the buffer to clear.</param>
        /// <param name="drawbuffer">Specify a particular draw buffer to clear.</param>
        /// <param name="value">A pointer to the value or values to clear the buffer to.</param>
        public static void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, /*const*/ uint* value) => _glClearBufferuiv((int)buffer, drawbuffer, value);

        /// <summary>
        /// Clear individual buffers of a framebuffer.
        /// </summary>
        /// <param name="buffer">Specify the buffer to clear.</param>
        /// <param name="drawbuffer">Specify a particular draw buffer to clear.</param>
        /// <param name="value">A pointer to the value or values to clear the buffer to.</param>
        public static void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, /*const*/ float* value) => _glClearBufferfv((int)buffer, drawbuffer, value);

        /// <summary>
        /// Clear individual buffers of a framebuffer.
        /// </summary>
        /// <param name="buffer">Specify the buffer to clear.</param>
        /// <param name="drawbuffer">Specify a particular draw buffer to clear.</param>
        /// <param name="depth">The value to clear the depth buffer to.</param>
        /// <param name="stencil">The value to clear the stencil buffer to.</param>
        public static void ClearBuffer(ClearBufferCombined buffer, int drawbuffer, float depth, int stencil) => _glClearBufferfi((int)buffer, drawbuffer, depth, stencil);

        /// <summary>
        /// Attaches a shader object to a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to which a shader object will be attached.</param>
        /// <param name="shader">Specifies the shader object that is to be attached.</param>
        public static void AttachShader(int program, int shader) => _glAttachShader((uint)program, (uint)shader);

        /// <summary>
        ///     Bind a buffer object to an indexed buffer target.
        /// </summary>
        /// <param name="target">
        ///     Specify the target of the bind operation
        ///     <para>
        ///         Must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, GL_UNIFORM_BUFFER, or
        ///         GL_SHADER_STORAGE_BUFFER.
        ///     </para>
        /// </param>
        /// <param name="index">Specify the index of the binding point within the array specified by target.</param>
        /// <param name="buffer">The name of a buffer object to bind to the specified binding point.</param>
        public static void BindBufferBase(BufferRangeTarget target, int index, int buffer) => _glBindBufferBase((int)target, (uint)index, (uint)buffer);

        /// <summary>
        ///     Record the GL time into a query object after all previous commands have reached the GL server but have not yet
        ///     necessarily executed.
        /// </summary>
        /// <param name="id">Specify the name of a query object into which to record the GL time.</param>
        /// <param name="target">Specify the counter to query. must be GL_TIMESTAMP.</param>
        public static void QueryCounter(int id, QueryCounterTarget target) => _glQueryCounter((uint)id, (int)target);

        /// <summary>
        ///     Set the value of a sub-word of the sample mask.
        /// </summary>
        /// <param name="maskNumber">Specifies which 32-bit sub-word of the sample mask to update.</param>
        /// <param name="mask">Specifies the new value of the mask sub-word.</param>
        public static void SampleMask(int maskNumber, int mask) => _glSampleMaski((uint)maskNumber, (uint)mask);

        /// <summary>
        ///     Query the bindings of color indices to user-defined varying out variables.
        /// </summary>
        /// <param name="program">The name of the program containing varying out variable whose binding to query.</param>
        /// <param name="name">The name of the user-defined varying out variable whose index to query.</param>
        /// <returns>
        ///     The index of the fragment color to which the variable name was bound when the program object program was last
        ///     linked, ot <c>-1</c> if an error occured.
        /// </returns>
        public static int GetFragDataIndex(int program, string name)
        {
            var buffer = Encoding.UTF8.GetBytes(name);
            fixed (byte* b = &buffer[0])
            {
                return _glGetFragDataIndex((uint)program, b);
            }
        }

        /// <summary>
        /// Start transform feedback operation.
        /// </summary>
        /// <param name="primitiveMode">Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform feedback.</param>
        public static void BeginTransformFeedback(TransformFeedbackPrimitiveType primitiveMode) => _glBeginTransformFeedback((int)primitiveMode);

        /// <summary>
        /// End transform feedback operation.
        /// </summary>
        public static void EndTransformFeedback() => _glEndTransformFeedback();

        /// <summary>
        /// Enable or disable server-side GL capabilities.
        /// </summary>
        /// <param name="target">Specifies a symbolic constant indicating a GL capability.</param>
        /// <param name="index">Specifies the index of the switch to enable.</param>
        public static void Enable(IndexedEnableCap target, int index) => _glEnablei((int)target, (uint)index);

        /// <summary>
        /// Disable server-side GL capabilities
        /// </summary>
        /// <param name="target">Specifies a symbolic constant indicating a GL capability.</param>
        /// <param name="index">Specifies the index of the switch to disable</param>
        public static void Disable(IndexedEnableCap target, int index) => _glDisablei((int)target, (uint)index);

        /// <summary>
        /// Test whether a capability is enabled.
        /// </summary>
        /// <param name="target">Specifies a symbolic constant indicating a GL capability.</param>
        /// <param name="index">Specifies the index of the capability.</param>
        /// <returns><c>true</c> if capability is enabled, otherwise <c>false</c>.</returns>
        public static bool IsEnabled(IndexedEnableCap target, int index) => _glIsEnabledi((int)target, (uint)index);

        /// <summary>
        ///     Compiles a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be compiled.</param>
        public static void CompileShader(int shader) => _glCompileShader((uint)shader);

        /// <summary>
        ///     Creates a shader program object.
        /// </summary>
        /// <returns>An empty program object, a non-zero value by which it can be referenced.</returns>
        public static int CreateProgram() => (int)_glCreateProgram();

        /// <summary>
        ///     Creates a shader object.
        /// </summary>
        /// <param name="type">Specifies the type of shader to be created.<para>Must be one of GL_VERTEX_SHADER, GL_GEOMETRY_SHADER, or GL_FRAGMENT_SHADER.</para></param>
        /// <returns>An empty shader object, a non-zero value by which it can be referenced.</returns>
        public static int CreateShader(ShaderType type) => (int)_glCreateShader((int)type);

        /// <summary>
        ///     Determines if a name corresponds to a program object.
        /// </summary>
        /// <param name="program">The potential program object to check.</param>
        /// <returns><c>true</c> if object is a program, otherwise <c>false</c>.</returns>
        public static bool IsProgram(int program) => _glIsProgram((uint)program);

        /// <summary>
        ///     Determines if a name corresponds to a shader object.
        /// </summary>
        /// <param name="shader">The potential program object to check.</param>
        /// <returns><c>true</c> if object is a shader, otherwise <c>false</c>.</returns>
        public static bool IsShader(int shader) => _glIsShader((uint)shader);

        /// <summary>
        ///     Deletes a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be deleted.</param>
        public static void DeleteProgram(int program) => _glDeleteProgram((uint)program);

        /// <summary>
        ///     Deletes a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be deleted.</param>
        public static void DeleteShader(int shader) => _glDeleteShader((uint)shader);

        /// <summary>
        ///     Detaches a shader object from a program object to which it is attached.
        /// </summary>
        /// <param name="program">Specifies the program object from which to detach the shader object.</param>
        /// <param name="shader">Specifies the shader object to be detached.</param>
        public static void DetachShader(int program, int shader) => _glDetachShader((uint)program, (uint)shader);

        /// <summary>
        ///     Installs a program object as part of current rendering state.
        /// </summary>
        /// <param name="program">Specifies the handle of the program object whose executables are to be used as part of current rendering state.</param>
        public static void UseProgram(int program) => _glUseProgram((uint)program);

        /// <summary>
        ///     Links a program object.
        /// </summary>
        /// <param name="program">Specifies the handle of the program object to be linked.</param>
        public static void LinkProgram(int program) => _glLinkProgram((uint)program);

        /// <summary>
        ///      Replaces the source code in a shader object.
        /// </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="str">Specifies an array of pointers to strings containing the source code to be loaded into the shader.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        public static void ShaderSource(int shader, int count, /*const*/ byte** str, /*const*/ int* length) => _glShaderSource((uint)shader, count, str, length);

        /// <summary>
        ///      Replaces the source code in a shader object.
        /// </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="source">The source code to be loaded into the shader.</param>
        public static void ShaderSource(int shader, string source)
        {
            var buffer = Encoding.UTF8.GetBytes(source);
            fixed (byte* p = &buffer[0])
            {
                var sources = new[] { p };
                fixed (byte** s = &sources[0])
                {
                    var length = buffer.Length;
                    _glShaderSource((uint)shader, 1, s, &length);
                }
            }
        }

        /// <summary>
        ///      Returns the location of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the uniform variable whose location is to be queried.</param>
        /// <returns>An integer that represents the location of a specific uniform variable within a program object.</returns>
        public static int GetUniformLocation(int program, /*const*/ byte* name) => _glGetUniformLocation((uint)program, name);

        /// <summary>
        ///      Returns the location of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">A array of bytes containing the name of the uniform variable whose location is to be queried.</param>
        /// <returns>An integer that represents the location of a specific uniform variable within a program object.</returns>
        public static int GetUniformLocation(int program, byte[] name)
        {
            fixed (byte* b = &name[0])
            {
                return _glGetUniformLocation((uint)program, b);
            }
        }

        /// <summary>
        ///      Returns the location of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">A string containing the name of the uniform variable whose location is to be queried.</param>
        /// <returns>An integer that represents the location of a specific uniform variable within a program object.</returns>
        public static int GetUniformLocation(int program, string name)
        {
            var bytes = Encoding.UTF8.GetBytes(name);
            fixed (byte* b = &bytes[0])
            {
                return _glGetUniformLocation((uint)program, b);
            }
        }

        /// <summary>
        ///     Returns the source code string from a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned source code string.</param>
        /// <returns>The shader source, or <c>null</c> if an error occured.</returns>


        public static string GetShaderSource(int shader, int bufSize = 4096)
        {
            var buffer = Marshal.AllocHGlobal(bufSize);
            try
            {
                int length;
                var source = (byte*)buffer.ToPointer();
                _glGetShaderSource((uint)shader, bufSize, &length, source);
                return PtrToStringUtf8(buffer, length);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// <summary>
        ///     Returns the information log for a program object.
        /// </summary>
        /// <param name="program">Specifies the program object whose information log is to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <returns>The info log, or <c>null</c> if an error occured.</returns>


        public static string GetProgramInfoLog(int program, int bufSize = 1024)
        {
            var buffer = Marshal.AllocHGlobal(bufSize);
            try
            {
                int length;
                var source = (byte*)buffer.ToPointer();
                _glGetProgramInfoLog((uint)program, bufSize, &length, source);
                return PtrToStringUtf8(buffer, length);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// <summary>
        ///     Returns the information log for a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="bufSize">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <returns>The info log, or <c>null</c> if an error occured.</returns>


        public static string GetShaderInfoLog(int shader, int bufSize = 1024)
        {
            var buffer = Marshal.AllocHGlobal(bufSize);
            try
            {
                int length;
                var source = (byte*)buffer.ToPointer();
                _glGetShaderInfoLog((uint)shader, bufSize, &length, source);
                return PtrToStringUtf8(buffer, length);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// <summary>
        ///     Validates a program object.
        /// </summary>
        /// <param name="program">Specifies the handle of the program object to be validated.</param>
        /// <seealso cref="glGetProgramInfoLog"/>
        public static void ValidateProgram(int program) => _glValidateProgram((uint)program);

        /// <summary>
        ///     Render multiple sets of primitives by specifying indices of array data elements.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Points to an array of the elements counts.</param>
        /// <param name="type">
        ///     Specifies the type of the values in indices.
        ///     <para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para>
        /// </param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="drawCount">Specifies the size of the count and indices arrays.</param>
        public static void MultiDrawElements(PrimitiveType mode, /*const*/ int* count, DrawElementsType type, /*const*/void* /*const*/* indices, int drawCount) => _glMultiDrawElements((int)mode, count, (int)type, indices, drawCount);

        /// <summary>
        ///     Render multiple sets of primitives by specifying indices of array data elements.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Points to an array of the elements counts.</param>
        /// <param name="type">
        ///     Specifies the type of the values in indices.
        ///     <para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para>
        /// </param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="drawCount">Specifies the size of the count and indices arrays.</param>
        public static void MultiDrawElements(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr indices, int drawCount)
        {
            // Test this actually works
            var ptr = (void**)indices.ToPointer();
            fixed (int* c = &count[0])
            {
                _glMultiDrawElements((int)mode, c, (int)type, ptr, drawCount);
            }
        }

        /// <summary>
        ///     Render multiple sets of primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="first">Points to an array of starting indices in the enabled arrays.</param>
        /// <param name="count">Points to an array of the number of indices to be rendered.</param>
        /// <param name="drawCount">Specifies the size of the first and count.</param>
        public static void MultiDrawArrays(PrimitiveType mode, /*const*/ int* first, /*const*/ int* count, int drawCount) => _glMultiDrawArrays((int)mode, first, count, drawCount);

        /// <summary>
        ///     Render multiple sets of primitives from array data.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="first">An array of starting indices in the enabled arrays.</param>
        /// <param name="count">An array of the number of indices to be rendered.</param>
        /// <param name="drawCount">Specifies the size of the first and count.</param>
        public static void MultiDrawArrays(PrimitiveType mode, int[] first, int[] count, int drawCount)
        {
            fixed (int* f = &first[0])
            {
                fixed (int* c = &count[0])
                {
                    _glMultiDrawArrays((int)mode, f, c, drawCount);
                }
            }
        }

        /// <summary>
        ///     Attach a level of a texture object as a logical buffer of a framebuffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the framebuffer is bound.</param>
        /// <param name="attachment">Specifies the attachment point of the framebuffer.</param>
        /// <param name="texture">Specifies the name of an existing texture object to attach.</param>
        /// <param name="level">Specifies the mipmap level of the texture object to attach.</param>
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level) => _glFramebufferTexture((int)target, (int)attachment, (uint)texture, level);

        /// <summary>
        ///     Attach a renderbuffer object to a framebuffer object.
        /// </summary>
        /// <param name="target">Specifies the framebuffer target. The symbolic constant must be GL_FRAMEBUFFER.</param>
        /// <param name="attachment">
        ///     Specifies the attachment point to which renderbuffer should be attached.
        ///     <para>
        ///         Must be one of the following symbolic constants: GL_COLOR_ATTACHMENT0, GL_DEPTH_ATTACHMENT, or
        ///         GL_STENCIL_ATTACHMENT.
        ///     </para>
        /// </param>
        /// <param name="renderbufferTarget">Specifies the renderbuffer target. The symbolic constant must be GL_RENDERBUFFER.</param>
        /// <param name="renderbuffer">Specifies the renderbuffer object that is to be attached.</param>
        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbufferTarget, int renderbuffer) => _glFramebufferRenderbuffer((int)target, (int)attachment, (int)renderbufferTarget, (uint)renderbuffer);

        /// <summary>
        ///     Attach a renderbuffer object to a framebuffer object.
        /// </summary>
        /// <param name="attachment">
        ///     Specifies the attachment point to which renderbuffer should be attached.
        ///     <para>
        ///         Must be one of the following symbolic constants: GL_COLOR_ATTACHMENT0, GL_DEPTH_ATTACHMENT, or
        ///         GL_STENCIL_ATTACHMENT.
        ///     </para>
        /// </param>
        /// <param name="renderbuffer">Specifies the renderbuffer object that is to be attached.</param>
        public static void FramebufferRenderbuffer(FramebufferAttachment attachment, int renderbuffer) => _glFramebufferRenderbuffer((int)FramebufferTarget.Framebuffer, (int)attachment, (int)RenderbufferTarget.Renderbuffer, (uint)renderbuffer);

        /// <summary>
        ///     Returns a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">SSpecifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store from which data will be returned,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being returned.</param>
        /// <param name="data">Specifies a pointer to the location where buffer object data is returned.</param>
        public static void GetBufferSubData(BufferTarget target, int offset, int size, IntPtr data) => _glGetBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data.ToPointer());

        /// <summary>
        ///     Returns a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">SSpecifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store from which data will be returned,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being returned.</param>
        /// <param name="data">Specifies a pointer to the location where buffer object data is returned.</param>
        public static void GetBufferSubData(BufferTarget target, long offset, long size, IntPtr data) => _glGetBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data.ToPointer());

        /// <summary>
        ///     Returns a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">SSpecifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store from which data will be returned,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being returned.</param>
        /// <param name="data">Specifies a pointer to the location where buffer object data is returned.</param>
        public static void GetBufferSubData(BufferTarget target, int offset, int size, void* data) => _glGetBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data);

        /// <summary>
        ///     Returns a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">SSpecifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store from which data will be returned,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being returned.</param>
        /// <param name="data">Specifies a pointer to the location where buffer object data is returned.</param>
        public static void GetBufferSubData(BufferTarget target, long offset, long size, void* data) => _glGetBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data);

        /// <summary>
        ///     Map all or part of a buffer object's data store into the client's address space.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">Specifies the starting offset within the buffer of the range to be mapped.</param>
        /// <param name="length">Specifies the length of the range to be mapped.</param>
        /// <param name="access">Specifies a combination of access flags indicating the desired access to the mapped range.</param>
        /// <returns>A pointer to the beginning of the mapped range.</returns>
        public static IntPtr MapBufferRange(BufferTarget target, int offset, int length, BufferAccessMask access) => new IntPtr(_glMapBufferRange((int)target, new IntPtr(offset), new IntPtr(length), (uint)access));

        /// <summary>
        ///     Map all or part of a buffer object's data store into the client's address space.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">Specifies the starting offset within the buffer of the range to be mapped.</param>
        /// <param name="length">Specifies the length of the range to be mapped.</param>
        /// <param name="access">Specifies a combination of access flags indicating the desired access to the mapped range.</param>
        /// <returns>A pointer to the beginning of the mapped range.</returns>
        public static IntPtr MapBufferRange(BufferTarget target, long offset, long length, BufferAccessMask access) => new IntPtr(_glMapBufferRange((int)target, new IntPtr(offset), new IntPtr(length), (uint)access));

        /// <summary>
        ///     Indicate modifications to a range of a mapped buffer.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">Specifies the start of the buffer subrange, in basic machine units.</param>
        /// <param name="length">Specifies the length of the buffer subrange, in basic machine units.</param>
        public static void FlushMappedBufferRange(BufferTarget target, int offset, int length) => _glFlushMappedBufferRange((int)target, new IntPtr(offset), new IntPtr(length));

        /// <summary>
        ///     Indicate modifications to a range of a mapped buffer.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">Specifies the start of the buffer subrange, in basic machine units.</param>
        /// <param name="length">Specifies the length of the buffer subrange, in basic machine units.</param>
        public static void FlushMappedBufferRange(BufferTarget target, long offset, long length) => _glFlushMappedBufferRange((int)target, new IntPtr(offset), new IntPtr(length));

        /// <summary>
        ///     Attach a single layer of a texture to a framebuffer.
        /// </summary>
        /// <param name="target">
        ///     Specifies the framebuffer target.
        ///     <para>
        ///         Must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to
        ///         GL_DRAW_FRAMEBUFFER.
        ///     </para>
        /// </param>
        /// <param name="attachment">
        ///     Specifies the attachment point of the framebuffer.
        ///     <para>Must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT.</para>
        /// </param>
        /// <param name="texture">
        ///     Specifies the texture object to attach to the framebuffer attachment point named by
        ///     <paramref name="attachment" />.
        /// </param>
        /// <param name="level">Specifies the mipmap level of texture to attach.</param>
        /// <param name="layer">Specifies the layer of texture to attach.</param>
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, int texture, int level, int layer) => _glFramebufferTextureLayer((int)target, (int)attachment, (uint)texture, level, layer);

        /// <summary>
        ///     Bind a range within a buffer object to an indexed buffer target.
        /// </summary>
        /// <param name="target">
        ///     Specify the target of the bind operation
        ///     <para>
        ///         Must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, GL_UNIFORM_BUFFER, or
        ///         GL_SHADER_STORAGE_BUFFER.
        ///     </para>
        /// </param>
        /// <param name="index">Specify the index of the binding point within the array specified by target.</param>
        /// <param name="buffer">The name of a buffer object to bind to the specified binding point.</param>
        /// <param name="offset">The starting offset in basic machine units into the buffer object buffer.</param>
        /// <param name="size">
        ///     The amount of data in machine units that can be read from the buffer object while used as an indexed
        ///     target.
        /// </param>
        public static void BindBufferRange(BufferRangeTarget target, int index, int buffer, int offset, int size) => _glBindBufferRange((int)target, (uint)index, (uint)buffer, new IntPtr(offset), new IntPtr(size));

        /// <summary>
        ///     Bind a range within a buffer object to an indexed buffer target.
        /// </summary>
        /// <param name="target">
        ///     Specify the target of the bind operation
        ///     <para>
        ///         Must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, GL_UNIFORM_BUFFER, or
        ///         GL_SHADER_STORAGE_BUFFER.
        ///     </para>
        /// </param>
        /// <param name="index">Specify the index of the binding point within the array specified by target.</param>
        /// <param name="buffer">The name of a buffer object to bind to the specified binding point.</param>
        /// <param name="offset">The starting offset in basic machine units into the buffer object buffer.</param>
        /// <param name="size">
        ///     The amount of data in machine units that can be read from the buffer object while used as an indexed
        ///     target.
        /// </param>
        public static void BindBufferRange(BufferRangeTarget target, int index, int buffer, long offset, long size) => _glBindBufferRange((int)target, (uint)index, (uint)buffer, new IntPtr(offset), new IntPtr(size));

        /// <summary>
        ///     Copy a block of pixels from one framebuffer object to another.
        /// </summary>
        /// <param name="srcX0">The lower left corner of the read buffer on the x-axis.</param>
        /// <param name="srcY0">The lower left corner of the read buffer on the y-axis.</param>
        /// <param name="srcX1">The upper right corner of the read buffer on the x-axis.</param>
        /// <param name="srcY1">The upper right corner of the read buffer on the y-axis.</param>
        /// <param name="dstX0">The lower left corner of the write buffer on the x-axis.</param>
        /// <param name="dstY0">The lower left corner of the write buffer on the y-axis.</param>
        /// <param name="dstX1">The upper right corner of the write buffer on the x-axis.</param>
        /// <param name="dstY1">The upper right corner of the write buffer on the y-axis.</param>
        /// <param name="mask">The bitwise OR of the flags indicating which buffers are to be copied.<para>The allowed flags are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT and GL_STENCIL_BUFFER_BIT.</para></param>
        /// <param name="filter">Specifies the interpolation to be applied if the image is stretched.<para>Must be GL_NEAREST or GL_LINEAR.</para></param>
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter) => _glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (int)filter);

        /// <summary>
        /// Establish data storage, format and dimensions of a renderbuffer object's image.
        /// </summary>
        /// <param name="target">Specify the target of the bind operation.<para>Must be GL_RENDERBUFFER.</para></param>
        /// <param name="internalFormat">Specifies the internal format to use for the renderbuffer object's image.</param>
        /// <param name="width">Specifies the width of the renderbuffer, in pixels.</param>
        /// <param name="height">Specifies the height of the renderbuffer, in pixels.</param>
        public static void RenderbufferStorage(RenderbufferTarget target, RenderbufferStorage internalFormat, int width, int height) => _glRenderbufferStorage((int)target, (int)internalFormat, width, height);

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void ColorP3(PackedPointerType type, int color) => _glColorP3ui((int)type, (uint)color);

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void ColorP3(PackedPointerType type, /*const*/ int* color) => _glColorP3uiv((int)type, (uint*)color);

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void ColorP4(PackedPointerType type, int color) => _glColorP4ui((int)type, (uint)color);

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void ColorP4(PackedPointerType type, /*const*/ int* color) => _glColorP4uiv((int)type, (uint*)color);

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void ColorP3(PackedPointerType type, int[] color)
        {
            fixed (int* c = &color[0])
            {
                _glColorP3uiv((int)type, (uint*)c);
            }
        }

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void ColorP4(PackedPointerType type, int[] color)
        {
            fixed (int* c = &color[0])
            {
                _glColorP4uiv((int)type, (uint*)c);
            }
        }

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void SecondaryColorP3(PackedPointerType type, int color) => _glSecondaryColorP3ui((int)type, (uint)color);

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void SecondaryColorP3(PackedPointerType type, int[] color)
        {
            fixed (int* c = &color[0])
            {
                _glSecondaryColorP3uiv((int)type, (uint*)c);
            }
        }

        /// <summary>
        ///     Set the current color as a packed value.
        /// </summary>
        /// <param name="type">Specifies the data type of each color components.</param>
        /// <param name="color">The packed color value.</param>
        public static void SecondaryColorP3(PackedPointerType type, /*const*/ int* color) => _glSecondaryColorP3uiv((int)type, (uint*)color);

        /// <summary>
        ///     Updates a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store where data replacement will begin,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data">Specifies a pointer to the new data that will be copied into the data store.</param>
        public static void BufferSubData(BufferTarget target, int offset, int size, IntPtr data) => _glBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data.ToPointer());

        /// <summary>
        ///     Updates a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store where data replacement will begin,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data">Specifies a pointer to the new data that will be copied into the data store.</param>
        public static void BufferSubData(BufferTarget target, long offset, long size, IntPtr data) => _glBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data.ToPointer());


        /// <summary>
        ///     Updates a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store where data replacement will begin,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data">Specifies a pointer to the new data that will be copied into the data store.</param>
        public static void BufferSubData(BufferTarget target, int offset, int size, /*const*/ void* data) => _glBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data);

        /// <summary>
        ///     Updates a subset of a buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="offset">
        ///     Specifies the offset into the buffer object's data store where data replacement will begin,
        ///     measured in bytes.
        /// </param>
        /// <param name="size">Specifies the size in bytes of the data store region being replaced.</param>
        /// <param name="data">Specifies a pointer to the new data that will be copied into the data store.</param>
        public static void BufferSubData(BufferTarget target, long offset, long size, /*const*/ void* data) => _glBufferSubData((int)target, new IntPtr(offset), new IntPtr(size), data);

        /// <summary>
        ///     Set the current normal vector.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="coords">The coords.</param>
        public static void NormalP3(PackedPointerType type, int coords) => _glNormalP3ui((int)type, (uint)coords);

        /// <summary>
        ///     Set the current normal vector.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="coords">The coords.</param>
        public static void NormalP3(PackedPointerType type, /*const*/ int* coords) => _glNormalP3uiv((int)type, (uint*)coords);

        /// <summary>
        ///     Set the current normal vector.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="coords">The coords.</param>
        public static void NormalP3(PackedPointerType type, int[] coords)
        {
            fixed (int* c = &coords[0])
            {
                _glNormalP3uiv((int)type, (uint*)c);
            }
        }

        /// <summary>
        /// Bind a user-defined varying out variable to a fragment shader color number.
        /// </summary>
        /// <param name="program">The name of the program containing varying out variable whose binding to modify.</param>
        /// <param name="color">The color number to bind the user-defined varying out variable to.</param>
        /// <param name="name">The name of the user-defined varying out variable whose binding to modify.</param>
        public static void BindFragDataLocation(int program, int color, string name)
        {
            var utf8 = Encoding.UTF8.GetBytes(name);
            fixed (byte* b = &utf8[0])
            {
                _glBindFragDataLocation((uint)program, (uint)color, b);
            }
        }

        /// <summary>
        /// Query the bindings of color numbers to user-defined varying out variables.
        /// </summary>
        /// <param name="program">The name of the program containing varying out variable whose binding to query.</param>
        /// <param name="name">The name of the user-defined varying out variable whose binding to query.</param>
        /// <returns>The requested location, or <c>-1</c> if error occured.</returns>

        public static int GetFragDataLocation(int program, string name)
        {
            var utf8 = Encoding.UTF8.GetBytes(name);
            fixed (byte* b = &utf8[0])
            {
                return _glGetFragDataLocation((uint)program, b);
            }
        }

        /// <summary>
        /// Returns the location of an attribute variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">A string containing the name of the attribute variable whose location is to be queried.</param>
        /// <returns>The location of the attribute, or <c>-1</c> if an error occured.</returns>
        public static int GetAttribLocation(int program, string name)
        {
            var utf8 = Encoding.UTF8.GetBytes(name);
            fixed (byte* b = &utf8[0])
            {
                return _glGetAttribLocation((uint)program, b);
            }
        }

        /// <summary>
        /// Returns the handles of the shader objects attached to a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="maxCount">Specifies the size of the array for storing the returned object names.</param>
        /// <param name="count">Returns the number of names actually returned in shaders.</param>
        /// <param name="shaders">Specifies an array that is used to return the names of attached shader objects.</param>
        public static void GetAttachedShaders(int program, int maxCount, int* count, int* shaders) => _glGetAttachedShaders((uint)program, maxCount, count, (uint*)shaders);

        /// <summary>
        /// Returns the handles of the shader objects attached to a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="maxCount">Specifies the size of the array for storing the returned object names.</param>
        /// <returns>An array containing the attached shaders of the specified program.</returns>


        public static int[] GetAttachedShaders(int program, int maxCount)
        {
            int count;
            var shaders = new int[maxCount];
            fixed (int* shader = &shaders[0])
            {
                _glGetAttachedShaders((uint)program, maxCount, &count, (uint*)shader);
            }
            return count < maxCount ? shaders.Take(count).ToArray() : shaders;
        }

        /// <summary>
        /// Associates a generic vertex attribute index with a named attribute variable.
        /// </summary>
        /// <param name="program">Specifies the handle of the program object in which the association is to be made.</param>
        /// <param name="index">Specifies the index of the generic vertex attribute to be bound.</param>
        /// <param name="name">Specifies a string containing the name of the vertex shader attribute variable to which index is to be bound.</param>
        public static void BindAttribLocation(int program, int index, string name)
        {
            var utf8 = Encoding.UTF8.GetBytes(name);
            fixed (byte* b = &utf8[0])
            {
                _glBindAttribLocation((uint)program, (uint)index, b);
            }
        }

        /// <summary>
        /// Returns information about an active attribute variable for the specified program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the attribute variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string.</param>
        /// <param name="size">Returns the size of the attribute variable.</param>
        /// <param name="type">Returns the data type of the attribute variable.</param>
        /// <param name="name">The name of the attribute variable.</param>
        public static void GetActiveAttrib(int program, int index, int bufSize, out int length, out int size,
            out ActiveAttribType type, out string name)
        {
            var buffer = Marshal.AllocHGlobal(bufSize);
            try
            {
                int intType;
                _glGetActiveAttrib((uint)program, (uint)index, bufSize, out length, out size, out intType, buffer);
                type = (ActiveAttribType)intType;
                name = PtrToStringUtf8(buffer, length);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        public static string GetActiveAttrib(int program, int index, out int size, out ActiveAttribType type)
        {
            int length;
            unsafe
            {
                GetProgram(program, GetProgramParameterName.ActiveUniformMaxLength, &length);
            }

            string str;
            GetActiveAttrib(program, index, length == 0 ? 1 : length * 2, out length, out size, out type, out str);
            return str;
        }

        /// <summary>
        /// Returns information about an active uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="index">Specifies the index of the uniform variable to be queried.</param>
        /// <param name="bufSize">Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by name.</param>
        /// <param name="length">Returns the number of characters actually written by OpenGL in the string.</param>
        /// <param name="size">Returns the size of the uniform variable.</param>
        /// <param name="type">Returns the data type of the uniform variable.</param>
        /// <param name="name">Returns a string containing the name of the uniform variable.</param>
        public static void GetActiveUniform(int program, int index, int bufSize, out int length, out int size,
            out ActiveUniformType type, out string name)
        {
            var buffer = Marshal.AllocHGlobal(bufSize);
            try
            {
                int typeInt;
                _glGetActiveUniform((uint)program, (uint)index, bufSize, out length, out size, out typeInt, buffer);
                type = (ActiveUniformType)typeInt;
                name = PtrToStringUtf8(buffer, length);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            unsafe
            {
                GetProgram(program, GetProgramParameterName.ActiveUniformMaxLength, &length);
            }

            string str;
            ActiveUniformType intType;
            GetActiveUniform(program, uniformIndex, length == 0 ? 1 : length, out length, out size, out intType, out str);
            type = intType;
            return str;
        }

        /// <summary>
        /// Generate mipmaps for a specified texture object.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture object is bound.<para>Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP, or GL_TEXTURE_CUBE_MAP_ARRAY.</para></param>
        public static void GenerateMipmap(GenerateMipmapTarget target) => _glGenerateMipmap((int)target);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void glGetBoolean(int target, uint index, bool* data) => _glGetBooleani_v(target, index, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void glGetIntegeri_v(int target, uint index, int* data) => _glGetIntegeri_v(target, index, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <param name="data">Returns the value or values of the specified parameter.</param>
        public static void glGetInteger64i_v(int target, uint index, long* data) => _glGetInteger64i_v(target, index, data);

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <returns>The request parameter value.</returns>
        public static bool glGetBooleani(int target, uint index)
        {
            bool value;
            _glGetBooleani_v(target, index, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <returns>The request parameter value.</returns>
        public static int glGetIntegeri(int target, uint index)
        {
            int value;
            _glGetIntegeri_v(target, index, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <returns>The request parameter value.</returns>
        public static long glGetInteger64i(int target, uint index)
        {
            long value;
            _glGetInteger64i_v(target, index, &value);
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>

        public static bool[] glGetBooleani_v(int target, uint index, int count)
        {
            var value = new bool[count];
            fixed (bool* v = &value[0])
            {
                _glGetBooleani_v(target, index, v);
            }
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>

        public static int[] glGetIntegeri_v(int target, uint index, int count)
        {
            var value = new int[count];
            fixed (int* v = &value[0])
            {
                _glGetIntegeri_v(target, index, v);
            }
            return value;
        }

        /// <summary>
        /// Return the value or values of a selected parameter.
        /// </summary>
        /// <param name="target">Specifies the parameter value to be returned.</param>
        /// <param name="index">Specifies the index of the particular element being queried.</param>
        /// <param name="count">The number of values to get.</param>
        /// <returns>The request parameter value.</returns>

        public static long[] glGetInteger64i_v(int target, uint index, int count)
        {
            var value = new long[count];
            fixed (long* v = &value[0])
            {
                _glGetInteger64i_v(target, index, v);
            }
            return value;
        }

        /// <summary>
        ///     Determine if a name corresponds to a vertex array object.
        /// </summary>
        /// <param name="array">Specifies a value that may be the name of a vertex array object.</param>
        /// <returns><c>true</c> if value is a vertex array, otherwise <c>false</c>.</returns>
        public static bool glIsVertexArray(uint array) => _glIsVertexArray(array);

        /// <summary>
        ///     Generate vertex array object names.
        /// </summary>
        /// <param name="n">Specifies the number of vertex array object names to generate.</param>
        /// <param name="arrays">Specifies an array in which the generated vertex array object names are stored.</param>
        public static void glGenVertexArrays(int n, uint* arrays) => _glGenVertexArrays(n, arrays);

        /// <summary>
        ///     Generate vertex array object names.
        /// </summary>
        /// <param name="n">Specifies the number of vertex array object names to generate.</param>
        /// <returns>An array of generated vertex array object names.</returns>


        public static uint[] glGenVertexArrays(int n)
        {
            var arrays = new uint[n];
            fixed (uint* names = &arrays[0])
            {
                _glGenVertexArrays(n, names);
            }

            return arrays;
        }

        /// <summary>
        ///     Generates a single vertex array object name.
        /// </summary>
        /// <returns>A generated vertex array name.</returns>

        public static int GenVertexArray()
        {
            int array;
            _glGenVertexArrays(1, (uint*)&array);
            return array;
        }

        /// <summary>
        ///     Bind a vertex array object.
        /// </summary>
        /// <param name="array">Specifies the name of the vertex array to bind.</param>
        public static void BindVertexArray(int array) => _glBindVertexArray((uint)array);

        /// <summary>
        ///     Delete vertex array objects.
        /// </summary>
        /// <param name="n">Specifies the number of vertex array objects to be deleted.</param>
        /// <param name="arrays">Specifies the address of an array containing the n names of the objects to be deleted.</param>
        public static void glDeleteVertexArrays(int n, /*const*/ uint* arrays) => _glDeleteVertexArrays(n, arrays);

        /// <summary>
        ///     Delete vertex array objects.
        /// </summary>
        /// <param name="arrays">An array of vertex array objects to delete.</param>
        public static void glDeleteVertexArrays(uint[] arrays)
        {
            if (arrays is null)
                return;
            fixed (uint* names = &arrays[0])
            {
                _glDeleteVertexArrays(arrays.Length, names);
            }
        }

        /// <summary>
        ///     Deletes a single vertex array object.
        /// </summary>
        /// <param name="array">The array to delete.</param>
        public static void DeleteVertexArray(int array) => _glDeleteVertexArrays(1, (uint*)&array);

        /// <summary>
        /// Specify point parameters.
        /// </summary>
        /// <param name="paramName">Specifies a single-valued point parameter.<para>GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.</para></param>
        /// <param name="param">Specifies the value that paramName will be set to.</param>
        public static void glPointParameterf(int paramName, float param) => _glPointParameterf(paramName, param);

        /// <summary>
        /// Specify point parameters.
        /// </summary>
        /// <param name="paramName">Specifies a single-valued point parameter.<para>GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.</para></param>
        /// <param name="param">Specifies the value that paramName will be set to.</param>
        public static void glPointParameteri(int paramName, int param) => _glPointParameteri(paramName, param);

        /// <summary>
        /// Specify point parameters.
        /// </summary>
        /// <param name="paramName">Specifies a single-valued point parameter.<para>GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.</para></param>
        /// <param name="args">A pointer to an array where the value or values to be assigned to paramName are stored.</param>
        public static void glPointParameterfv(int paramName, /*const*/ float* args) => _glPointParameterfv(paramName, args);

        /// <summary>
        /// Specify point parameters.
        /// </summary>
        /// <param name="paramName">Specifies a single-valued point parameter.<para>GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.</para></param>
        /// <param name="args">A pointer to an array where the value or values to be assigned to paramName are stored.</param>
        public static void glPointParameteriv(int paramName, /*const*/ int* args) => _glPointParameteriv(paramName, args);

        /// <summary>
        /// Specify point parameters.
        /// </summary>
        /// <param name="paramName">Specifies a single-valued point parameter.<para>GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.</para></param>
        /// <param name="args">An array of the values to be assigned.</param>
        public static void glPointParameterfv(int paramName, float[] args)
        {
            fixed (float* a = &args[0])
            {
                _glPointParameterfv(paramName, a);
            }
        }

        /// <summary>
        /// Specify point parameters.
        /// </summary>
        /// <param name="paramName">Specifies a single-valued point parameter.<para>GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.</para></param>
        /// <param name="args">An array of the values to be assigned.</param>
        public static void glPointParameteriv(int paramName, int[] args)
        {
            fixed (int* a = &args[0])
            {
                _glPointParameteriv(paramName, a);
            }
        }

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameteri(uint sampler, int paramName, int param) => _glSamplerParameteri(sampler, paramName, param);

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameterf(uint sampler, int paramName, float param) => _glSamplerParameterf(sampler, paramName, param);

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameteriv(uint sampler, int paramName, int[] param)
        {
            fixed (int* p = &param[0])
            {
                _glSamplerParameteriv(sampler, paramName, p);
            }
        }

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameterfv(uint sampler, int paramName, float[] param)
        {
            fixed (float* p = &param[0])
            {
                _glSamplerParameterfv(sampler, paramName, p);
            }
        }

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameteriv(uint sampler, int paramName, /*const*/ int* param) => _glSamplerParameteriv(sampler, paramName, param);

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameterfv(uint sampler, int paramName, /*const*/ float* param) => _glSamplerParameterfv(sampler, paramName, param);

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameterIiv(uint sampler, int paramName, /*const*/ int* param) => _glSamplerParameterIiv(sampler, paramName, param);

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameterIuiv(uint sampler, int paramName, /*const*/ uint* param) => _glSamplerParameterIuiv(sampler, paramName, param);

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameterIiv(uint sampler, int paramName, int[] param)
        {
            fixed (int* p = &param[0])
            {
                _glSamplerParameterIiv(sampler, paramName, p);
            }
        }

        /// <summary>
        ///     Set sampler parameters.
        /// </summary>
        /// <param name="sampler">Specifies the sampler object whose parameter to modify.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="param">The value to set.</param>
        public static void glSamplerParameterIuiv(uint sampler, int paramName, uint[] param)
        {
            fixed (uint* p = &param[0])
            {
                _glSamplerParameterIuiv(sampler, paramName, p);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The value.</param>
        public static void Uniform1(int location, float v0) => _glUniform1f(location, v0);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        public static void Uniform2(int location, float v0, float v1) => _glUniform2f(location, v0, v1);

        public static void Uniform2(int location, Vector2 vector)
        {
            Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        /// <param name="v2">The third value.</param>
        public static void Uniform3(int location, float v0, float v1, float v2) => _glUniform3f(location, v0, v1, v2);

        public static void Uniform3(int location, Vector3 vector)
        {
            Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        /// <param name="v2">The third value.</param>
        /// <param name="v3">The fourth value.</param>
        public static void Uniform4(int location, float v0, float v1, float v2, float v3) => _glUniform4f(location, v0, v1, v2, v3);

        public static void Uniform4(int location, Vector4 vector)
        {
            Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform4(int location, Color4 color)
        {
            Uniform4(location, color.R, color.G, color.B, color.A);
        }

        public static void Uniform4(int location, Quaternion quaternion)
        {
            Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        public static void Uniform1(int location, uint v0) => _glUniform1ui(location, v0);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        public static void Uniform2(int location, uint v0, uint v1) => _glUniform2ui(location, v0, v1);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        /// <param name="v2">The third value.</param>
        public static void Uniform3(int location, uint v0, uint v1, uint v2) => _glUniform3ui(location, v0, v1, v2);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        /// <param name="v2">The third value.</param>
        /// <param name="v3">The fourth value.</param>
        public static void Uniform4(int location, uint v0, uint v1, uint v2, uint v3) => _glUniform4ui(location, v0, v1, v2, v3);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        public static void Uniform1(int location, int v0) => _glUniform1i(location, v0);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        public static void Uniform2(int location, int v0, int v1) => _glUniform2i(location, v0, v1);

        public static void Uniform2(int location, Vector2i vector)
        {
            Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        /// <param name="v2">The third value.</param>
        public static void Uniform3(int location, int v0, int v1, int v2) => _glUniform3i(location, v0, v1, v2);

        public static void Uniform3(int location, Vector3i vector)
        {
            Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="v0">The first value.</param>
        /// <param name="v1">The second value.</param>
        /// <param name="v2">The third value.</param>
        /// <param name="v3">The fourth value.</param>
        public static void Uniform4(int location, int v0, int v1, int v2, int v3) => _glUniform4i(location, v0, v1, v2, v3);

        public static void Uniform4(int location, Vector4i vector)
        {
            Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform1(int location, int count, /*const*/ float* value) => _glUniform1fv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform2(int location, int count, /*const*/ float* value) => _glUniform2fv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform3(int location, int count, /*const*/ float* value) => _glUniform3fv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform4(int location, int count, /*const*/ float* value) => _glUniform4fv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform1(int location, int count, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glUniform1fv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform2(int location, int count, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glUniform2fv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform3(int location, int count, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glUniform3fv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform4(int location, int count, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glUniform4fv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform1(int location, int count, /*const*/ int* value) => _glUniform1iv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform2(int location, int count, /*const*/ int* value) => _glUniform2iv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform3(int location, int count, /*const*/ int* value) => _glUniform3iv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform4(int location, int count, /*const*/ int* value) => _glUniform4iv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform1(int location, int count, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glUniform1iv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform2(int location, int count, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glUniform2iv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform3(int location, int count, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glUniform3iv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform4(int location, int count, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glUniform4iv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform1(int location, int count, /*const*/ uint* value) => _glUniform1uiv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform2(int location, int count, /*const*/ uint* value) => _glUniform2uiv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform3(int location, int count, /*const*/ uint* value) => _glUniform3uiv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform4(int location, int count, /*const*/ uint* value) => _glUniform4uiv(location, count, value);

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform1(int location, int count, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glUniform1uiv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform2(int location, int count, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glUniform2uiv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform3(int location, int count, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glUniform3uiv(location, count, v);
            }
        }

        /// <summary>
        ///     Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform value to be modified.</param>
        /// <param name="count">Specifies the number of elements that are to be modified.</param>
        /// <param name="value">The values to set.</param>
        public static void Uniform4(int location, int count, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glUniform4uiv(location, count, v);
            }
        }

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP1ui(int texture, int type, uint coords) => _glMultiTexCoordP1ui(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP2ui(int texture, int type, uint coords) => _glMultiTexCoordP2ui(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP3ui(int texture, int type, uint coords) => _glMultiTexCoordP3ui(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP4ui(int texture, int type, uint coords) => _glMultiTexCoordP4ui(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP1uiv(int texture, int type, /*const*/ uint* coords) => _glMultiTexCoordP1uiv(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP2uiv(int texture, int type, /*const*/ uint* coords) => _glMultiTexCoordP2uiv(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP3uiv(int texture, int type, /*const*/ uint* coords) => _glMultiTexCoordP3uiv(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP4uiv(int texture, int type, /*const*/ uint* coords) => _glMultiTexCoordP4uiv(texture, type, coords);

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP1uiv(int texture, int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glMultiTexCoordP1uiv(texture, type, c);
            }
        }

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP2uiv(int texture, int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glMultiTexCoordP2uiv(texture, type, c);
            }
        }

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP3uiv(int texture, int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glMultiTexCoordP3uiv(texture, type, c);
            }
        }

        /// <summary>
        ///     Set the current texture coordinates.
        /// </summary>
        /// <param name="texture">
        ///     Specifies the texture unit whose coordinates should be modified.
        ///     <para>
        ///         The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be
        ///         one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent
        ///         value.
        ///     </para>
        /// </param>
        /// <param name="type">The data type.</param>
        /// <param name="coords">The value of the coordinates to set.</param>
        public static void glMultiTexCoordP4uiv(int texture, int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glMultiTexCoordP4uiv(texture, type, c);
            }
        }

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">A packed value.</param>
        public static void glTexCoordP1ui(int type, uint coords) => _glTexCoordP1ui(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">Specifies a pointer to an array of packed elements.</param>
        public static void glTexCoordP1uiv(int type, /*const*/ uint* coords) => _glTexCoordP1uiv(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">An array of packed elements.</param>
        public static void glTexCoordP1uiv(int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glTexCoordP1uiv(type, c);
            }
        }

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">A packed value.</param>
        public static void glTexCoordP2ui(int type, uint coords) => _glTexCoordP2ui(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">An array of packed elements.</param>
        public static void glTexCoordP2uiv(int type, /*const*/ uint* coords) => _glTexCoordP2uiv(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">An array of packed elements.</param>
        public static void glTexCoordP2uiv(int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glTexCoordP2uiv(type, c);
            }
        }

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">A packed value.</param>
        public static void glTexCoordP3ui(int type, uint coords) => _glTexCoordP3ui(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">An array of packed elements.</param>
        public static void glTexCoordP3uiv(int type, /*const*/ uint* coords) => _glTexCoordP3uiv(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">An array of packed elements.</param>
        public static void glTexCoordP3uiv(int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glTexCoordP3uiv(type, c);
            }
        }

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">A packed value.</param>
        public static void glTexCoordP4ui(int type, uint coords) => _glTexCoordP4ui(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">An array of packed elements.</param>
        public static void glTexCoordP4uiv(int type, /*const*/ uint* coords) => _glTexCoordP4uiv(type, coords);

        /// <summary>
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="type">Specifies the texture unit whose coordinates should be modified.<para>The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTUREi, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.</para></param>
        /// <param name="coords">An array of packed elements.</param>
        public static void glTexCoordP4uiv(int type, uint[] coords)
        {
            fixed (uint* c = &coords[0])
            {
                _glTexCoordP4uiv(type, c);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The value.</param>
        public static void VertexAttrib1(int index, double x) => _glVertexAttrib1d((uint)index, x);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The value.</param>
        public static void VertexAttrib1(int index, float x) => _glVertexAttrib1f((uint)index, x);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The value.</param>
        public static void VertexAttrib1(int index, short x) => _glVertexAttrib1s((uint)index, x);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        public static void VertexAttrib2(int index, double x, double y) => _glVertexAttrib2d((uint)index, x, y);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        public static void VertexAttrib2(int index, float x, float y) => _glVertexAttrib2f((uint)index, x, y);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        public static void VertexAttrib2(int index, short x, short y) => _glVertexAttrib2s((uint)index, x, y);

        public static void VertexAttrib2(int index, Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        public static void VertexAttrib3(int index, double x, double y, double z) => _glVertexAttrib3d((uint)index, x, y, z);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        public static void VertexAttrib3(int index, float x, float y, float z) => _glVertexAttrib3f((uint)index, x, y, z);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        public static void VertexAttrib3(int index, short x, short y, short z) => _glVertexAttrib3s((uint)index, x, y, z);

        public static void VertexAttrib3(int index, Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <param name="w">The fourth value.</param>
        public static void VertexAttrib4(int index, byte x, byte y, byte z, byte w) => _glVertexAttrib4Nub((uint)index, x, y, z, w);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <param name="w">The fourth value.</param>
        public static void VertexAttrib4(int index, double x, double y, double z, double w) => _glVertexAttrib4d((uint)index, x, y, z, w);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <param name="w">The fourth value.</param>
        public static void VertexAttrib4(int index, float x, float y, float z, float w) => _glVertexAttrib4f((uint)index, x, y, z, w);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <param name="w">The fourth value.</param>
        public static void VertexAttrib4(int index, short x, short y, short z, short w) => _glVertexAttrib4s((uint)index, x, y, z, w);

        public static void VertexAttrib4(int index, Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        ///     Disable a generic vertex attribute array.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be disabled.</param>
        public static void glDisableVertexAttribArray(uint index) => _glDisableVertexAttribArray(index);

        /// <summary>
        ///     Enable a generic vertex attribute array.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be disabled.</param>
        public static void EnableVertexAttribArray(int index) => _glEnableVertexAttribArray((uint)index);

        /// <summary>
        ///     Specify the primitive restart index.
        /// </summary>
        /// <param name="index">Specifies the value to be interpreted as the primitive restart index.</param>
        public static void glPrimitiveRestartIndex(uint index) => _glPrimitiveRestartIndex(index);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib1dv(uint index, /*const*/ double* v) => _glVertexAttrib1dv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib1fv(uint index, /*const*/ float* v) => _glVertexAttrib1fv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib1sv(uint index, /*const*/ short* v) => _glVertexAttrib1sv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib2dv(uint index, /*const*/ double* v) => _glVertexAttrib2dv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib2fv(uint index, /*const*/ float* v) => _glVertexAttrib2fv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib2sv(uint index, /*const*/ short* v) => _glVertexAttrib2sv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib3dv(uint index, /*const*/ double* v) => _glVertexAttrib3dv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib3fv(uint index, /*const*/ float* v) => _glVertexAttrib3fv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib3sv(uint index, /*const*/ short* v) => _glVertexAttrib3sv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4bv(uint index, /*const*/ sbyte* v) => _glVertexAttrib4bv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4dv(uint index, /*const*/ double* v) => _glVertexAttrib4dv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4fv(uint index, /*const*/ float* v) => _glVertexAttrib4fv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4iv(uint index, /*const*/ int* v) => _glVertexAttrib4iv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4sv(uint index, /*const*/ short* v) => _glVertexAttrib4sv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4ubv(uint index, /*const*/ byte* v) => _glVertexAttrib4ubv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4uiv(uint index, /*const*/ uint* v) => _glVertexAttrib4uiv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        public static void glVertexAttrib4usv(uint index, /*const*/ ushort* v) => _glVertexAttrib4usv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib1dv(uint index, double[] value)
        {
            fixed (double* v = &value[0])
            {
                _glVertexAttrib1dv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib1fv(uint index, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glVertexAttrib1fv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib1sv(uint index, short[] value)
        {
            fixed (short* v = &value[0])
            {
                _glVertexAttrib1sv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib2dv(uint index, double[] value)
        {
            fixed (double* v = &value[0])
            {
                _glVertexAttrib2dv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib2fv(uint index, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glVertexAttrib2fv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib2sv(uint index, short[] value)
        {
            fixed (short* v = &value[0])
            {
                _glVertexAttrib2sv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib3dv(uint index, double[] value)
        {
            fixed (double* v = &value[0])
            {
                _glVertexAttrib3dv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib3fv(uint index, float[] value)
        {
            fixed (float* v = &value[0])
            {
                _glVertexAttrib3fv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib3sv(uint index, short[] value)
        {
            fixed (short* v = &value[0])
            {
                _glVertexAttrib3sv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4bv(uint index, sbyte[] value)
        {
            fixed (sbyte* v = &value[0])
            {
                _glVertexAttrib4bv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4dv(uint index, double[] value)
        {
            fixed (double* v = &value[0])
            {
                _glVertexAttrib4dv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4fv(uint index, float[] value)

        {
            fixed (float* v = &value[0])
            {
                _glVertexAttrib4fv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4iv(uint index, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glVertexAttrib4iv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4sv(uint index, short[] value)
        {
            fixed (short* v = &value[0])
            {
                _glVertexAttrib4sv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4ubv(uint index, byte[] value)
        {
            fixed (byte* v = &value[0])
            {
                _glVertexAttrib4ubv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4uiv(uint index, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttrib4uiv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexAttrib4usv(uint index, ushort[] value)
        {
            fixed (ushort* v = &value[0])
            {
                _glVertexAttrib4usv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nbv(uint index, /*const*/ sbyte* v) => _glVertexAttrib4Nbv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Niv(uint index, /*const*/ int* v) => _glVertexAttrib4Niv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nsv(uint index, /*const*/ short* v) => _glVertexAttrib4Nsv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nubv(uint index, /*const*/ byte* v) => _glVertexAttrib4Nubv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nuiv(uint index, /*const*/ uint* v) => _glVertexAttrib4Nuiv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nusv(uint index, /*const*/ ushort* v) => _glVertexAttrib4Nusv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nbv(uint index, sbyte[] value)
        {
            fixed (sbyte* v = &value[0])
            {
                _glVertexAttrib4Nbv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Niv(uint index, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glVertexAttrib4Niv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nsv(uint index, short[] value)
        {
            fixed (short* v = &value[0])
            {
                _glVertexAttrib4Nsv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nubv(uint index, byte[] value)
        {
            fixed (byte* v = &value[0])
            {
                _glVertexAttrib4Nubv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nuiv(uint index, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttrib4Nuiv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be scaled to normalized values.</remarks>
        public static void glVertexAttrib4Nusv(uint index, ushort[] value)
        {
            fixed (ushort* v = &value[0])
            {
                _glVertexAttrib4Nusv(index, v);
            }
        }

        /// <summary>
        ///     Define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">
        ///     Specifies the number of components per generic vertex attribute.
        ///     <para>Must be 1, 2, 3, 4, or <see cref="GL_BGRA" />.</para>
        /// </param>
        /// <param name="type">Specifies the data type of each component in the array.</param>
        /// <param name="normalized">
        ///     Specifies whether fixed-point data values should be normalized (true) or converted directly as
        ///     fixed-point values (false) when they are accessed.
        /// </param>
        /// <param name="stride">
        ///     Specifies the byte offset between consecutive generic vertex attributes.
        ///     <para>If stride is 0, the generic vertex attributes are understood to be tightly packed in the array.</para>
        /// </param>
        /// <param name="pointer">
        ///     Specifies a offset of the first component of the first generic vertex attribute in the array in
        ///     the data store of the buffer currently bound to the GL_ARRAY_BUFFER target.
        /// </param>
        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, /*const*/void* pointer) => _glVertexAttribPointer((uint)index, size, (int)type, normalized, stride, pointer);

        /// <summary>
        ///     Define an array of generic vertex attribute data
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">
        ///     Specifies the number of components per generic vertex attribute.
        ///     <para>Must be 1, 2, 3, 4, or <see cref="GL_BGRA" />.</para>
        /// </param>
        /// <param name="type">Specifies the data type of each component in the array.</param>
        /// <param name="normalized">
        ///     Specifies whether fixed-point data values should be normalized (true) or converted directly as
        ///     fixed-point values (false) when they are accessed.
        /// </param>
        /// <param name="stride">
        ///     Specifies the byte offset between consecutive generic vertex attributes.
        ///     <para>If stride is 0, the generic vertex attributes are understood to be tightly packed in the array.</para>
        /// </param>
        /// <param name="pointer">
        ///     Specifies a offset of the first component of the first generic vertex attribute in the array in
        ///     the data store of the buffer currently bound to the GL_ARRAY_BUFFER target.
        /// </param>
        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer) => _glVertexAttribPointer((uint)index, size, (int)type, normalized, stride, pointer.ToPointer());

        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="count">The number of elements in the sampler parameters.</param>
        /// <returns>An array of the sampler parameter values.</returns>


        public static int[] glGetSamplerParameteriv(uint sampler, int paramName, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetSamplerParameteriv(sampler, paramName, args);
            }

            return values;
        }

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="count">The number of elements in the sampler parameters.</param>
        /// <returns>An array of the sampler parameter values.</returns>
        /// <remarks>Values are interpreted as fully signed or unsigned.</remarks>


        public static int[] glGetSamplerParameterIiv(uint sampler, int paramName, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetSamplerParameterIiv(sampler, paramName, args);
            }

            return values;
        }

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="count">The number of elements in the sampler parameters.</param>
        /// <returns>An array of the sampler parameter values.</returns>


        public static float[] glGetSamplerParameterfv(uint sampler, int paramName, int count)
        {
            var values = new float[count];
            fixed (float* args = &values[0])
            {
                _glGetSamplerParameterfv(sampler, paramName, args);
            }

            return values;
        }

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="count">The number of elements in the sampler parameters.</param>
        /// <returns>An array of the sampler parameter values.</returns>
        /// <remarks>Values are interpreted as fully signed or unsigned.</remarks>


        public static uint[] GetSamplerParameterIuiv(uint sampler, int paramName, int count)
        {
            var values = new uint[count];
            fixed (uint* args = &values[0])
            {
                _glGetSamplerParameterIuiv(sampler, paramName, args);
            }

            return values;
        }

        /// <summary>
        ///     Return a single sampler parameter value.
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <returns>An single sampler parameter values.</returns>

        public static int glGetSamplerParameteriv(uint sampler, int paramName)
        {
            int value;
            _glGetSamplerParameteriv(sampler, paramName, &value);
            return value;
        }

        /// <summary>
        ///     Return a single sampler parameter value.
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <returns>An single sampler parameter values.</returns>
        /// <remarks>Values are interpreted as fully signed or unsigned.</remarks>

        public static int glGetSamplerParameterIiv(uint sampler, int paramName)
        {
            int value;
            _glGetSamplerParameterIiv(sampler, paramName, &value);
            return value;
        }

        /// <summary>
        ///     Return a single sampler parameter value.
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <returns>An single sampler parameter values.</returns>

        public static float glGetSamplerParameterfv(uint sampler, int paramName)
        {
            float value;
            _glGetSamplerParameterfv(sampler, paramName, &value);
            return value;
        }

        /// <summary>
        ///     Return a single sampler parameter value.
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <returns>An single sampler parameter values.</returns>
        /// <remarks>Values are interpreted as fully signed or unsigned.</remarks>

        public static uint GetSamplerParameterIui(uint sampler, int paramName)
        {
            uint value;
            _glGetSamplerParameterIuiv(sampler, paramName, &value);
            return value;
        }

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="args">Returns the sampler parameters.</param>
        public static void glGetSamplerParameteriv(uint sampler, int paramName, int* args) => _glGetSamplerParameteriv(sampler, paramName, args);

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="args">Returns the sampler parameters.</param>
        public static void glGetSamplerParameterIiv(uint sampler, int paramName, int* args) => _glGetSamplerParameterIiv(sampler, paramName, args);

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="args">Returns the sampler parameters.</param>
        public static void glGetSamplerParameterfv(uint sampler, int paramName, float* args) => _glGetSamplerParameterfv(sampler, paramName, args);

        /// <summary>
        ///     Return sampler parameter value(s).
        /// </summary>
        /// <param name="sampler">Specifies name of the sampler object from which to retrieve parameters.</param>
        /// <param name="paramName">Specifies the symbolic name of a sampler parameter.</param>
        /// <param name="args">Returns the sampler parameters.</param>
        public static void glGetSamplerParameterIuiv(uint sampler, int paramName, uint* args) => _glGetSamplerParameterIuiv(sampler, paramName, args);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI1i(uint index, int x) => _glVertexAttribI1i(index, x);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI1ui(uint index, uint x) => _glVertexAttribI1ui(index, x);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI2i(uint index, int x, int y) => _glVertexAttribI2i(index, x, y);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI2ui(uint index, uint x, uint y) => _glVertexAttribI2ui(index, x, y);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI3i(uint index, int x, int y, int z) => _glVertexAttribI3i(index, x, y, z);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z) => _glVertexAttribI3ui(index, x, y, z);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <param name="w">The fourth value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4i(uint index, int x, int y, int z, int w) => _glVertexAttribI4i(index, x, y, z, w);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="x">The first value.</param>
        /// <param name="y">The second value.</param>
        /// <param name="z">The third value.</param>
        /// <param name="w">The fourth value.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => _glVertexAttribI4ui(index, x, y, z, w);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI1iv(uint index, /*const*/ int* v) => _glVertexAttribI1iv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI1uiv(uint index, /*const*/ uint* v) => _glVertexAttribI1uiv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI2iv(uint index, /*const*/ int* v) => _glVertexAttribI2iv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI2uiv(uint index, /*const*/ uint* v) => _glVertexAttribI2uiv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI3iv(uint index, /*const*/ int* v) => _glVertexAttribI3iv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI3uiv(uint index, /*const*/ uint* v) => _glVertexAttribI3uiv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4iv(uint index, /*const*/ int* v) => _glVertexAttribI4iv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4uiv(uint index, /*const*/ uint* v) => _glVertexAttribI4uiv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4bv(uint index, /*const*/ sbyte* v) => _glVertexAttribI4bv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4sv(uint index, /*const*/ short* v) => _glVertexAttribI4sv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4ubv(uint index, /*const*/ byte* v) => _glVertexAttribI4ubv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="v">A pointer to the vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4usv(uint index, /*const*/ ushort* v) => _glVertexAttribI4usv(index, v);

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI1iv(uint index, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glVertexAttribI1iv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI1uiv(uint index, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribI1uiv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI2iv(uint index, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glVertexAttribI2iv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI2uiv(uint index, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribI2uiv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI3iv(uint index, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glVertexAttribI3iv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI3uiv(uint index, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribI3uiv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4iv(uint index, int[] value)
        {
            fixed (int* v = &value[0])
            {
                _glVertexAttribI4iv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4uiv(uint index, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribI4uiv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4bv(uint index, sbyte[] value)
        {
            fixed (sbyte* v = &value[0])
            {
                _glVertexAttribI4bv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4sv(uint index, short[] value)
        {
            fixed (short* v = &value[0])
            {
                _glVertexAttribI4sv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4ubv(uint index, byte[] value)
        {
            fixed (byte* v = &value[0])
            {
                _glVertexAttribI4ubv(index, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="value">The vertex data.</param>
        /// <remarks>Values will be extended to fully signed or unsigned integers.</remarks>
        public static void glVertexAttribI4usv(uint index, ushort[] value)
        {
            fixed (ushort* v = &value[0])
            {
                _glVertexAttribI4usv(index, v);
            }
        }

        /// <summary>
        ///     Modify the rate at which generic vertex attributes advance during instanced rendering.
        /// </summary>
        /// <param name="index">Specify the index of the generic vertex attribute.</param>
        /// <param name="divisor">
        ///     Specify the number of instances that will pass between updates of the generic attribute at slot
        ///     <paramref name="index" />.
        /// </param>
        public static void glVertexAttribDivisor(uint index, uint divisor) => _glVertexAttribDivisor(index, divisor);

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">A pointer to the vertex data.</param>
        public static void glVertexP2uiv(int type, /*const*/ uint* value) => _glVertexP2uiv(type, value);

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">A pointer to the vertex data.</param>
        public static void glVertexP3uiv(int type, /*const*/ uint* value) => _glVertexP3uiv(type, value);

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">A pointer to the vertex data.</param>
        public static void glVertexP4uiv(int type, /*const*/ uint* value) => _glVertexP4uiv(type, value);

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">A array of vertex data.</param>
        public static void glVertexP2uiv(int type, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexP2uiv(type, v);
            }
        }

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">A array of vertex data.</param>
        public static void glVertexP3uiv(int type, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexP3uiv(type, v);
            }
        }

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">A array of vertex data.</param>
        public static void glVertexP4uiv(int type, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexP4uiv(type, v);
            }
        }

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexP2ui(int type, uint value) => _glVertexP2ui(type, value);

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexP3ui(int type, uint value) => _glVertexP3ui(type, value);

        /// <summary>
        ///     Specified a packed vertex.
        /// </summary>
        /// <param name="type">Specify the vertex data type.</param>
        /// <param name="value">The vertex data.</param>
        public static void glVertexP4ui(int type, uint value) => _glVertexP4ui(type, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">A pointer to the new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP1uiv(uint index, int type, bool normalized, /*const*/ uint* value) => _glVertexAttribP1uiv(index, type, normalized, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">A pointer to the new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP2uiv(uint index, int type, bool normalized, /*const*/ uint* value) => _glVertexAttribP2uiv(index, type, normalized, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">A pointer to the new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP3uiv(uint index, int type, bool normalized, /*const*/ uint* value) => _glVertexAttribP3uiv(index, type, normalized, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">A pointer to the new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP4uiv(uint index, int type, bool normalized, /*const*/ uint* value) => _glVertexAttribP4uiv(index, type, normalized, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">The new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP1uiv(uint index, int type, bool normalized, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribP1uiv(index, type, normalized, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">The new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP2uiv(uint index, int type, bool normalized, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribP2uiv(index, type, normalized, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">The new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP3uiv(uint index, int type, bool normalized, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribP3uiv(index, type, normalized, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">The new packed values to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP4uiv(uint index, int type, bool normalized, uint[] value)
        {
            fixed (uint* v = &value[0])
            {
                _glVertexAttribP4uiv(index, type, normalized, v);
            }
        }

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">Specifies the new packed value to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP1ui(uint index, int type, bool normalized, uint value) => _glVertexAttribP1ui(index, type, normalized, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">Specifies the new packed value to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP2ui(uint index, int type, bool normalized, uint value) => _glVertexAttribP2ui(index, type, normalized, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">Specifies the new packed value to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP3ui(uint index, int type, bool normalized, uint value) => _glVertexAttribP3ui(index, type, normalized, value);

        /// <summary>
        ///     Specifies the value of a generic packed vertex attribute.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="type">Specifies the type of packing used on the data.</param>
        /// <param name="normalized">
        ///     <c>true</c>  values are to be converted to floating point values by normalizing.
        ///     <para>
        ///         Otherwise, they are converted directly to floating-point values. If type indicates a floating-point format,
        ///         then normalized value must be <c>false</c>.
        ///     </para>
        /// </param>
        /// <param name="value">Specifies the new packed value to be used for the specified vertex attribute.</param>
        public static void glVertexAttribP4ui(uint index, int type, bool normalized, uint value) => _glVertexAttribP4ui(index, type, normalized, value);


        /// <summary>
        ///     Attach a buffer object's data store to a buffer texture object
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound.<para>Must be GL_TEXTURE_BUFFER.</para></param>
        /// <param name="internalFormat">Specifies the internal format of the data in the store belonging to buffer.</param>
        /// <param name="buffer">Specifies the name of the buffer object whose storage to attach to the active buffer texture.</param>
        public static void glTexBuffer(int target, int internalFormat, uint buffer) => _glTexBuffer(target, internalFormat, buffer);

        /// <summary>
        /// Query information about an active uniform block.
        /// </summary>
        /// <param name="program">Specifies the name of a program containing the uniform block.</param>
        /// <param name="uniformBlockIndex">Specifies the index of the uniform block within program.</param>
        /// <param name="pname">Specifies the name of the parameter to query.</param>
        /// <param name="args">Specifies the address of a variable to receive the result of the query.</param>
        public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, int pname, int* args) => _glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, args);

        /// <summary>
        /// Query information about an active uniform block.
        /// </summary>
        /// <param name="program">Specifies the name of a program containing the uniform block.</param>
        /// <param name="uniformBlockIndex">Specifies the index of the uniform block within program.</param>
        /// <param name="pname">Specifies the name of the parameter to query.</param>
        /// <param name="count">Specifies the number of values to receive.</param>


        public static int[] glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Retrieve the name of an active uniform block.
        /// </summary>
        /// <param name="program">Specifies the name of a program containing the uniform block.</param>
        /// <param name="uniformBlockIndex">Specifies the index of the uniform block within program.</param>
        /// <param name="bufSize">Specifies the size of the buffer addressed by uniformBlockName.</param>
        /// <returns>The name of the uniform block.</returns>


        public static string glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize = 512)
        {
            int length;
            var buffer = new byte[bufSize];
            fixed (byte* name = &buffer[0])
            {
                _glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, &length, name);
            }
            return Encoding.UTF8.GetString(buffer, 0, Math.Min(bufSize, length));
        }


        /// <summary>
        /// Bind a user-defined varying out variable to a fragment shader color number and index.
        /// </summary>
        /// <param name="program">The name of the program containing varying out variable whose binding to modify.</param>
        /// <param name="colorNumber">The color number to bind the user-defined varying out variable to.</param>
        /// <param name="index">The index of the color input to bind the user-defined varying out variable to.</param>
        /// <param name="name">The name of the user-defined varying out variable whose binding to modify.</param>
        public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
        {
            var buffer = Encoding.UTF8.GetBytes(name);
            fixed (byte* b = &buffer[0])
            {
                _glBindFragDataLocationIndexed(program, colorNumber, index, b);
            }
        }

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetQueryObjectiv(uint id, int pname, int* args) => _glGetQueryObjectiv(id, pname, args);

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetQueryObjectuiv(uint id, int pname, uint* args) => _glGetQueryObjectuiv(id, pname, args);

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetQueryObjecti64v(uint id, int pname, long* args) => _glGetQueryObjecti64v(id, pname, args);

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetQueryObjectui64v(uint id, int pname, ulong* args) => _glGetQueryObjectui64v(id, pname, args);

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="count">The number of values to receive.</param>
        /// <returns>The retrieved values.</returns>


        public static ulong[] glGetQueryObjectui64v(uint id, int pname, int count)
        {
            var values = new ulong[count];
            fixed (ulong* args = &values[0])
            {
                _glGetQueryObjectui64v(id, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="count">The number of values to receive.</param>
        /// <returns>The retrieved values.</returns>


        public static long[] glGetQueryObjecti64v(uint id, int pname, int count)
        {
            var values = new long[count];
            fixed (long* args = &values[0])
            {
                _glGetQueryObjecti64v(id, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="count">The number of values to receive.</param>
        /// <returns>The retrieved values.</returns>


        public static uint[] glGetQueryObjectuiv(uint id, int pname, int count)
        {
            var values = new uint[count];
            fixed (uint* args = &values[0])
            {
                _glGetQueryObjectuiv(id, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return parameters of a query object.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter.<para>Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</para></param>
        /// <param name="count">The number of values to receive.</param>
        /// <returns>The retrieved values.</returns>


        public static int[] glGetQueryObjectiv(uint id, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetQueryObjectiv(id, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Query the name of an active uniform.
        /// </summary>
        /// <param name="program">Specifies the program containing the active uniform index <paramref name="uniformIndex"/>.</param>
        /// <param name="uniformIndex">Specifies the index of the active uniform whose name to query.</param>
        /// <param name="bufSize">Specifies the size of the buffer for the string.</param>
        /// <returns>The name of the active uniform.</returns>


        public static string glGetActiveUniformName(uint program, uint uniformIndex, int bufSize = 512)
        {
            int length;
            var buffer = new byte[bufSize];
            fixed (byte* name = &buffer[0])
            {
                _glGetActiveUniformName(program, uniformIndex, bufSize, &length, name);
            }
            return Encoding.UTF8.GetString(buffer, 0, Math.Min(length, bufSize));
        }

        /// <summary>
        /// Bind a framebuffer to a framebuffer target.
        /// </summary>
        /// <param name="target">Specifies the framebuffer target of the binding operation.</param>
        /// <param name="framebuffer">Specifies the name of the framebuffer object to bind.</param>
        public static void glBindFramebuffer(int target, uint framebuffer) => _glBindFramebuffer(target, framebuffer);

        /// <summary>
        /// Assign a binding point to an active uniform block.
        /// </summary>
        /// <param name="program">The name of a program object containing the active uniform block whose binding to assign.</param>
        /// <param name="uniformBlockIndex">The index of the active uniform block within program whose binding to assign.</param>
        /// <param name="uniformBlockBinding">Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program.</param>
        public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) => _glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);

        /// <summary>
        /// Return a parameter from a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter.</param>
        /// <param name="args">Returns the requested object parameter.</param>
        public static void GetProgram(int program, GetProgramParameterName pname, int* args) => _glGetProgramiv((uint)program, (int)pname, args);

        /// <summary>
        /// Return a parameter from a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="pname">Specifies the object parameter.</param>
        /// <param name="count">The number of parameters to return..</param>
        /// <returns>The requested parameters.</returns>


        public static int[] GetProgram(int program, GetProgramParameterName pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetProgramiv((uint)program, (int)pname, args);
            }
            return values;
        }

        public static void GetProgram(int program, GetProgramParameterName pname, out int args)
        {
            int _args;
            _glGetProgramiv((uint)program, (int)pname, &_args);
            args = _args;
        }

        /// <summary>
        /// Return a parameter from a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter.<para>Must be GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, or GL_SHADER_SOURCE_LENGTH.</para></param>
        /// <param name="args">Returns the requested object parameter.</param>
        public static void GetShader(int shader, ShaderParameter pname, int* args) => _glGetShaderiv((uint)shader, (int)pname, args);

        /// <summary>
        /// Return a parameter from a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="pname">Specifies the object parameter.<para>Must be GL_SHADER_TYPE, GL_DELETE_STATUS, GL_COMPILE_STATUS, GL_INFO_LOG_LENGTH, or GL_SHADER_SOURCE_LENGTH.</para></param>
        /// <param name="count">The number of parameters to return..</param>
        /// <returns>The requested parameters.</returns>


        public static int[] GetShader(int shader, ShaderParameter pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetShaderiv((uint)shader, (int)pname, args);
            }
            return values;
        }

        public static void GetShader(int shader, ShaderParameter pname, out int args)
        {
            int _args;
            _glGetShaderiv((uint)shader, (int)pname, &_args);
            args = _args;
        }

        /// <summary>
        /// Return parameters of a query object target.
        /// </summary>
        /// <param name="target">Specifies a query object target.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter.<para>Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</para></param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetQueryiv(int target, int pname, int* args) => _glGetQueryiv(target, pname, args);

        /// <summary>
        /// Return parameters of a query object target.
        /// </summary>
        /// <param name="target">Specifies a query object target.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter.<para>Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</para></param>
        /// <param name="count">The number of parameters to return..</param>
        /// <returns>The requested parameters.</returns>


        public static int[] glGetQueryiv(int target, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetQueryiv(target, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Returns the value of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="args">Returns the value of the specified uniform variable</param>
        public static void glGetUniformfv(uint program, int location, float* args) => _glGetUniformfv(program, location, args);

        /// <summary>
        /// Returns the value of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static float[] glGetUniformfv(uint program, int location, int count)
        {
            var values = new float[count];
            fixed (float* args = &values[0])
            {
                _glGetUniformfv(program, location, args);
            }
            return values;
        }

        /// <summary>
        /// Returns the value of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="args">Returns the value of the specified uniform variable</param>
        public static void glGetUniformuiv(uint program, int location, uint* args) => _glGetUniformuiv(program, location, args);

        /// <summary>
        /// Returns the value of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static uint[] glGetUniformuiv(uint program, int location, int count)
        {
            var values = new uint[count];
            fixed (uint* args = &values[0])
            {
                _glGetUniformuiv(program, location, args);
            }
            return values;
        }

        /// <summary>
        /// Returns the value of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="args">Returns the value of the specified uniform variable</param>
        public static void glGetUniformiv(uint program, int location, int* args) => _glGetUniformiv(program, location, args);

        /// <summary>
        /// Returns the value of a uniform variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="location">Specifies the location of the uniform variable to be queried.</param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static int[] glGetUniformiv(uint program, int location, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetUniformiv(program, location, args);
            }
            return values;
        }

        /// <summary>
        /// Copy all or part of the data store of a buffer object to the data store of another buffer object.
        /// </summary>
        /// <param name="readTarget">Specifies the target to which the source buffer object is bound.</param>
        /// <param name="writeTarget">Specifies the target to which the destination buffer object is bound.</param>
        /// <param name="readOffset">Specifies the offset, in basic machine units, within the data store of the source buffer object at which data will be read.</param>
        /// <param name="writeOffset">Specifies the offset, in basic machine units, within the data store of the destination buffer object at which data will be written.</param>
        /// <param name="size">Specifies the size, in basic machine units, of the data to be copied from the source buffer object to the destination buffer object.</param>
        public static void glCopyBufferSubData(int readTarget, int writeTarget, int readOffset, int writeOffset, int size) => _glCopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new IntPtr(size));

        /// <summary>
        /// Copy all or part of the data store of a buffer object to the data store of another buffer object.
        /// </summary>
        /// <param name="readTarget">Specifies the target to which the source buffer object is bound.</param>
        /// <param name="writeTarget">Specifies the target to which the destination buffer object is bound.</param>
        /// <param name="readOffset">Specifies the offset, in basic machine units, within the data store of the source buffer object at which data will be read.</param>
        /// <param name="writeOffset">Specifies the offset, in basic machine units, within the data store of the destination buffer object at which data will be written.</param>
        /// <param name="size">Specifies the size, in basic machine units, of the data to be copied from the source buffer object to the destination buffer object.</param>
        public static void glCopyBufferSubData(int readTarget, int writeTarget, long readOffset, long writeOffset, long size) => _glCopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new IntPtr(size));

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetVertexAttribdv(uint index, int pname, double* args) => _glGetVertexAttribdv(index, pname, args);

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetVertexAttribfv(uint index, int pname, float* args) => _glGetVertexAttribfv(index, pname, args);

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetVertexAttribiv(uint index, int pname, int* args) => _glGetVertexAttribiv(index, pname, args);

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetVertexAttribIiv(uint index, int pname, int* args) => _glGetVertexAttribIiv(index, pname, args);

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="args">Returns the requested data.</param>
        public static void glGetVertexAttribIuiv(uint index, int pname, uint* args) => _glGetVertexAttribIuiv(index, pname, args);

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static double[] glGetVertexAttribdv(uint index, int pname, int count)
        {
            var values = new double[count];
            fixed (double* args = &values[0])
            {
                _glGetVertexAttribdv(index, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static float[] glGetVertexAttribfv(uint index, int pname, int count)
        {
            var values = new float[count];
            fixed (float* args = &values[0])
            {
                _glGetVertexAttribfv(index, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static int[] glGetVertexAttribiv(uint index, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetVertexAttribiv(index, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static int[] glGetVertexAttribIiv(uint index, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetVertexAttribIiv(index, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return a generic vertex attribute parameter.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be queried.</param>
        /// <param name="pname">Specifies the symbolic name of the vertex attribute parameter to be queried. </param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The requested values.</returns>


        public static uint[] glGetVertexAttribIuiv(uint index, int pname, int count)
        {
            var values = new uint[count];
            fixed (uint* args = &values[0])
            {
                _glGetVertexAttribIuiv(index, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Define an array of generic vertex attribute data.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute.<para>Must be 1, 2, 3, 4 or GL_BGRA.</para></param>
        /// <param name="type">Specifies the data type of each component in the array.</param>
        /// <param name="stride">Specifies the byte offset between consecutive generic vertex attributes.<para>If stride is 0, the generic vertex attributes are understood to be tightly packed in the array.</para>The initial value is 0.</param>
        /// <param name="pointer">Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the buffer currently bound to the GL_ARRAY_BUFFER target.<para>The initial value is 0.</para></param>
        public static void glVertexAttribIPointer(uint index, int size, int type, int stride, /*const*/ void* pointer) => _glVertexAttribIPointer(index, size, type, stride, pointer);

        /// <summary>
        /// Define an array of generic vertex attribute data.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute.<para>Must be 1, 2, 3, 4 or GL_BGRA.</para></param>
        /// <param name="type">Specifies the data type of each component in the array.</param>
        /// <param name="stride">Specifies the byte offset between consecutive generic vertex attributes.<para>If stride is 0, the generic vertex attributes are understood to be tightly packed in the array.</para>The initial value is 0.</param>
        /// <param name="pointer">Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the buffer currently bound to the GL_ARRAY_BUFFER target.<para>The initial value is 0.</para></param>
        public static void glVertexAttribIPointer(uint index, int size, int type, int stride, IntPtr pointer) => _glVertexAttribIPointer(index, size, type, stride, pointer.ToPointer());


        /// <summary>
        /// Establish the data storage, format, dimensions, and number of samples of a multisample texture's image
        /// </summary>
        /// <param name="target">Specifies the target of the operation.<para>Must be GL_TEXTURE_2D_MULTISAMPLE or GL_PROXY_TEXTURE_2D_MULTISAMPLE.</para></param>
        /// <param name="samples">The number of samples in the multisample texture's image.</param>
        /// <param name="internalformat">The internal format to be used to store the multisample texture's image.<para>Must specify a color-renderable, depth-renderable, or stencil-renderable format.</para></param>
        /// <param name="width">The width of the multisample texture's image, in texels.</param>
        /// <param name="height">The height of the multisample texture's image, in texels.</param>
        /// <param name="fixedsamplelocations">Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image.</param>
        public static void glTexImage2DMultisample(int target, int samples, int internalformat, int width, int height, bool fixedsamplelocations) => _glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);

        /// <summary>
        /// Establish the data storage, format, dimensions, and number of samples of a multisample texture's image
        /// </summary>
        /// <param name="target">Specifies the target of the operation.<para>Must be GL_TEXTURE_2D_MULTISAMPLE_ARRAY or GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.</para></param>
        /// <param name="samples">The number of samples in the multisample texture's image.</param>
        /// <param name="internalformat">The internal format to be used to store the multisample texture's image.<para>Must specify a color-renderable, depth-renderable, or stencil-renderable format.</para></param>
        /// <param name="width">The width of the multisample texture's image, in texels.</param>
        /// <param name="height">The height of the multisample texture's image, in texels.</param>
        /// <param name="depth">The depth of the multisample texture's image, in texels.</param>
        /// <param name="fixedsamplelocations">Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image.</param>
        public static void glTexImage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, bool fixedsamplelocations) => _glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix2(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix2fv(location, count, transpose, value);

        public static void UniformMatrix2(int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    UniformMatrix2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix3(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix3fv(location, count, transpose, value);

        public static void UniformMatrix3(int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    UniformMatrix3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix4(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix4fv(location, count, transpose, value);

        public static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    UniformMatrix4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix2x3(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix2x3fv(location, count, transpose, value);

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix3x2(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix3x2fv(location, count, transpose, value);

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix2x4(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix2x4fv(location, count, transpose, value);

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix4x2(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix4x2fv(location, count, transpose, value);

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix3x4(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix3x4fv(location, count, transpose, value);

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="value">Specifies a pointer to an array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix4x3(int location, int count, bool transpose, /*const*/ float* value) => _glUniformMatrix4x3fv(location, count, transpose, value);

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix2(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix2fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix3(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix3fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix4(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix4fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix2x3(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix2x3fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix3x2(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix3x2fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix2x4(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix2x4fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix4x2(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix4x2fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix3x4(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix3x4fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object.
        /// </summary>
        /// <param name="location">Specifies the location of the uniform variable to be modified.</param>
        /// <param name="count">Specifies the number of matrices that are to be modified.</param>
        /// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        /// <param name="values">An array of count values that will be used to update the specified uniform variable.</param>
        public static void UniformMatrix4x3(int location, int count, bool transpose, float[] values)
        {
            fixed (float* value = &values[0])
            {
                _glUniformMatrix4x3fv(location, count, transpose, value);
            }
        }

        /// <summary>
        /// Set texture parameters.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter.</param>
        /// <param name="args">Specifies the value of the parameters..</param>
        public static void glTexParameterIiv(int target, int pname, /*const*/ int* args) => _glTexParameterIiv(target, pname, args);

        /// <summary>
        /// Set texture parameters.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter.</param>
        /// <param name="args">Specifies the value of the parameters..</param>
        public static void glTexParameterIuiv(int target, int pname, /*const*/ uint* args) => _glTexParameterIuiv(target, pname, args);

        /// <summary>
        /// Set texture parameters.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter.</param>
        /// <param name="args">Specifies the value of the parameters..</param>
        public static void glTexParameterIiv(int target, int pname, int[] args)
        {
            fixed (int* arg = &args[0])
            {
                _glTexParameterIiv(target, pname, arg);
            }
        }

        /// <summary>
        /// Set texture parameters.
        /// </summary>
        /// <param name="target">Specifies the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a single-valued texture parameter.</param>
        /// <param name="args">Specifies the value of the parameters..</param>
        public static void glTexParameterIuiv(int target, int pname, uint[] args)
        {
            fixed (uint* arg = &args[0])
            {
                _glTexParameterIuiv(target, pname, arg);
            }
        }

        /// <summary>
        /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image.
        /// </summary>
        /// <param name="target">Specifies a binding target of the allocation.<para>Must be GL_RENDERBUFFER.</para></param>
        /// <param name="samples">Specifies the number of samples to be used for the renderbuffer object's storage.</param>
        /// <param name="internalformat">Specifies the internal format to use for the renderbuffer object's image.</param>
        /// <param name="width">Specifies the width of the renderbuffer, in pixels.</param>
        /// <param name="height">Specifies the height of the renderbuffer, in pixels.</param>
        public static void glRenderbufferStorageMultisample(int target, int samples, int internalformat, int width, int height) => _glRenderbufferStorageMultisample(target, samples, internalformat, width, height);

        /// <summary>
        /// Draw multiple instances of a range of elements.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="first">Specifies the starting index in the enabled arrays.</param>
        /// <param name="count">Specifies the number of indices to be rendered.</param>
        /// <param name="instanceCount">Specifies the number of instances of the specified range of indices to be rendered.</param>
        public static void glDrawArraysInstanced(int mode, int first, int count, int instanceCount) => _glDrawArraysInstanced(mode, first, count, instanceCount);

        /// <summary>
        /// Return the address of the specified generic vertex attribute pointer.
        /// </summary>
        /// <param name="index">Specifies the generic vertex attribute parameter to be returned.</param>
        /// <param name="pname">Specifies the symbolic name of the generic vertex attribute parameter to be returned.<para>Must be GL_VERTEX_ATTRIB_ARRAY_POINTER.</para></param>
        /// <returns>The pointer value.</returns>
        public static IntPtr glGetVertexAttribPointerv(uint index, int pname)
        {
            _glGetVertexAttribPointerv(index, pname, out var pointer);
            return pointer;
        }

        /// <summary>
        /// Return the pointer to a mapped buffer object's data store
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="pname">Specifies the name of the pointer to be returned.<para>Must be GL_BUFFER_MAP_POINTER.</para></param>
        /// <returns>Returns the pointer value specified by pname.</returns>
        public static IntPtr glGetBufferPointerv(int target, int pname)
        {
            _glGetBufferPointerv(target, pname, out var pointer);
            return pointer;
        }

        /// <summary>
        /// Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the symbolic name of the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="args">Returns the texture parameters.</param>
        public static void glGetTexParameterIiv(int target, int pname, int* args) => _glGetTexParameterIiv(target, pname, args);

        /// <summary>
        /// Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the symbolic name of the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="args">Returns the texture parameters.</param>
        public static void glGetTexParameterIuiv(int target, int pname, uint* args) => _glGetTexParameterIuiv(target, pname, args);

        /// <summary>
        /// Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the symbolic name of the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The texture parameters.</returns>


        public static int[] glGetTexParameterIiv(int target, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetTexParameterIiv(target, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Return texture parameter values.
        /// </summary>
        /// <param name="target">Specifies the symbolic name of the target texture.</param>
        /// <param name="pname">Specifies the symbolic name of a texture parameter.</param>
        /// <param name="count">The number of values to retrieve.</param>
        /// <returns>The texture parameters.</returns>


        public static uint[] glGetTexParameterIuiv(int target, int pname, int count)
        {
            var values = new uint[count];
            fixed (uint* args = &values[0])
            {
                _glGetTexParameterIuiv(target, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Retrieve the index of a named uniform block.
        /// </summary>
        /// <param name="program">Specifies the name of a program containing the uniform block.</param>
        /// <param name="uniformBlockName">The name of the uniform block whose index to retrieve.</param>
        /// <returns>The index of a uniform block within program.</returns>

        public static uint glGetUniformBlockIndex(uint program, string uniformBlockName)
        {
            var buffer = Encoding.UTF8.GetBytes(uniformBlockName);
            fixed (byte* b = &buffer[0])
            {
                return _glGetUniformBlockIndex(program, b);
            }
        }

        /// <summary>
        /// Returns information about several active uniform variables for the specified program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformCount">Specifies both the number of elements in the array of indices <paramref name="uniformIndices"/> and the number of parameters written to params upon successful return.</param>
        /// <param name="uniformIndices">Specifies the address of an array of <paramref name="uniformCount"/> integers containing the indices of uniforms within program whose parameter <paramref name="pname"/> should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of <paramref name="args"/>.</param>
        /// <param name="args">Specifies the address of an array of <paramref name="uniformCount"/> integers which are to receive the value of <paramref name="pname"/> for each uniform in <paramref name="uniformIndices"/>.</param>
        public static void glGetActiveUniformsiv(uint program, int uniformCount, /*const*/ uint* uniformIndices, int pname, int* args) => _glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, args);


        /// <summary>
        /// Returns information about several active uniform variables for the specified program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="uniformCount">Specifies both the number of elements in the array of indices <paramref name="uniformIndices"/> and the number of parameters written to params upon successful return.</param>
        /// <param name="uniformIndices">Specifies an array of <paramref name="uniformCount"/> integers containing the indices of uniforms within program whose parameter <paramref name="pname"/> should be queried.</param>
        /// <param name="pname">Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of <paramref name="args"/>.</param>
        /// <param name="args">Specifies an array of <paramref name="uniformCount"/> integers which are to receive the value of <paramref name="pname"/> for each uniform in <paramref name="uniformIndices"/>.</param>
        public static void glGetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, int pname, int[] args)
        {
            fixed (uint* i = &uniformIndices[0])
            {
                fixed (int* a = &args[0])
                {
                    _glGetActiveUniformsiv(program, uniformCount, i, pname, a);
                }
            }
        }

        /// <summary>
        /// Return parameters of a buffer object.
        /// </summary>
        /// <param name="target">Specifies the target buffer object.<para>Must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER.</para></param>
        /// <param name="pname">Specifies the symbolic name of a buffer object parameter.<para>Must be GL_BUFFER_SIZE or GL_BUFFER_USAGE.</para></param>
        /// <param name="args">Returns the requested parameter.</param>
        public static void glGetBufferParameteriv(int target, int pname, int* args) => _glGetBufferParameteriv(target, pname, args);

        /// <summary>
        /// Return parameters of a buffer object.
        /// </summary>
        /// <param name="target">Specifies the target buffer object.<para>Must be GL_ARRAY_BUFFER or GL_ELEMENT_ARRAY_BUFFER.</para></param>
        /// <param name="pname">Specifies the symbolic name of a buffer object parameter.<para>Must be GL_BUFFER_SIZE or GL_BUFFER_USAGE.</para></param>
        /// <param name="count">The number of values to return.</param>
        /// <returns>The requested parameter.</returns>


        public static int[] glGetBufferParameteriv(int target, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetBufferParameteriv(target, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Query the properties of a sync object.
        /// </summary>
        /// <param name="sync">Specifies the sync object whose properties to query.</param>
        /// <param name="pname">Specifies the parameter whose value to retrieve from the sync object specified in <paramref name="sync"/>.</param>
        /// <param name="bufSize">Specifies the size of the buffer whose address is given in <paramref name="values"/>.</param>
        /// <param name="length">Specifies the address of an variable to receive the number of integers placed in <paramref name="values"/>.</param>
        /// <param name="values">Specifies the address of an array to receive the values of the queried parameter.</param>
        public static void glGetSynciv(IntPtr sync, int pname, int bufSize, int* length, int* values) => _glGetSynciv(sync, pname, bufSize, length, values);

        /// <summary>
        /// Query the properties of a sync object.
        /// </summary>
        /// <param name="sync">Specifies the sync object whose properties to query.</param>
        /// <param name="pname">Specifies the parameter whose value to retrieve from the sync object specified in <paramref name="sync"/>.</param>
        /// <param name="count">The number of properties to retrieve.</param>
        /// <param name="length">Specifies the number of integers placed in the return value.</param>
        /// <returns>The specified properties.</returns>


        public static int[] glGetSynciv(IntPtr sync, int pname, int count, out int length)
        {
            var bufSize = count * sizeof(int);
            var values = new int[count];
            fixed (int* v = &values[0])
            {
                int len;
                _glGetSynciv(sync, pname, bufSize, &len, v);
                length = len;
            }
            return values;
        }

        /// <summary>
        /// Return parameters of a renderbuffer object.
        /// </summary>
        /// <param name="target">Specifies the target renderbuffer object.<para>Must be GL_RENDERBUFFER.</para></param>
        /// <param name="pname">Specifies the symbolic name of a renderbuffer object parameter.</param>
        /// <param name="args">Returns the requested parameter.</param>
        public static void glGetRenderbufferParameteriv(int target, int pname, int* args) => _glGetRenderbufferParameteriv(target, pname, args);

        /// <summary>
        /// Return parameters of a renderbuffer object.
        /// </summary>
        /// <param name="target">Specifies the target renderbuffer object.<para>Must be GL_RENDERBUFFER.</para></param>
        /// <param name="pname">Specifies the symbolic name of a renderbuffer object parameter.</param>
        /// <param name="args">An array to write the requested parameter(s).</param>
        public static void glGetRenderbufferParameteriv(int target, int pname, int[] args)
        {
            fixed (int* a = &args[0])
            {
                _glGetRenderbufferParameteriv(target, pname, a);
            }
        }

        /// <summary>
        /// Retrieve the location of a sample.
        /// </summary>
        /// <param name="pname">Specifies the sample parameter name.<para>Must be GL_SAMPLE_POSITION.</para></param>
        /// <param name="index">Specifies the index of the sample whose position to query.</param>
        /// <param name="val">Specifies the address of an array to receive the position of the sample.</param>
        public static void glGetMultisamplefv(int pname, uint index, float* val) => _glGetMultisamplefv(pname, index, val);

        /// <summary>
        /// Retrieve the location of a sample.
        /// </summary>
        /// <param name="pname">Specifies the sample parameter name.<para>Must be GL_SAMPLE_POSITION.</para></param>
        /// <param name="index">Specifies the index of the sample whose position to query.</param>
        /// <param name="count">The number of values to recieve.</param>
        /// <returns>The position of the sample.</returns>


        public static float[] glGetMultisamplefv(int pname, uint index, int count)
        {
            var values = new float[count];
            fixed (float* val = &values[0])
            {
                _glGetMultisamplefv(pname, index, val);
            }
            return values;
        }

        /// <summary>
        /// Draw multiple instances of a set of elements.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices.<para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para></param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="instanceCount">Specifies the number of instances of the specified range of indices to be rendered.</param>
        public static void glDrawElementsInstanced(int mode, int count, int type, /*const*/ void* indices, int instanceCount) => _glDrawElementsInstanced(mode, count, type, indices, instanceCount);


        /// <summary>
        /// Draw multiple instances of a set of elements.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="instanceCount">Specifies the number of instances of the specified range of indices to be rendered.</param>
        public static void glDrawElementsInstanced(int mode, int count, byte[] indices, int instanceCount)
        {
            fixed (byte* i = &indices[0])
            {
                _glDrawElementsInstanced(mode, count, (int)DrawElementsType.UnsignedByte, i, instanceCount);
            }
        }

        /// <summary>
        /// Draw multiple instances of a set of elements.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="instanceCount">Specifies the number of instances of the specified range of indices to be rendered.</param>
        public static void glDrawElementsInstanced(int mode, int count, ushort[] indices, int instanceCount)
        {
            fixed (ushort* i = &indices[0])
            {
                _glDrawElementsInstanced(mode, count, (int)DrawElementsType.UnsignedShort, i, instanceCount);
            }
        }

        /// <summary>
        /// Draw multiple instances of a set of elements.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="instanceCount">Specifies the number of instances of the specified range of indices to be rendered.</param>
        public static void glDrawElementsInstanced(int mode, int count, uint[] indices, int instanceCount)
        {
            fixed (uint* i = &indices[0])
            {
                _glDrawElementsInstanced(mode, count, (int)DrawElementsType.UnsignedInt, i, instanceCount);
            }
        }

        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. </param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices.<para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para></param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsBaseVertex(int mode, int count, int type, /*const*/ void* indices, int baseVertex) => _glDrawElementsBaseVertex(mode, count, type, indices, baseVertex);


        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. </param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsBaseVertex(int mode, int count, byte[] indices, int baseVertex)
        {
            fixed (byte* i = &indices[0])
            {
                glDrawElementsBaseVertex(mode, count, (int)DrawElementsType.UnsignedByte, i, baseVertex);
            }
        }

        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. </param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsBaseVertex(int mode, int count, ushort[] indices, int baseVertex)
        {
            fixed (ushort* i = &indices[0])
            {
                glDrawElementsBaseVertex(mode, count, (int)DrawElementsType.UnsignedShort, i, baseVertex);
            }
        }

        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. </param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsBaseVertex(int mode, int count, uint[] indices, int baseVertex)
        {
            fixed (uint* i = &indices[0])
            {
                glDrawElementsBaseVertex(mode, count, (int)DrawElementsType.UnsignedInt, i, baseVertex);
            }
        }

        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices"/>.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices"/>.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices.<para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para></param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawRangeElementsBaseVertex(int mode, uint start, uint end, int count, int type, /*const*/void* indices, int baseVertex) => _glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, baseVertex);


        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices"/>.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices"/>.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawRangeElementsBaseVertex(int mode, uint start, uint end, int count, byte[] indices, int baseVertex)
        {
            fixed (byte* i = &indices[0])
            {
                _glDrawRangeElementsBaseVertex(mode, start, end, count, (int)DrawElementsType.UnsignedByte, i, baseVertex);
            }
        }

        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices"/>.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices"/>.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawRangeElementsBaseVertex(int mode, uint start, uint end, int count, ushort[] indices, int baseVertex)
        {
            fixed (ushort* i = &indices[0])
            {
                _glDrawRangeElementsBaseVertex(mode, start, end, count, (int)DrawElementsType.UnsignedByte, i, baseVertex);
            }
        }

        /// <summary>
        /// Render primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="start">Specifies the minimum array index contained in <paramref name="indices"/>.</param>
        /// <param name="end">Specifies the maximum array index contained in <paramref name="indices"/>.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawRangeElementsBaseVertex(int mode, uint start, uint end, int count, uint[] indices, int baseVertex)
        {
            fixed (uint* i = &indices[0])
            {
                _glDrawRangeElementsBaseVertex(mode, start, end, count, (int)DrawElementsType.UnsignedByte, i, baseVertex);
            }
        }

        /// <summary>
        /// Render multiple instances of a set of primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices.<para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para></param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="instanceCount">Specifies the number of instances of the indexed geometry that should be drawn.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsInstancedBaseVertex(int mode, int count, int type, /*const*/ void* indices, int instanceCount, int baseVertex) => _glDrawElementsInstancedBaseVertex(mode, count, type, indices, instanceCount, baseVertex);

        /// <summary>
        /// Render multiple instances of a set of primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="instanceCount">Specifies the number of instances of the indexed geometry that should be drawn.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsInstancedBaseVertex(int mode, int count, byte[] indices, int instanceCount, int baseVertex)
        {
            fixed (byte* i = &indices[0])
            {
                _glDrawElementsInstancedBaseVertex(mode, count, (int)DrawElementsType.UnsignedByte, i, instanceCount, baseVertex);
            }
        }

        /// <summary>
        /// Render multiple instances of a set of primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="instanceCount">Specifies the number of instances of the indexed geometry that should be drawn.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsInstancedBaseVertex(int mode, int count, ushort[] indices, int instanceCount, int baseVertex)
        {
            fixed (ushort* i = &indices[0])
            {
                _glDrawElementsInstancedBaseVertex(mode, count, (int)DrawElementsType.UnsignedShort, i, instanceCount, baseVertex);
            }
        }

        /// <summary>
        /// Render multiple instances of a set of primitives from array data with a per-element offset.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="indices">The indices.</param>
        /// <param name="instanceCount">Specifies the number of instances of the indexed geometry that should be drawn.</param>
        /// <param name="baseVertex">Specifies a constant that should be added to each element of indices when choosing elements from the enabled vertex arrays.</param>
        public static void glDrawElementsInstancedBaseVertex(int mode, int count, uint[] indices, int instanceCount, int baseVertex)
        {
            fixed (uint* i = &indices[0])
            {
                _glDrawElementsInstancedBaseVertex(mode, count, (int)DrawElementsType.UnsignedInt, i, instanceCount, baseVertex);
            }
        }

        /// <summary>
        /// Retrieve the index of a named uniform block.
        /// </summary>
        /// <param name="program">Specifies the name of a program containing uniforms whose indices to query.</param>
        /// <param name="uniformName">The names of the uniform to query.</param>
        /// <returns>The index of the uniform.</returns>
        public static uint glGetUniformIndex(uint program, string uniformName)
        {
            uint index;
            var bytes = new[] { Encoding.UTF8.GetBytes(uniformName) };
            fixed (byte* names = &bytes[0][0])
            {
                _glGetUniformIndices(program, 1, &names, &index);
            }
            return index;
        }

        /// <summary>
        /// Return parameters of a buffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="pname">Specifies the symbolic name of a buffer object parameter.</param>
        /// <param name="args">Returns the requested parameter.</param>
        public static void glGetBufferParameteri64v(int target, int pname, long* args) => _glGetBufferParameteri64v(target, pname, args);


        /// <summary>
        /// Return parameters of a buffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="pname">Specifies the symbolic name of a buffer object parameter.</param>
        /// <param name="count">The number of parameters to retrieve.</param>
        /// <returns>The requested parameters.</returns>


        public static long[] glGetBufferParameteri64v(int target, int pname, int count)
        {
            var values = new long[count];
            fixed (long* args = &values[0])
            {
                _glGetBufferParameteri64v(target, pname, args);
            }
            return values;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="program">The name of the target program object.</param>
        /// <param name="index">The index of the varying variable whose information to retrieve.</param>
        /// <param name="size">The size of the varying.</param>
        /// <param name="type">The type of the varying.</param>
        /// <param name="name">The name of the varying.</param>
        /// <param name="bufSize">The maximum number of characters, including the null terminator, that may be written into name.</param>
        public static void glGetTransformFeedbackVarying(uint program, uint index, out int size, out int type, out string name, int bufSize = 512)
        {
            var buffer = Marshal.AllocHGlobal(bufSize);
            _glGetTransformFeedbackVarying(program, index, bufSize, out var length, out size, out type, buffer);
            name = PtrToStringUtf8(buffer, length);
            Marshal.FreeHGlobal(buffer);
        }

        /// <summary>
        /// Retrieve information about attachments of a framebuffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the framebuffer object is bound.</param>
        /// <param name="attachment">Specifies the attachment of the framebuffer object to query.</param>
        /// <param name="pname">Specifies the parameter of attachment to query.</param>
        /// <param name="args">Returns the value of parameter pname for attachment.</param>
        public static void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int* args) => _glGetFramebufferAttachmentParameteriv(target, attachment, pname, args);

        /// <summary>
        /// Retrieve information about attachments of a framebuffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the framebuffer object is bound.</param>
        /// <param name="attachment">Specifies the attachment of the framebuffer object to query.</param>
        /// <param name="pname">Specifies the parameter of attachment to query.</param>
        /// <param name="count">The number of parameters to retrieve.</param>
        /// <returns>Returns the value of parameter pname for attachment.</returns>


        public static int[] glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int count)
        {
            var values = new int[count];
            fixed (int* args = &values[0])
            {
                _glGetFramebufferAttachmentParameteriv(target, attachment, pname, args);
            }
            return values;
        }

        /// <summary>
        /// Render multiple sets of primitives by specifying indices of array data elements and an index to apply to each index.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="count">Points to an array of the elements counts.</param>
        /// <param name="type">Specifies the type of the values in indices.<para>Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</para></param>
        /// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        /// <param name="drawCount">Specifies the size of the count, indices and <paramref name="baseVertex"/> arrays.</param>
        /// <param name="baseVertex">Specifies a pointer to the location where the base vertices are stored.</param>
        public static void glMultiDrawElementsBaseVertex(int mode, /*const*/ int* count, int type, /*const*/void* /*const*/* indices, int drawCount, /*const*/ int* baseVertex) => _glMultiDrawElementsBaseVertex(mode, count, type, indices, drawCount, baseVertex);

        /// <summary>
        /// Specify values to record in transform feedback buffers.
        /// </summary>
        /// <param name="program">The name of the target program object.</param>
        /// <param name="count">The number of varying variables used for transform feedback.</param>
        /// <param name="varyings">An array of count zero-terminated strings specifying the names of the varying variables to use for transform feedback.</param>
        /// <param name="bufferMode">Identifies the mode used to capture the varying variables when transform feedback is active.<para>ust be GL_INTERLEAVED_ATTRIBS or GL_SEPARATE_ATTRIBS.</para></param>
        public static void glTransformFeedbackVaryings(uint program, int count, /*const*/ byte** varyings, int bufferMode) => _glTransformFeedbackVaryings(program, count, varyings, bufferMode);
        #endregion
    }
}