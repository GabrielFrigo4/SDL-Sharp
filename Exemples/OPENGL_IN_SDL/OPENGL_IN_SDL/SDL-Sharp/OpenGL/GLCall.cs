using System;
using System.Runtime.InteropServices;

namespace SDL_Sharp.OpenGL
{
    public static unsafe partial class GL
    {
        #region GLCall
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCULLFACEPROC(int mode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRONTFACEPROC(int mode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLHINTPROC(int target, int mode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLLINEWIDTHPROC(float width);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTSIZEPROC(float size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOLYGONMODEPROC(int face, int mode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSCISSORPROC(int x, int y, int width, int height);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERFPROC(int target, int pname, float param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERFVPROC(int target, int pname, /*const*/ float* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIPROC(int target, int pname, int param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIVPROC(int target, int pname, /*const*/ int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE1DPROC(int target, int level, int internalformat, int width, int border, int format, int type, /*const*/ void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE2DPROC(int target, int level, int internalformat, int width, int height, int border, int format, int type, /*const*/ void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWBUFFERPROC(int buf);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARPROC(uint mask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARCOLORPROC(float red, float green, float blue, float alpha);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARSTENCILPROC(int s);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARDEPTHPROC(double depth);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILMASKPROC(uint mask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORMASKPROC(bool red, bool green, bool blue, bool alpha);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDEPTHMASKPROC(bool flag);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDISABLEPROC(int cap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENABLEPROC(int cap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFINISHPROC();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFLUSHPROC();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDFUNCPROC(int sfactor, int dfactor);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLLOGICOPPROC(int opcode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILFUNCPROC(int func, int reference, uint mask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILOPPROC(int fail, int zfail, int zpass);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDEPTHFUNCPROC(int func);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPIXELSTOREFPROC(int pname, float param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPIXELSTOREIPROC(int pname, int param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLREADBUFFERPROC(int src);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLREADPIXELSPROC(int x, int y, int width, int height, int format, int type, void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBOOLEANVPROC(int pname, bool* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETDOUBLEVPROC(int pname, double* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETERRORPROC();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETFLOATVPROC(int pname, float* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGERVPROC(int pname, int* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate byte* PFNGLGETSTRINGPROC(int name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXIMAGEPROC(int target, int level, int format, int type, void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERFVPROC(int target, int pname, float* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERIVPROC(int target, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXLEVELPARAMETERFVPROC(int target, int level, int pname, float* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXLEVELPARAMETERIVPROC(int target, int level, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISENABLEDPROC(int cap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDEPTHRANGEPROC(double n, double f);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVIEWPORTPROC(int x, int y, int width, int height);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWARRAYSPROC(int mode, int first, int count);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSPROC(int mode, int count, int type, /*const*/ void* indices);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOLYGONOFFSETPROC(float factor, float units);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXIMAGE1DPROC(int target, int level, int internalformat, int x, int y, int width, int border);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXIMAGE2DPROC(int target, int level, int internalformat, int x, int y, int width, int height, int border);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXSUBIMAGE1DPROC(int target, int level, int xoffset, int x, int y, int width);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXSUBIMAGE2DPROC(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXSUBIMAGE1DPROC(int target, int level, int xoffset, int width, int format, int type, /*const*/ void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXSUBIMAGE2DPROC(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, /*const*/ void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDTEXTUREPROC(int target, uint texture);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETETEXTURESPROC(int n, /*const*/ uint* textures);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENTEXTURESPROC(int n, uint* textures);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISTEXTUREPROC(uint texture);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWRANGEELEMENTSPROC(int mode, uint start, uint end, int count, int type, /*const*/ void* indices);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE3DPROC(int target, int level, int internalformat, int width, int height, int depth, int border, int format, int type, /*const*/ void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXSUBIMAGE3DPROC(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, /*const*/ void* pixels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXSUBIMAGE3DPROC(int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLACTIVETEXTUREPROC(int texture);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLECOVERAGEPROC(float value, bool invert);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXIMAGE3DPROC(int target, int level, int internalformat, int width, int height, int depth, int border, int imageSize, /*const*/ void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXIMAGE2DPROC(int target, int level, int internalformat, int width, int height, int border, int imageSize, /*const*/ void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXIMAGE1DPROC(int target, int level, int internalformat, int width, int border, int imageSize, /*const*/ void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, /*const*/ void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, /*const*/ void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC(int target, int level, int xoffset, int width, int format, int imageSize, /*const*/ void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETCOMPRESSEDTEXIMAGEPROC(int target, int level, void* img);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDFUNCSEPARATEPROC(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTIDRAWARRAYSPROC(int mode, /*const*/ int* first, /*const*/ int* count, int drawCount);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTIDRAWELEMENTSPROC(int mode, /*const*/ int* count, int type, /*const*/ void*/*const*/* indices, int drawCount);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERFPROC(int pname, float param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERFVPROC(int pname, /*const*/ float* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERIPROC(int pname, int param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERIVPROC(int pname, /*const*/ int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDCOLORPROC(float red, float green, float blue, float alpha);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDEQUATIONPROC(int mode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENQUERIESPROC(int n, uint* ids);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEQUERIESPROC(int n, /*const*/ uint* ids);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISQUERYPROC(uint id);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBEGINQUERYPROC(int target, uint id);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENDQUERYPROC(int target);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYIVPROC(int target, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTIVPROC(uint id, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTUIVPROC(uint id, int pname, uint* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDBUFFERPROC(int target, uint buffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEBUFFERSPROC(int n, /*const*/ uint* buffers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENBUFFERSPROC(int n, uint* buffers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISBUFFERPROC(uint buffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBUFFERDATAPROC(int target, IntPtr size, /*const*/ void* data, int usage);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBUFFERSUBDATAPROC(int target, IntPtr offset, IntPtr size, /*const*/ void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERSUBDATAPROC(int target, IntPtr offset, IntPtr size, void* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void* PFNGLMAPBUFFERPROC(int target, int access);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLUNMAPBUFFERPROC(int target);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERPARAMETERIVPROC(int target, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERPOINTERVPROC(int target, int pname, out IntPtr args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDEQUATIONSEPARATEPROC(int modeRGB, int modeAlpha);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWBUFFERSPROC(int n, /*const*/ int* bufs);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILOPSEPARATEPROC(int face, int sfail, int dpfail, int dppass);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILFUNCSEPARATEPROC(int face, int func, int reference, uint mask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILMASKSEPARATEPROC(int face, uint mask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLATTACHSHADERPROC(uint program, uint shader);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDATTRIBLOCATIONPROC(uint program, uint index, /*const*/ byte* name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPILESHADERPROC(uint shader);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint PFNGLCREATEPROGRAMPROC();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint PFNGLCREATESHADERPROC(int type);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEPROGRAMPROC(uint program);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETESHADERPROC(uint shader);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDETACHSHADERPROC(uint program, uint shader);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDISABLEVERTEXATTRIBARRAYPROC(uint index);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENABLEVERTEXATTRIBARRAYPROC(uint index);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEATTRIBPROC(uint program, uint index, int bufSize, out int length, out int size, out int type, IntPtr name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMPROC(uint program, uint index, int bufSize, out int length, out int size, out int type, IntPtr name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETATTACHEDSHADERSPROC(uint program, int maxCount, int* count, uint* shaders);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETATTRIBLOCATIONPROC(uint program, /*const*/ byte* name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETPROGRAMIVPROC(uint program, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETPROGRAMINFOLOGPROC(uint program, int bufSize, int* length, byte* infoLog);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSHADERIVPROC(uint shader, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSHADERINFOLOGPROC(uint shader, int bufSize, int* length, byte* infoLog);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSHADERSOURCEPROC(uint shader, int bufSize, int* length, byte* source);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETUNIFORMLOCATIONPROC(uint program, /*const*/ byte* name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMFVPROC(uint program, int location, float* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMIVPROC(uint program, int location, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBDVPROC(uint index, int pname, double* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBFVPROC(uint index, int pname, float* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBIVPROC(uint index, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBPOINTERVPROC(uint index, int pname, out IntPtr pointer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISPROGRAMPROC(uint program);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISSHADERPROC(uint shader);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLLINKPROGRAMPROC(uint program);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSHADERSOURCEPROC(uint shader, int count, /*const*/ byte** str, /*const*/ int* length);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUSEPROGRAMPROC(uint program);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1FPROC(int location, float v0);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2FPROC(int location, float v0, float v1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3FPROC(int location, float v0, float v1, float v2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4FPROC(int location, float v0, float v1, float v2, float v3);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1IPROC(int location, int v0);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2IPROC(int location, int v0, int v1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3IPROC(int location, int v0, int v1, int v2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4IPROC(int location, int v0, int v1, int v2, int v3);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1FVPROC(int location, int count, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2FVPROC(int location, int count, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3FVPROC(int location, int count, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4FVPROC(int location, int count, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1IVPROC(int location, int count, /*const*/ int* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2IVPROC(int location, int count, /*const*/ int* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3IVPROC(int location, int count, /*const*/ int* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4IVPROC(int location, int count, /*const*/ int* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX2FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX3FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX4FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVALIDATEPROGRAMPROC(uint program);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1DPROC(uint index, double x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1DVPROC(uint index, /*const*/ double* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1FPROC(uint index, float x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1FVPROC(uint index, /*const*/ float* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1SPROC(uint index, short x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1SVPROC(uint index, /*const*/ short* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2DPROC(uint index, double x, double y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2DVPROC(uint index, /*const*/ double* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2FPROC(uint index, float x, float y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2FVPROC(uint index, /*const*/ float* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2SPROC(uint index, short x, short y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2SVPROC(uint index, /*const*/ short* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3DPROC(uint index, double x, double y, double z);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3DVPROC(uint index, /*const*/ double* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3FPROC(uint index, float x, float y, float z);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3FVPROC(uint index, /*const*/ float* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3SPROC(uint index, short x, short y, short z);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3SVPROC(uint index, /*const*/ short* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NBVPROC(uint index, /*const*/ sbyte* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NIVPROC(uint index, /*const*/ int* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NSVPROC(uint index, /*const*/ short* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUBPROC(uint index, byte x, byte y, byte z, byte w);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUBVPROC(uint index, /*const*/ byte* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUIVPROC(uint index, /*const*/ uint* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUSVPROC(uint index, /*const*/ ushort* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4BVPROC(uint index, /*const*/ sbyte* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4DPROC(uint index, double x, double y, double z, double w);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4DVPROC(uint index, /*const*/ double* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4FPROC(uint index, float x, float y, float z, float w);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4FVPROC(uint index, /*const*/ float* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4IVPROC(uint index, /*const*/ int* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4SPROC(uint index, short x, short y, short z, short w);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4SVPROC(uint index, /*const*/ short* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4UBVPROC(uint index, /*const*/ byte* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4UIVPROC(uint index, /*const*/ uint* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4USVPROC(uint index, /*const*/ ushort* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBPOINTERPROC(uint index, int size, int type, bool normalized, int stride, /*const*/ void* pointer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX2X3FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX3X2FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX2X4FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX4X2FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX3X4FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX4X3FVPROC(int location, int count, bool transpose, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORMASKIPROC(uint index, bool r, bool g, bool b, bool a);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBOOLEANI_VPROC(int target, uint index, bool* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGERI_VPROC(int target, uint index, int* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENABLEIPROC(int target, uint index);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDISABLEIPROC(int target, uint index);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISENABLEDIPROC(int target, uint index);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBEGINTRANSFORMFEEDBACKPROC(int primitiveMode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENDTRANSFORMFEEDBACKPROC();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDBUFFERRANGEPROC(int target, uint index, uint buffer, IntPtr offset, IntPtr size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDBUFFERBASEPROC(int target, uint index, uint buffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTRANSFORMFEEDBACKVARYINGSPROC(uint program, int count, /*const*/ byte** varyings, int bufferMode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTRANSFORMFEEDBACKVARYINGPROC(uint program, uint index, int bufSize, out int length, out int size, out int type, IntPtr name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLAMPCOLORPROC(int target, int clamp);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBEGINCONDITIONALRENDERPROC(uint id, int mode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENDCONDITIONALRENDERPROC();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBIPOINTERPROC(uint index, int size, int type, int stride, /*const*/ void* pointer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBIIVPROC(uint index, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBIUIVPROC(uint index, int pname, uint* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1IPROC(uint index, int x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2IPROC(uint index, int x, int y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3IPROC(uint index, int x, int y, int z);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4IPROC(uint index, int x, int y, int z, int w);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1UIPROC(uint index, uint x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2UIPROC(uint index, uint x, uint y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3UIPROC(uint index, uint x, uint y, uint z);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4UIPROC(uint index, uint x, uint y, uint z, uint w);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1IVPROC(uint index, /*const*/ int* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2IVPROC(uint index, /*const*/ int* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3IVPROC(uint index, /*const*/ int* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4IVPROC(uint index, /*const*/ int* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1UIVPROC(uint index, /*const*/ uint* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2UIVPROC(uint index, /*const*/ uint* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3UIVPROC(uint index, /*const*/ uint* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4UIVPROC(uint index, /*const*/ uint* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4BVPROC(uint index, /*const*/ sbyte* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4SVPROC(uint index, /*const*/ short* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4UBVPROC(uint index, /*const*/ byte* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4USVPROC(uint index, /*const*/ ushort* v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMUIVPROC(uint program, int location, uint* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDFRAGDATALOCATIONPROC(uint program, uint color, /*const*/ byte* name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETFRAGDATALOCATIONPROC(uint program, /*const*/ byte* name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1UIPROC(int location, uint v0);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2UIPROC(int location, uint v0, uint v1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3UIPROC(int location, uint v0, uint v1, uint v2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4UIPROC(int location, uint v0, uint v1, uint v2, uint v3);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1UIVPROC(int location, int count, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2UIVPROC(int location, int count, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3UIVPROC(int location, int count, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4UIVPROC(int location, int count, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIIVPROC(int target, int pname, /*const*/ int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIUIVPROC(int target, int pname, /*const*/ uint* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERIIVPROC(int target, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERIUIVPROC(int target, int pname, uint* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERIVPROC(int buffer, int drawbuffer, /*const*/ int* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERUIVPROC(int buffer, int drawbuffer, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERFVPROC(int buffer, int drawbuffer, /*const*/ float* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERFIPROC(int buffer, int drawbuffer, float depth, int stencil);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate byte* PFNGLGETSTRINGIPROC(int name, uint index);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISRENDERBUFFERPROC(uint renderbuffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDRENDERBUFFERPROC(int target, uint renderbuffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETERENDERBUFFERSPROC(int n, /*const*/ uint* renderbuffers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENRENDERBUFFERSPROC(int n, uint* renderbuffers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLRENDERBUFFERSTORAGEPROC(int target, int internalformat, int width, int height);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETRENDERBUFFERPARAMETERIVPROC(int target, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISFRAMEBUFFERPROC(uint framebuffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDFRAMEBUFFERPROC(int target, uint framebuffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEFRAMEBUFFERSPROC(int n, /*const*/ uint* framebuffers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENFRAMEBUFFERSPROC(int n, uint* framebuffers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLCHECKFRAMEBUFFERSTATUSPROC(int target);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURE1DPROC(int target, int attachment, int textarget, uint texture, int level);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURE2DPROC(int target, int attachment, int textarget, uint texture, int level);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURE3DPROC(int target, int attachment, int textarget, uint texture, int level, int zoffset);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERRENDERBUFFERPROC(int target, int attachment, int renderbuffertarget, uint renderbuffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETFRAMEBUFFERATTACHMENTPARAMETERIVPROC(int target, int attachment, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENERATEMIPMAPPROC(int target);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLITFRAMEBUFFERPROC(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, int filter);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLRENDERBUFFERSTORAGEMULTISAMPLEPROC(int target, int samples, int internalformat, int width, int height);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURELAYERPROC(int target, int attachment, uint texture, int level, int layer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void* PFNGLMAPBUFFERRANGEPROC(int target, IntPtr offset, IntPtr length, uint access);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFLUSHMAPPEDBUFFERRANGEPROC(int target, IntPtr offset, IntPtr length);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDVERTEXARRAYPROC(uint array);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEVERTEXARRAYSPROC(int n, /*const*/ uint* arrays);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENVERTEXARRAYSPROC(int n, uint* arrays);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISVERTEXARRAYPROC(uint array);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWARRAYSINSTANCEDPROC(int mode, int first, int count, int instanceCount);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSINSTANCEDPROC(int mode, int count, int type, /*const*/ void* indices, int instanceCount);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXBUFFERPROC(int target, int internalformat, uint buffer);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPRIMITIVERESTARTINDEXPROC(uint index);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYBUFFERSUBDATAPROC(int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMINDICESPROC(uint program, int uniformCount, /*const*/ byte** uniformNames, uint* uniformIndices);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMSIVPROC(uint program, int uniformCount, /*const*/ uint* uniformIndices, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMNAMEPROC(uint program, uint uniformIndex, int bufSize, int* length, byte* uniformName);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint PFNGLGETUNIFORMBLOCKINDEXPROC(uint program, /*const*/ byte* uniformBlockName);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMBLOCKIVPROC(uint program, uint uniformBlockIndex, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC(uint program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMBLOCKBINDINGPROC(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSBASEVERTEXPROC(int mode, int count, int type, /*const*/ void* indices, int baseVertex);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC(int mode, uint start, uint end, int count, int type, /*const*/ void* indices, int baseVertex);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC(int mode, int count, int type, /*const*/ void* indices, int instanceCount, int baseVertex);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC(int mode, /*const*/ int* count, int type, /*const*/ void*/*const*/* indices, int drawCount, /*const*/ int* baseVertex);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPROVOKINGVERTEXPROC(int mode);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFNGLFENCESYNCPROC(int condition, uint flags);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISSYNCPROC(IntPtr sync);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETESYNCPROC(IntPtr sync);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLCLIENTWAITSYNCPROC(IntPtr sync, uint flags, ulong timeout);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLWAITSYNCPROC(IntPtr sync, uint flags, ulong timeout);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGER64VPROC(int pname, long* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSYNCIVPROC(IntPtr sync, int pname, int bufSize, int* length, int* values);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGER64I_VPROC(int target, uint index, long* data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERPARAMETERI64VPROC(int target, int pname, long* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTUREPROC(int target, int attachment, uint texture, int level);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE2DMULTISAMPLEPROC(int target, int samples, int internalformat, int width, int height, bool fixedsamplelocations);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE3DMULTISAMPLEPROC(int target, int samples, int internalformat, int width, int height, int depth, bool fixedsamplelocations);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETMULTISAMPLEFVPROC(int pname, uint index, float* val);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLEMASKIPROC(uint maskNumber, uint mask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDFRAGDATALOCATIONINDEXEDPROC(uint program, uint colorNumber, uint index, /*const*/ byte* name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETFRAGDATAINDEXPROC(uint program, /*const*/ byte* name);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENSAMPLERSPROC(int count, uint* samplers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETESAMPLERSPROC(int count, /*const*/ uint* samplers);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISSAMPLERPROC(uint sampler);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDSAMPLERPROC(uint unit, uint sampler);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIPROC(uint sampler, int pname, int param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIVPROC(uint sampler, int pname, /*const*/ int* param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERFPROC(uint sampler, int pname, float param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERFVPROC(uint sampler, int pname, /*const*/ float* param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIIVPROC(uint sampler, int pname, /*const*/ int* param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIUIVPROC(uint sampler, int pname, /*const*/ uint* param);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERIVPROC(uint sampler, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERIIVPROC(uint sampler, int pname, int* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERFVPROC(uint sampler, int pname, float* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERIUIVPROC(uint sampler, int pname, uint* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLQUERYCOUNTERPROC(uint id, int target);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTI64VPROC(uint id, int pname, long* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTUI64VPROC(uint id, int pname, ulong* args);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBDIVISORPROC(uint index, uint divisor);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP1UIPROC(uint index, int type, bool normalized, uint value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP1UIVPROC(uint index, int type, bool normalized, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP2UIPROC(uint index, int type, bool normalized, uint value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP2UIVPROC(uint index, int type, bool normalized, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP3UIPROC(uint index, int type, bool normalized, uint value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP3UIVPROC(uint index, int type, bool normalized, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP4UIPROC(uint index, int type, bool normalized, uint value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP4UIVPROC(uint index, int type, bool normalized, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXP2UIPROC(int type, uint value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXP2UIVPROC(int type, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXP3UIPROC(int type, uint value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXP3UIVPROC(int type, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXP4UIPROC(int type, uint value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXP4UIVPROC(int type, /*const*/ uint* value);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP1UIPROC(int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP1UIVPROC(int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP2UIPROC(int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP2UIVPROC(int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP3UIPROC(int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP3UIVPROC(int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP4UIPROC(int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXCOORDP4UIVPROC(int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP1UIPROC(int texture, int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP1UIVPROC(int texture, int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP2UIPROC(int texture, int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP2UIVPROC(int texture, int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP3UIPROC(int texture, int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP3UIVPROC(int texture, int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP4UIPROC(int texture, int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTITEXCOORDP4UIVPROC(int texture, int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLNORMALP3UIPROC(int type, uint coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLNORMALP3UIVPROC(int type, /*const*/ uint* coords);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORP3UIPROC(int type, uint color);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORP3UIVPROC(int type, /*const*/ uint* color);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORP4UIPROC(int type, uint color);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORP4UIVPROC(int type, /*const*/ uint* color);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSECONDARYCOLORP3UIPROC(int type, uint color);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSECONDARYCOLORP3UIVPROC(int type, /*const*/ uint* color);

        private static PFNGLCULLFACEPROC _glCullFace;
        private static PFNGLFRONTFACEPROC _glFrontFace;
        private static PFNGLHINTPROC _glHint;
        private static PFNGLLINEWIDTHPROC _glLineWidth;
        private static PFNGLPOINTSIZEPROC _glPointSize;
        private static PFNGLPOLYGONMODEPROC _glPolygonMode;
        private static PFNGLSCISSORPROC _glScissor;
        private static PFNGLTEXPARAMETERFPROC _glTexParameterf;
        private static PFNGLTEXPARAMETERFVPROC _glTexParameterfv;
        private static PFNGLTEXPARAMETERIPROC _glTexParameteri;
        private static PFNGLTEXPARAMETERIVPROC _glTexParameteriv;
        private static PFNGLTEXIMAGE1DPROC _glTexImage1D;
        private static PFNGLTEXIMAGE2DPROC _glTexImage2D;
        private static PFNGLDRAWBUFFERPROC _glDrawBuffer;
        private static PFNGLCLEARPROC _glClear;
        private static PFNGLCLEARCOLORPROC _glClearColor;
        private static PFNGLCLEARSTENCILPROC _glClearStencil;
        private static PFNGLCLEARDEPTHPROC _glClearDepth;
        private static PFNGLSTENCILMASKPROC _glStencilMask;
        private static PFNGLCOLORMASKPROC _glColorMask;
        private static PFNGLDEPTHMASKPROC _glDepthMask;
        private static PFNGLDISABLEPROC _glDisable;
        private static PFNGLENABLEPROC _glEnable;
        private static PFNGLFINISHPROC _glFinish;
        private static PFNGLFLUSHPROC _glFlush;
        private static PFNGLBLENDFUNCPROC _glBlendFunc;
        private static PFNGLLOGICOPPROC _glLogicOp;
        private static PFNGLSTENCILFUNCPROC _glStencilFunc;
        private static PFNGLSTENCILOPPROC _glStencilOp;
        private static PFNGLDEPTHFUNCPROC _glDepthFunc;
        private static PFNGLPIXELSTOREFPROC _glPixelStoref;
        private static PFNGLPIXELSTOREIPROC _glPixelStorei;
        private static PFNGLREADBUFFERPROC _glReadBuffer;
        private static PFNGLREADPIXELSPROC _glReadPixels;
        private static PFNGLGETBOOLEANVPROC _glGetBooleanv;
        private static PFNGLGETDOUBLEVPROC _glGetDoublev;
        private static PFNGLGETERRORPROC _glGetError;
        private static PFNGLGETFLOATVPROC _glGetFloatv;
        private static PFNGLGETINTEGERVPROC _glGetIntegerv;
        private static PFNGLGETSTRINGPROC _glGetString;
        private static PFNGLGETTEXIMAGEPROC _glGetTexImage;
        private static PFNGLGETTEXPARAMETERFVPROC _glGetTexParameterfv;
        private static PFNGLGETTEXPARAMETERIVPROC _glGetTexParameteriv;
        private static PFNGLGETTEXLEVELPARAMETERFVPROC _glGetTexLevelParameterfv;
        private static PFNGLGETTEXLEVELPARAMETERIVPROC _glGetTexLevelParameteriv;
        private static PFNGLISENABLEDPROC _glIsEnabled;
        private static PFNGLDEPTHRANGEPROC _glDepthRange;
        private static PFNGLVIEWPORTPROC _glViewport;
        private static PFNGLDRAWARRAYSPROC _glDrawArrays;
        private static PFNGLDRAWELEMENTSPROC _glDrawElements;
        private static PFNGLPOLYGONOFFSETPROC _glPolygonOffset;
        private static PFNGLCOPYTEXIMAGE1DPROC _glCopyTexImage1D;
        private static PFNGLCOPYTEXIMAGE2DPROC _glCopyTexImage2D;
        private static PFNGLCOPYTEXSUBIMAGE1DPROC _glCopyTexSubImage1D;
        private static PFNGLCOPYTEXSUBIMAGE2DPROC _glCopyTexSubImage2D;
        private static PFNGLTEXSUBIMAGE1DPROC _glTexSubImage1D;
        private static PFNGLTEXSUBIMAGE2DPROC _glTexSubImage2D;
        private static PFNGLBINDTEXTUREPROC _glBindTexture;
        private static PFNGLDELETETEXTURESPROC _glDeleteTextures;
        private static PFNGLGENTEXTURESPROC _glGenTextures;
        private static PFNGLISTEXTUREPROC _glIsTexture;
        private static PFNGLDRAWRANGEELEMENTSPROC _glDrawRangeElements;
        private static PFNGLTEXIMAGE3DPROC _glTexImage3D;
        private static PFNGLTEXSUBIMAGE3DPROC _glTexSubImage3D;
        private static PFNGLCOPYTEXSUBIMAGE3DPROC _glCopyTexSubImage3D;
        private static PFNGLACTIVETEXTUREPROC _glActiveTexture;
        private static PFNGLSAMPLECOVERAGEPROC _glSampleCoverage;
        private static PFNGLCOMPRESSEDTEXIMAGE3DPROC _glCompressedTexImage3D;
        private static PFNGLCOMPRESSEDTEXIMAGE2DPROC _glCompressedTexImage2D;
        private static PFNGLCOMPRESSEDTEXIMAGE1DPROC _glCompressedTexImage1D;
        private static PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC _glCompressedTexSubImage3D;
        private static PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC _glCompressedTexSubImage2D;
        private static PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC _glCompressedTexSubImage1D;
        private static PFNGLGETCOMPRESSEDTEXIMAGEPROC _glGetCompressedTexImage;
        private static PFNGLBLENDFUNCSEPARATEPROC _glBlendFuncSeparate;
        private static PFNGLMULTIDRAWARRAYSPROC _glMultiDrawArrays;
        private static PFNGLMULTIDRAWELEMENTSPROC _glMultiDrawElements;
        private static PFNGLPOINTPARAMETERFPROC _glPointParameterf;
        private static PFNGLPOINTPARAMETERFVPROC _glPointParameterfv;
        private static PFNGLPOINTPARAMETERIPROC _glPointParameteri;
        private static PFNGLPOINTPARAMETERIVPROC _glPointParameteriv;
        private static PFNGLBLENDCOLORPROC _glBlendColor;
        private static PFNGLBLENDEQUATIONPROC _glBlendEquation;
        private static PFNGLGENQUERIESPROC _glGenQueries;
        private static PFNGLDELETEQUERIESPROC _glDeleteQueries;
        private static PFNGLISQUERYPROC _glIsQuery;
        private static PFNGLBEGINQUERYPROC _glBeginQuery;
        private static PFNGLENDQUERYPROC _glEndQuery;
        private static PFNGLGETQUERYIVPROC _glGetQueryiv;
        private static PFNGLGETQUERYOBJECTIVPROC _glGetQueryObjectiv;
        private static PFNGLGETQUERYOBJECTUIVPROC _glGetQueryObjectuiv;
        private static PFNGLBINDBUFFERPROC _glBindBuffer;
        private static PFNGLDELETEBUFFERSPROC _glDeleteBuffers;
        private static PFNGLGENBUFFERSPROC _glGenBuffers;
        private static PFNGLISBUFFERPROC _glIsBuffer;
        private static PFNGLBUFFERDATAPROC _glBufferData;
        private static PFNGLBUFFERSUBDATAPROC _glBufferSubData;
        private static PFNGLGETBUFFERSUBDATAPROC _glGetBufferSubData;
        private static PFNGLMAPBUFFERPROC _glMapBuffer;
        private static PFNGLUNMAPBUFFERPROC _glUnmapBuffer;
        private static PFNGLGETBUFFERPARAMETERIVPROC _glGetBufferParameteriv;
        private static PFNGLGETBUFFERPOINTERVPROC _glGetBufferPointerv;
        private static PFNGLBLENDEQUATIONSEPARATEPROC _glBlendEquationSeparate;
        private static PFNGLDRAWBUFFERSPROC _glDrawBuffers;
        private static PFNGLSTENCILOPSEPARATEPROC _glStencilOpSeparate;
        private static PFNGLSTENCILFUNCSEPARATEPROC _glStencilFuncSeparate;
        private static PFNGLSTENCILMASKSEPARATEPROC _glStencilMaskSeparate;
        private static PFNGLATTACHSHADERPROC _glAttachShader;
        private static PFNGLBINDATTRIBLOCATIONPROC _glBindAttribLocation;
        private static PFNGLCOMPILESHADERPROC _glCompileShader;
        private static PFNGLCREATEPROGRAMPROC _glCreateProgram;
        private static PFNGLCREATESHADERPROC _glCreateShader;
        private static PFNGLDELETEPROGRAMPROC _glDeleteProgram;
        private static PFNGLDELETESHADERPROC _glDeleteShader;
        private static PFNGLDETACHSHADERPROC _glDetachShader;
        private static PFNGLDISABLEVERTEXATTRIBARRAYPROC _glDisableVertexAttribArray;
        private static PFNGLENABLEVERTEXATTRIBARRAYPROC _glEnableVertexAttribArray;
        private static PFNGLGETACTIVEATTRIBPROC _glGetActiveAttrib;
        private static PFNGLGETACTIVEUNIFORMPROC _glGetActiveUniform;
        private static PFNGLGETATTACHEDSHADERSPROC _glGetAttachedShaders;
        private static PFNGLGETATTRIBLOCATIONPROC _glGetAttribLocation;
        private static PFNGLGETPROGRAMIVPROC _glGetProgramiv;
        private static PFNGLGETPROGRAMINFOLOGPROC _glGetProgramInfoLog;
        private static PFNGLGETSHADERIVPROC _glGetShaderiv;
        private static PFNGLGETSHADERINFOLOGPROC _glGetShaderInfoLog;
        private static PFNGLGETSHADERSOURCEPROC _glGetShaderSource;
        private static PFNGLGETUNIFORMLOCATIONPROC _glGetUniformLocation;
        private static PFNGLGETUNIFORMFVPROC _glGetUniformfv;
        private static PFNGLGETUNIFORMIVPROC _glGetUniformiv;
        private static PFNGLGETVERTEXATTRIBDVPROC _glGetVertexAttribdv;
        private static PFNGLGETVERTEXATTRIBFVPROC _glGetVertexAttribfv;
        private static PFNGLGETVERTEXATTRIBIVPROC _glGetVertexAttribiv;
        private static PFNGLGETVERTEXATTRIBPOINTERVPROC _glGetVertexAttribPointerv;
        private static PFNGLISPROGRAMPROC _glIsProgram;
        private static PFNGLISSHADERPROC _glIsShader;
        private static PFNGLLINKPROGRAMPROC _glLinkProgram;
        private static PFNGLSHADERSOURCEPROC _glShaderSource;
        private static PFNGLUSEPROGRAMPROC _glUseProgram;
        private static PFNGLUNIFORM1FPROC _glUniform1f;
        private static PFNGLUNIFORM2FPROC _glUniform2f;
        private static PFNGLUNIFORM3FPROC _glUniform3f;
        private static PFNGLUNIFORM4FPROC _glUniform4f;
        private static PFNGLUNIFORM1IPROC _glUniform1i;
        private static PFNGLUNIFORM2IPROC _glUniform2i;
        private static PFNGLUNIFORM3IPROC _glUniform3i;
        private static PFNGLUNIFORM4IPROC _glUniform4i;
        private static PFNGLUNIFORM1FVPROC _glUniform1fv;
        private static PFNGLUNIFORM2FVPROC _glUniform2fv;
        private static PFNGLUNIFORM3FVPROC _glUniform3fv;
        private static PFNGLUNIFORM4FVPROC _glUniform4fv;
        private static PFNGLUNIFORM1IVPROC _glUniform1iv;
        private static PFNGLUNIFORM2IVPROC _glUniform2iv;
        private static PFNGLUNIFORM3IVPROC _glUniform3iv;
        private static PFNGLUNIFORM4IVPROC _glUniform4iv;
        private static PFNGLUNIFORMMATRIX2FVPROC _glUniformMatrix2fv;
        private static PFNGLUNIFORMMATRIX3FVPROC _glUniformMatrix3fv;
        private static PFNGLUNIFORMMATRIX4FVPROC _glUniformMatrix4fv;
        private static PFNGLVALIDATEPROGRAMPROC _glValidateProgram;
        private static PFNGLVERTEXATTRIB1DPROC _glVertexAttrib1d;
        private static PFNGLVERTEXATTRIB1DVPROC _glVertexAttrib1dv;
        private static PFNGLVERTEXATTRIB1FPROC _glVertexAttrib1f;
        private static PFNGLVERTEXATTRIB1FVPROC _glVertexAttrib1fv;
        private static PFNGLVERTEXATTRIB1SPROC _glVertexAttrib1s;
        private static PFNGLVERTEXATTRIB1SVPROC _glVertexAttrib1sv;
        private static PFNGLVERTEXATTRIB2DPROC _glVertexAttrib2d;
        private static PFNGLVERTEXATTRIB2DVPROC _glVertexAttrib2dv;
        private static PFNGLVERTEXATTRIB2FPROC _glVertexAttrib2f;
        private static PFNGLVERTEXATTRIB2FVPROC _glVertexAttrib2fv;
        private static PFNGLVERTEXATTRIB2SPROC _glVertexAttrib2s;
        private static PFNGLVERTEXATTRIB2SVPROC _glVertexAttrib2sv;
        private static PFNGLVERTEXATTRIB3DPROC _glVertexAttrib3d;
        private static PFNGLVERTEXATTRIB3DVPROC _glVertexAttrib3dv;
        private static PFNGLVERTEXATTRIB3FPROC _glVertexAttrib3f;
        private static PFNGLVERTEXATTRIB3FVPROC _glVertexAttrib3fv;
        private static PFNGLVERTEXATTRIB3SPROC _glVertexAttrib3s;
        private static PFNGLVERTEXATTRIB3SVPROC _glVertexAttrib3sv;
        private static PFNGLVERTEXATTRIB4NBVPROC _glVertexAttrib4Nbv;
        private static PFNGLVERTEXATTRIB4NIVPROC _glVertexAttrib4Niv;
        private static PFNGLVERTEXATTRIB4NSVPROC _glVertexAttrib4Nsv;
        private static PFNGLVERTEXATTRIB4NUBPROC _glVertexAttrib4Nub;
        private static PFNGLVERTEXATTRIB4NUBVPROC _glVertexAttrib4Nubv;
        private static PFNGLVERTEXATTRIB4NUIVPROC _glVertexAttrib4Nuiv;
        private static PFNGLVERTEXATTRIB4NUSVPROC _glVertexAttrib4Nusv;
        private static PFNGLVERTEXATTRIB4BVPROC _glVertexAttrib4bv;
        private static PFNGLVERTEXATTRIB4DPROC _glVertexAttrib4d;
        private static PFNGLVERTEXATTRIB4DVPROC _glVertexAttrib4dv;
        private static PFNGLVERTEXATTRIB4FPROC _glVertexAttrib4f;
        private static PFNGLVERTEXATTRIB4FVPROC _glVertexAttrib4fv;
        private static PFNGLVERTEXATTRIB4IVPROC _glVertexAttrib4iv;
        private static PFNGLVERTEXATTRIB4SPROC _glVertexAttrib4s;
        private static PFNGLVERTEXATTRIB4SVPROC _glVertexAttrib4sv;
        private static PFNGLVERTEXATTRIB4UBVPROC _glVertexAttrib4ubv;
        private static PFNGLVERTEXATTRIB4UIVPROC _glVertexAttrib4uiv;
        private static PFNGLVERTEXATTRIB4USVPROC _glVertexAttrib4usv;
        private static PFNGLVERTEXATTRIBPOINTERPROC _glVertexAttribPointer;
        private static PFNGLUNIFORMMATRIX2X3FVPROC _glUniformMatrix2x3fv;
        private static PFNGLUNIFORMMATRIX3X2FVPROC _glUniformMatrix3x2fv;
        private static PFNGLUNIFORMMATRIX2X4FVPROC _glUniformMatrix2x4fv;
        private static PFNGLUNIFORMMATRIX4X2FVPROC _glUniformMatrix4x2fv;
        private static PFNGLUNIFORMMATRIX3X4FVPROC _glUniformMatrix3x4fv;
        private static PFNGLUNIFORMMATRIX4X3FVPROC _glUniformMatrix4x3fv;
        private static PFNGLCOLORMASKIPROC _glColorMaski;
        private static PFNGLGETBOOLEANI_VPROC _glGetBooleani_v;
        private static PFNGLENABLEIPROC _glEnablei;
        private static PFNGLDISABLEIPROC _glDisablei;
        private static PFNGLISENABLEDIPROC _glIsEnabledi;
        private static PFNGLBEGINTRANSFORMFEEDBACKPROC _glBeginTransformFeedback;
        private static PFNGLENDTRANSFORMFEEDBACKPROC _glEndTransformFeedback;
        private static PFNGLTRANSFORMFEEDBACKVARYINGSPROC _glTransformFeedbackVaryings;
        private static PFNGLGETTRANSFORMFEEDBACKVARYINGPROC _glGetTransformFeedbackVarying;
        private static PFNGLCLAMPCOLORPROC _glClampColor;
        private static PFNGLBEGINCONDITIONALRENDERPROC _glBeginConditionalRender;
        private static PFNGLENDCONDITIONALRENDERPROC _glEndConditionalRender;
        private static PFNGLVERTEXATTRIBIPOINTERPROC _glVertexAttribIPointer;
        private static PFNGLGETVERTEXATTRIBIIVPROC _glGetVertexAttribIiv;
        private static PFNGLGETVERTEXATTRIBIUIVPROC _glGetVertexAttribIuiv;
        private static PFNGLVERTEXATTRIBI1IPROC _glVertexAttribI1i;
        private static PFNGLVERTEXATTRIBI2IPROC _glVertexAttribI2i;
        private static PFNGLVERTEXATTRIBI3IPROC _glVertexAttribI3i;
        private static PFNGLVERTEXATTRIBI4IPROC _glVertexAttribI4i;
        private static PFNGLVERTEXATTRIBI1UIPROC _glVertexAttribI1ui;
        private static PFNGLVERTEXATTRIBI2UIPROC _glVertexAttribI2ui;
        private static PFNGLVERTEXATTRIBI3UIPROC _glVertexAttribI3ui;
        private static PFNGLVERTEXATTRIBI4UIPROC _glVertexAttribI4ui;
        private static PFNGLVERTEXATTRIBI1IVPROC _glVertexAttribI1iv;
        private static PFNGLVERTEXATTRIBI2IVPROC _glVertexAttribI2iv;
        private static PFNGLVERTEXATTRIBI3IVPROC _glVertexAttribI3iv;
        private static PFNGLVERTEXATTRIBI4IVPROC _glVertexAttribI4iv;
        private static PFNGLVERTEXATTRIBI1UIVPROC _glVertexAttribI1uiv;
        private static PFNGLVERTEXATTRIBI2UIVPROC _glVertexAttribI2uiv;
        private static PFNGLVERTEXATTRIBI3UIVPROC _glVertexAttribI3uiv;
        private static PFNGLVERTEXATTRIBI4UIVPROC _glVertexAttribI4uiv;
        private static PFNGLVERTEXATTRIBI4BVPROC _glVertexAttribI4bv;
        private static PFNGLVERTEXATTRIBI4SVPROC _glVertexAttribI4sv;
        private static PFNGLVERTEXATTRIBI4UBVPROC _glVertexAttribI4ubv;
        private static PFNGLVERTEXATTRIBI4USVPROC _glVertexAttribI4usv;
        private static PFNGLGETUNIFORMUIVPROC _glGetUniformuiv;
        private static PFNGLBINDFRAGDATALOCATIONPROC _glBindFragDataLocation;
        private static PFNGLGETFRAGDATALOCATIONPROC _glGetFragDataLocation;
        private static PFNGLUNIFORM1UIPROC _glUniform1ui;
        private static PFNGLUNIFORM2UIPROC _glUniform2ui;
        private static PFNGLUNIFORM3UIPROC _glUniform3ui;
        private static PFNGLUNIFORM4UIPROC _glUniform4ui;
        private static PFNGLUNIFORM1UIVPROC _glUniform1uiv;
        private static PFNGLUNIFORM2UIVPROC _glUniform2uiv;
        private static PFNGLUNIFORM3UIVPROC _glUniform3uiv;
        private static PFNGLUNIFORM4UIVPROC _glUniform4uiv;
        private static PFNGLTEXPARAMETERIIVPROC _glTexParameterIiv;
        private static PFNGLTEXPARAMETERIUIVPROC _glTexParameterIuiv;
        private static PFNGLGETTEXPARAMETERIIVPROC _glGetTexParameterIiv;
        private static PFNGLGETTEXPARAMETERIUIVPROC _glGetTexParameterIuiv;
        private static PFNGLCLEARBUFFERIVPROC _glClearBufferiv;
        private static PFNGLCLEARBUFFERUIVPROC _glClearBufferuiv;
        private static PFNGLCLEARBUFFERFVPROC _glClearBufferfv;
        private static PFNGLCLEARBUFFERFIPROC _glClearBufferfi;
        private static PFNGLGETSTRINGIPROC _glGetStringi;
        private static PFNGLISRENDERBUFFERPROC _glIsRenderbuffer;
        private static PFNGLBINDRENDERBUFFERPROC _glBindRenderbuffer;
        private static PFNGLDELETERENDERBUFFERSPROC _glDeleteRenderbuffers;
        private static PFNGLGENRENDERBUFFERSPROC _glGenRenderbuffers;
        private static PFNGLRENDERBUFFERSTORAGEPROC _glRenderbufferStorage;
        private static PFNGLGETRENDERBUFFERPARAMETERIVPROC _glGetRenderbufferParameteriv;
        private static PFNGLISFRAMEBUFFERPROC _glIsFramebuffer;
        private static PFNGLBINDFRAMEBUFFERPROC _glBindFramebuffer;
        private static PFNGLDELETEFRAMEBUFFERSPROC _glDeleteFramebuffers;
        private static PFNGLGENFRAMEBUFFERSPROC _glGenFramebuffers;
        private static PFNGLCHECKFRAMEBUFFERSTATUSPROC _glCheckFramebufferStatus;
        private static PFNGLFRAMEBUFFERTEXTURE1DPROC _glFramebufferTexture1D;
        private static PFNGLFRAMEBUFFERTEXTURE2DPROC _glFramebufferTexture2D;
        private static PFNGLFRAMEBUFFERTEXTURE3DPROC _glFramebufferTexture3D;
        private static PFNGLFRAMEBUFFERRENDERBUFFERPROC _glFramebufferRenderbuffer;
        private static PFNGLGETFRAMEBUFFERATTACHMENTPARAMETERIVPROC _glGetFramebufferAttachmentParameteriv;
        private static PFNGLGENERATEMIPMAPPROC _glGenerateMipmap;
        private static PFNGLBLITFRAMEBUFFERPROC _glBlitFramebuffer;
        private static PFNGLRENDERBUFFERSTORAGEMULTISAMPLEPROC _glRenderbufferStorageMultisample;
        private static PFNGLFRAMEBUFFERTEXTURELAYERPROC _glFramebufferTextureLayer;
        private static PFNGLMAPBUFFERRANGEPROC _glMapBufferRange;
        private static PFNGLFLUSHMAPPEDBUFFERRANGEPROC _glFlushMappedBufferRange;
        private static PFNGLBINDVERTEXARRAYPROC _glBindVertexArray;
        private static PFNGLDELETEVERTEXARRAYSPROC _glDeleteVertexArrays;
        private static PFNGLGENVERTEXARRAYSPROC _glGenVertexArrays;
        private static PFNGLISVERTEXARRAYPROC _glIsVertexArray;
        private static PFNGLDRAWARRAYSINSTANCEDPROC _glDrawArraysInstanced;
        private static PFNGLDRAWELEMENTSINSTANCEDPROC _glDrawElementsInstanced;
        private static PFNGLTEXBUFFERPROC _glTexBuffer;
        private static PFNGLPRIMITIVERESTARTINDEXPROC _glPrimitiveRestartIndex;
        private static PFNGLCOPYBUFFERSUBDATAPROC _glCopyBufferSubData;
        private static PFNGLGETUNIFORMINDICESPROC _glGetUniformIndices;
        private static PFNGLGETACTIVEUNIFORMSIVPROC _glGetActiveUniformsiv;
        private static PFNGLGETACTIVEUNIFORMNAMEPROC _glGetActiveUniformName;
        private static PFNGLGETUNIFORMBLOCKINDEXPROC _glGetUniformBlockIndex;
        private static PFNGLGETACTIVEUNIFORMBLOCKIVPROC _glGetActiveUniformBlockiv;
        private static PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC _glGetActiveUniformBlockName;
        private static PFNGLUNIFORMBLOCKBINDINGPROC _glUniformBlockBinding;
        private static PFNGLBINDBUFFERRANGEPROC _glBindBufferRange;
        private static PFNGLBINDBUFFERBASEPROC _glBindBufferBase;
        private static PFNGLGETINTEGERI_VPROC _glGetIntegeri_v;
        private static PFNGLDRAWELEMENTSBASEVERTEXPROC _glDrawElementsBaseVertex;
        private static PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC _glDrawRangeElementsBaseVertex;
        private static PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC _glDrawElementsInstancedBaseVertex;
        private static PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC _glMultiDrawElementsBaseVertex;
        private static PFNGLPROVOKINGVERTEXPROC _glProvokingVertex;
        private static PFNGLFENCESYNCPROC _glFenceSync;
        private static PFNGLISSYNCPROC _glIsSync;
        private static PFNGLDELETESYNCPROC _glDeleteSync;
        private static PFNGLCLIENTWAITSYNCPROC _glClientWaitSync;
        private static PFNGLWAITSYNCPROC _glWaitSync;
        private static PFNGLGETINTEGER64VPROC _glGetInteger64v;
        private static PFNGLGETSYNCIVPROC _glGetSynciv;
        private static PFNGLGETINTEGER64I_VPROC _glGetInteger64i_v;
        private static PFNGLGETBUFFERPARAMETERI64VPROC _glGetBufferParameteri64v;
        private static PFNGLFRAMEBUFFERTEXTUREPROC _glFramebufferTexture;
        private static PFNGLTEXIMAGE2DMULTISAMPLEPROC _glTexImage2DMultisample;
        private static PFNGLTEXIMAGE3DMULTISAMPLEPROC _glTexImage3DMultisample;
        private static PFNGLGETMULTISAMPLEFVPROC _glGetMultisamplefv;
        private static PFNGLSAMPLEMASKIPROC _glSampleMaski;
        private static PFNGLBINDFRAGDATALOCATIONINDEXEDPROC _glBindFragDataLocationIndexed;
        private static PFNGLGETFRAGDATAINDEXPROC _glGetFragDataIndex;
        private static PFNGLGENSAMPLERSPROC _glGenSamplers;
        private static PFNGLDELETESAMPLERSPROC _glDeleteSamplers;
        private static PFNGLISSAMPLERPROC _glIsSampler;
        private static PFNGLBINDSAMPLERPROC _glBindSampler;
        private static PFNGLSAMPLERPARAMETERIPROC _glSamplerParameteri;
        private static PFNGLSAMPLERPARAMETERIVPROC _glSamplerParameteriv;
        private static PFNGLSAMPLERPARAMETERFPROC _glSamplerParameterf;
        private static PFNGLSAMPLERPARAMETERFVPROC _glSamplerParameterfv;
        private static PFNGLSAMPLERPARAMETERIIVPROC _glSamplerParameterIiv;
        private static PFNGLSAMPLERPARAMETERIUIVPROC _glSamplerParameterIuiv;
        private static PFNGLGETSAMPLERPARAMETERIVPROC _glGetSamplerParameteriv;
        private static PFNGLGETSAMPLERPARAMETERIIVPROC _glGetSamplerParameterIiv;
        private static PFNGLGETSAMPLERPARAMETERFVPROC _glGetSamplerParameterfv;
        private static PFNGLGETSAMPLERPARAMETERIUIVPROC _glGetSamplerParameterIuiv;
        private static PFNGLQUERYCOUNTERPROC _glQueryCounter;
        private static PFNGLGETQUERYOBJECTI64VPROC _glGetQueryObjecti64v;
        private static PFNGLGETQUERYOBJECTUI64VPROC _glGetQueryObjectui64v;
        private static PFNGLVERTEXATTRIBDIVISORPROC _glVertexAttribDivisor;
        private static PFNGLVERTEXATTRIBP1UIPROC _glVertexAttribP1ui;
        private static PFNGLVERTEXATTRIBP1UIVPROC _glVertexAttribP1uiv;
        private static PFNGLVERTEXATTRIBP2UIPROC _glVertexAttribP2ui;
        private static PFNGLVERTEXATTRIBP2UIVPROC _glVertexAttribP2uiv;
        private static PFNGLVERTEXATTRIBP3UIPROC _glVertexAttribP3ui;
        private static PFNGLVERTEXATTRIBP3UIVPROC _glVertexAttribP3uiv;
        private static PFNGLVERTEXATTRIBP4UIPROC _glVertexAttribP4ui;
        private static PFNGLVERTEXATTRIBP4UIVPROC _glVertexAttribP4uiv;
        private static PFNGLVERTEXP2UIPROC _glVertexP2ui;
        private static PFNGLVERTEXP2UIVPROC _glVertexP2uiv;
        private static PFNGLVERTEXP3UIPROC _glVertexP3ui;
        private static PFNGLVERTEXP3UIVPROC _glVertexP3uiv;
        private static PFNGLVERTEXP4UIPROC _glVertexP4ui;
        private static PFNGLVERTEXP4UIVPROC _glVertexP4uiv;
        private static PFNGLTEXCOORDP1UIPROC _glTexCoordP1ui;
        private static PFNGLTEXCOORDP1UIVPROC _glTexCoordP1uiv;
        private static PFNGLTEXCOORDP2UIPROC _glTexCoordP2ui;
        private static PFNGLTEXCOORDP2UIVPROC _glTexCoordP2uiv;
        private static PFNGLTEXCOORDP3UIPROC _glTexCoordP3ui;
        private static PFNGLTEXCOORDP3UIVPROC _glTexCoordP3uiv;
        private static PFNGLTEXCOORDP4UIPROC _glTexCoordP4ui;
        private static PFNGLTEXCOORDP4UIVPROC _glTexCoordP4uiv;
        private static PFNGLMULTITEXCOORDP1UIPROC _glMultiTexCoordP1ui;
        private static PFNGLMULTITEXCOORDP1UIVPROC _glMultiTexCoordP1uiv;
        private static PFNGLMULTITEXCOORDP2UIPROC _glMultiTexCoordP2ui;
        private static PFNGLMULTITEXCOORDP2UIVPROC _glMultiTexCoordP2uiv;
        private static PFNGLMULTITEXCOORDP3UIPROC _glMultiTexCoordP3ui;
        private static PFNGLMULTITEXCOORDP3UIVPROC _glMultiTexCoordP3uiv;
        private static PFNGLMULTITEXCOORDP4UIPROC _glMultiTexCoordP4ui;
        private static PFNGLMULTITEXCOORDP4UIVPROC _glMultiTexCoordP4uiv;
        private static PFNGLNORMALP3UIPROC _glNormalP3ui;
        private static PFNGLNORMALP3UIVPROC _glNormalP3uiv;
        private static PFNGLCOLORP3UIPROC _glColorP3ui;
        private static PFNGLCOLORP3UIVPROC _glColorP3uiv;
        private static PFNGLCOLORP4UIPROC _glColorP4ui;
        private static PFNGLCOLORP4UIVPROC _glColorP4uiv;
        private static PFNGLSECONDARYCOLORP3UIPROC _glSecondaryColorP3ui;
        private static PFNGLSECONDARYCOLORP3UIVPROC _glSecondaryColorP3uiv;

        /// <summary>
        ///     Imports all OpenGL functions using the specified loader.
        /// </summary>
        /// <param name="loader">A loader to retrieve a fuction pointer.</param>
        public static void Import(GetProcAddressHandler loader)
        {
            _glCullFace = Marshal.GetDelegateForFunctionPointer<PFNGLCULLFACEPROC>(loader.Invoke("glCullFace"));
            _glFrontFace = Marshal.GetDelegateForFunctionPointer<PFNGLFRONTFACEPROC>(loader.Invoke("glFrontFace"));
            _glHint = Marshal.GetDelegateForFunctionPointer<PFNGLHINTPROC>(loader.Invoke("glHint"));
            _glLineWidth = Marshal.GetDelegateForFunctionPointer<PFNGLLINEWIDTHPROC>(loader.Invoke("glLineWidth"));
            _glPointSize = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTSIZEPROC>(loader.Invoke("glPointSize"));
            _glPolygonMode = Marshal.GetDelegateForFunctionPointer<PFNGLPOLYGONMODEPROC>(loader.Invoke("glPolygonMode"));
            _glScissor = Marshal.GetDelegateForFunctionPointer<PFNGLSCISSORPROC>(loader.Invoke("glScissor"));
            _glTexParameterf = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERFPROC>(loader.Invoke("glTexParameterf"));
            _glTexParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERFVPROC>(loader.Invoke("glTexParameterfv"));
            _glTexParameteri = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIPROC>(loader.Invoke("glTexParameteri"));
            _glTexParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIVPROC>(loader.Invoke("glTexParameteriv"));
            _glTexImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE1DPROC>(loader.Invoke("glTexImage1D"));
            _glTexImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE2DPROC>(loader.Invoke("glTexImage2D"));
            _glDrawBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWBUFFERPROC>(loader.Invoke("glDrawBuffer"));
            _glClear = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARPROC>(loader.Invoke("glClear"));
            _glClearColor = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARCOLORPROC>(loader.Invoke("glClearColor"));
            _glClearStencil = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARSTENCILPROC>(loader.Invoke("glClearStencil"));
            _glClearDepth = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARDEPTHPROC>(loader.Invoke("glClearDepth"));
            _glStencilMask = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILMASKPROC>(loader.Invoke("glStencilMask"));
            _glColorMask = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORMASKPROC>(loader.Invoke("glColorMask"));
            _glDepthMask = Marshal.GetDelegateForFunctionPointer<PFNGLDEPTHMASKPROC>(loader.Invoke("glDepthMask"));
            _glDisable = Marshal.GetDelegateForFunctionPointer<PFNGLDISABLEPROC>(loader.Invoke("glDisable"));
            _glEnable = Marshal.GetDelegateForFunctionPointer<PFNGLENABLEPROC>(loader.Invoke("glEnable"));
            _glFinish = Marshal.GetDelegateForFunctionPointer<PFNGLFINISHPROC>(loader.Invoke("glFinish"));
            _glFlush = Marshal.GetDelegateForFunctionPointer<PFNGLFLUSHPROC>(loader.Invoke("glFlush"));
            _glBlendFunc = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDFUNCPROC>(loader.Invoke("glBlendFunc"));
            _glLogicOp = Marshal.GetDelegateForFunctionPointer<PFNGLLOGICOPPROC>(loader.Invoke("glLogicOp"));
            _glStencilFunc = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILFUNCPROC>(loader.Invoke("glStencilFunc"));
            _glStencilOp = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILOPPROC>(loader.Invoke("glStencilOp"));
            _glDepthFunc = Marshal.GetDelegateForFunctionPointer<PFNGLDEPTHFUNCPROC>(loader.Invoke("glDepthFunc"));
            _glPixelStoref = Marshal.GetDelegateForFunctionPointer<PFNGLPIXELSTOREFPROC>(loader.Invoke("glPixelStoref"));
            _glPixelStorei = Marshal.GetDelegateForFunctionPointer<PFNGLPIXELSTOREIPROC>(loader.Invoke("glPixelStorei"));
            _glReadBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLREADBUFFERPROC>(loader.Invoke("glReadBuffer"));
            _glReadPixels = Marshal.GetDelegateForFunctionPointer<PFNGLREADPIXELSPROC>(loader.Invoke("glReadPixels"));
            _glGetBooleanv = Marshal.GetDelegateForFunctionPointer<PFNGLGETBOOLEANVPROC>(loader.Invoke("glGetBooleanv"));
            _glGetDoublev = Marshal.GetDelegateForFunctionPointer<PFNGLGETDOUBLEVPROC>(loader.Invoke("glGetDoublev"));
            _glGetError = Marshal.GetDelegateForFunctionPointer<PFNGLGETERRORPROC>(loader.Invoke("glGetError"));
            _glGetFloatv = Marshal.GetDelegateForFunctionPointer<PFNGLGETFLOATVPROC>(loader.Invoke("glGetFloatv"));
            _glGetIntegerv = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGERVPROC>(loader.Invoke("glGetIntegerv"));
            _glGetString = Marshal.GetDelegateForFunctionPointer<PFNGLGETSTRINGPROC>(loader.Invoke("glGetString"));
            _glGetTexImage = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXIMAGEPROC>(loader.Invoke("glGetTexImage"));
            _glGetTexParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERFVPROC>(loader.Invoke("glGetTexParameterfv"));
            _glGetTexParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERIVPROC>(loader.Invoke("glGetTexParameteriv"));
            _glGetTexLevelParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXLEVELPARAMETERFVPROC>(loader.Invoke("glGetTexLevelParameterfv"));
            _glGetTexLevelParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXLEVELPARAMETERIVPROC>(loader.Invoke("glGetTexLevelParameteriv"));
            _glIsEnabled = Marshal.GetDelegateForFunctionPointer<PFNGLISENABLEDPROC>(loader.Invoke("glIsEnabled"));
            _glDepthRange = Marshal.GetDelegateForFunctionPointer<PFNGLDEPTHRANGEPROC>(loader.Invoke("glDepthRange"));
            _glViewport = Marshal.GetDelegateForFunctionPointer<PFNGLVIEWPORTPROC>(loader.Invoke("glViewport"));
            _glDrawArrays = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWARRAYSPROC>(loader.Invoke("glDrawArrays"));
            _glDrawElements = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSPROC>(loader.Invoke("glDrawElements"));
            _glPolygonOffset = Marshal.GetDelegateForFunctionPointer<PFNGLPOLYGONOFFSETPROC>(loader.Invoke("glPolygonOffset"));
            _glCopyTexImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXIMAGE1DPROC>(loader.Invoke("glCopyTexImage1D"));
            _glCopyTexImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXIMAGE2DPROC>(loader.Invoke("glCopyTexImage2D"));
            _glCopyTexSubImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXSUBIMAGE1DPROC>(loader.Invoke("glCopyTexSubImage1D"));
            _glCopyTexSubImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXSUBIMAGE2DPROC>(loader.Invoke("glCopyTexSubImage2D"));
            _glTexSubImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXSUBIMAGE1DPROC>(loader.Invoke("glTexSubImage1D"));
            _glTexSubImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXSUBIMAGE2DPROC>(loader.Invoke("glTexSubImage2D"));
            _glBindTexture = Marshal.GetDelegateForFunctionPointer<PFNGLBINDTEXTUREPROC>(loader.Invoke("glBindTexture"));
            _glDeleteTextures = Marshal.GetDelegateForFunctionPointer<PFNGLDELETETEXTURESPROC>(loader.Invoke("glDeleteTextures"));
            _glGenTextures = Marshal.GetDelegateForFunctionPointer<PFNGLGENTEXTURESPROC>(loader.Invoke("glGenTextures"));
            _glIsTexture = Marshal.GetDelegateForFunctionPointer<PFNGLISTEXTUREPROC>(loader.Invoke("glIsTexture"));
            _glDrawRangeElements = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWRANGEELEMENTSPROC>(loader.Invoke("glDrawRangeElements"));
            _glTexImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE3DPROC>(loader.Invoke("glTexImage3D"));
            _glTexSubImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXSUBIMAGE3DPROC>(loader.Invoke("glTexSubImage3D"));
            _glCopyTexSubImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXSUBIMAGE3DPROC>(loader.Invoke("glCopyTexSubImage3D"));
            _glActiveTexture = Marshal.GetDelegateForFunctionPointer<PFNGLACTIVETEXTUREPROC>(loader.Invoke("glActiveTexture"));
            _glSampleCoverage = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLECOVERAGEPROC>(loader.Invoke("glSampleCoverage"));
            _glCompressedTexImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXIMAGE3DPROC>(loader.Invoke("glCompressedTexImage3D"));
            _glCompressedTexImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXIMAGE2DPROC>(loader.Invoke("glCompressedTexImage2D"));
            _glCompressedTexImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXIMAGE1DPROC>(loader.Invoke("glCompressedTexImage1D"));
            _glCompressedTexSubImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC>(loader.Invoke("glCompressedTexSubImage3D"));
            _glCompressedTexSubImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC>(loader.Invoke("glCompressedTexSubImage2D"));
            _glCompressedTexSubImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC>(loader.Invoke("glCompressedTexSubImage1D"));
            _glGetCompressedTexImage = Marshal.GetDelegateForFunctionPointer<PFNGLGETCOMPRESSEDTEXIMAGEPROC>(loader.Invoke("glGetCompressedTexImage"));
            _glBlendFuncSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDFUNCSEPARATEPROC>(loader.Invoke("glBlendFuncSeparate"));
            _glMultiDrawArrays = Marshal.GetDelegateForFunctionPointer<PFNGLMULTIDRAWARRAYSPROC>(loader.Invoke("glMultiDrawArrays"));
            _glMultiDrawElements = Marshal.GetDelegateForFunctionPointer<PFNGLMULTIDRAWELEMENTSPROC>(loader.Invoke("glMultiDrawElements"));
            _glPointParameterf = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERFPROC>(loader.Invoke("glPointParameterf"));
            _glPointParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERFVPROC>(loader.Invoke("glPointParameterfv"));
            _glPointParameteri = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERIPROC>(loader.Invoke("glPointParameteri"));
            _glPointParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERIVPROC>(loader.Invoke("glPointParameteriv"));
            _glBlendColor = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDCOLORPROC>(loader.Invoke("glBlendColor"));
            _glBlendEquation = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDEQUATIONPROC>(loader.Invoke("glBlendEquation"));
            _glGenQueries = Marshal.GetDelegateForFunctionPointer<PFNGLGENQUERIESPROC>(loader.Invoke("glGenQueries"));
            _glDeleteQueries = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEQUERIESPROC>(loader.Invoke("glDeleteQueries"));
            _glIsQuery = Marshal.GetDelegateForFunctionPointer<PFNGLISQUERYPROC>(loader.Invoke("glIsQuery"));
            _glBeginQuery = Marshal.GetDelegateForFunctionPointer<PFNGLBEGINQUERYPROC>(loader.Invoke("glBeginQuery"));
            _glEndQuery = Marshal.GetDelegateForFunctionPointer<PFNGLENDQUERYPROC>(loader.Invoke("glEndQuery"));
            _glGetQueryiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYIVPROC>(loader.Invoke("glGetQueryiv"));
            _glGetQueryObjectiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTIVPROC>(loader.Invoke("glGetQueryObjectiv"));
            _glGetQueryObjectuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTUIVPROC>(loader.Invoke("glGetQueryObjectuiv"));
            _glBindBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERPROC>(loader.Invoke("glBindBuffer"));
            _glDeleteBuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEBUFFERSPROC>(loader.Invoke("glDeleteBuffers"));
            _glGenBuffers = Marshal.GetDelegateForFunctionPointer<PFNGLGENBUFFERSPROC>(loader.Invoke("glGenBuffers"));
            _glIsBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLISBUFFERPROC>(loader.Invoke("glIsBuffer"));
            _glBufferData = Marshal.GetDelegateForFunctionPointer<PFNGLBUFFERDATAPROC>(loader.Invoke("glBufferData"));
            _glBufferSubData = Marshal.GetDelegateForFunctionPointer<PFNGLBUFFERSUBDATAPROC>(loader.Invoke("glBufferSubData"));
            _glGetBufferSubData = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERSUBDATAPROC>(loader.Invoke("glGetBufferSubData"));
            _glMapBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLMAPBUFFERPROC>(loader.Invoke("glMapBuffer"));
            _glUnmapBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLUNMAPBUFFERPROC>(loader.Invoke("glUnmapBuffer"));
            _glGetBufferParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERPARAMETERIVPROC>(loader.Invoke("glGetBufferParameteriv"));
            _glGetBufferPointerv = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERPOINTERVPROC>(loader.Invoke("glGetBufferPointerv"));
            _glBlendEquationSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDEQUATIONSEPARATEPROC>(loader.Invoke("glBlendEquationSeparate"));
            _glDrawBuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWBUFFERSPROC>(loader.Invoke("glDrawBuffers"));
            _glStencilOpSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILOPSEPARATEPROC>(loader.Invoke("glStencilOpSeparate"));
            _glStencilFuncSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILFUNCSEPARATEPROC>(loader.Invoke("glStencilFuncSeparate"));
            _glStencilMaskSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILMASKSEPARATEPROC>(loader.Invoke("glStencilMaskSeparate"));
            _glAttachShader = Marshal.GetDelegateForFunctionPointer<PFNGLATTACHSHADERPROC>(loader.Invoke("glAttachShader"));
            _glBindAttribLocation = Marshal.GetDelegateForFunctionPointer<PFNGLBINDATTRIBLOCATIONPROC>(loader.Invoke("glBindAttribLocation"));
            _glCompileShader = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPILESHADERPROC>(loader.Invoke("glCompileShader"));
            _glCreateProgram = Marshal.GetDelegateForFunctionPointer<PFNGLCREATEPROGRAMPROC>(loader.Invoke("glCreateProgram"));
            _glCreateShader = Marshal.GetDelegateForFunctionPointer<PFNGLCREATESHADERPROC>(loader.Invoke("glCreateShader"));
            _glDeleteProgram = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEPROGRAMPROC>(loader.Invoke("glDeleteProgram"));
            _glDeleteShader = Marshal.GetDelegateForFunctionPointer<PFNGLDELETESHADERPROC>(loader.Invoke("glDeleteShader"));
            _glDetachShader = Marshal.GetDelegateForFunctionPointer<PFNGLDETACHSHADERPROC>(loader.Invoke("glDetachShader"));
            _glDisableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<PFNGLDISABLEVERTEXATTRIBARRAYPROC>(loader.Invoke("glDisableVertexAttribArray"));
            _glEnableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<PFNGLENABLEVERTEXATTRIBARRAYPROC>(loader.Invoke("glEnableVertexAttribArray"));
            _glGetActiveAttrib = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEATTRIBPROC>(loader.Invoke("glGetActiveAttrib"));
            _glGetActiveUniform = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMPROC>(loader.Invoke("glGetActiveUniform"));
            _glGetAttachedShaders = Marshal.GetDelegateForFunctionPointer<PFNGLGETATTACHEDSHADERSPROC>(loader.Invoke("glGetAttachedShaders"));
            _glGetAttribLocation = Marshal.GetDelegateForFunctionPointer<PFNGLGETATTRIBLOCATIONPROC>(loader.Invoke("glGetAttribLocation"));
            _glGetProgramiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETPROGRAMIVPROC>(loader.Invoke("glGetProgramiv"));
            _glGetProgramInfoLog = Marshal.GetDelegateForFunctionPointer<PFNGLGETPROGRAMINFOLOGPROC>(loader.Invoke("glGetProgramInfoLog"));
            _glGetShaderiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSHADERIVPROC>(loader.Invoke("glGetShaderiv"));
            _glGetShaderInfoLog = Marshal.GetDelegateForFunctionPointer<PFNGLGETSHADERINFOLOGPROC>(loader.Invoke("glGetShaderInfoLog"));
            _glGetShaderSource = Marshal.GetDelegateForFunctionPointer<PFNGLGETSHADERSOURCEPROC>(loader.Invoke("glGetShaderSource"));
            _glGetUniformLocation = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMLOCATIONPROC>(loader.Invoke("glGetUniformLocation"));
            _glGetUniformfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMFVPROC>(loader.Invoke("glGetUniformfv"));
            _glGetUniformiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMIVPROC>(loader.Invoke("glGetUniformiv"));
            _glGetVertexAttribdv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBDVPROC>(loader.Invoke("glGetVertexAttribdv"));
            _glGetVertexAttribfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBFVPROC>(loader.Invoke("glGetVertexAttribfv"));
            _glGetVertexAttribiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBIVPROC>(loader.Invoke("glGetVertexAttribiv"));
            _glGetVertexAttribPointerv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBPOINTERVPROC>(loader.Invoke("glGetVertexAttribPointerv"));
            _glIsProgram = Marshal.GetDelegateForFunctionPointer<PFNGLISPROGRAMPROC>(loader.Invoke("glIsProgram"));
            _glIsShader = Marshal.GetDelegateForFunctionPointer<PFNGLISSHADERPROC>(loader.Invoke("glIsShader"));
            _glLinkProgram = Marshal.GetDelegateForFunctionPointer<PFNGLLINKPROGRAMPROC>(loader.Invoke("glLinkProgram"));
            _glShaderSource = Marshal.GetDelegateForFunctionPointer<PFNGLSHADERSOURCEPROC>(loader.Invoke("glShaderSource"));
            _glUseProgram = Marshal.GetDelegateForFunctionPointer<PFNGLUSEPROGRAMPROC>(loader.Invoke("glUseProgram"));
            _glUniform1f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1FPROC>(loader.Invoke("glUniform1f"));
            _glUniform2f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2FPROC>(loader.Invoke("glUniform2f"));
            _glUniform3f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3FPROC>(loader.Invoke("glUniform3f"));
            _glUniform4f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4FPROC>(loader.Invoke("glUniform4f"));
            _glUniform1i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1IPROC>(loader.Invoke("glUniform1i"));
            _glUniform2i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2IPROC>(loader.Invoke("glUniform2i"));
            _glUniform3i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3IPROC>(loader.Invoke("glUniform3i"));
            _glUniform4i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4IPROC>(loader.Invoke("glUniform4i"));
            _glUniform1fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1FVPROC>(loader.Invoke("glUniform1fv"));
            _glUniform2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2FVPROC>(loader.Invoke("glUniform2fv"));
            _glUniform3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3FVPROC>(loader.Invoke("glUniform3fv"));
            _glUniform4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4FVPROC>(loader.Invoke("glUniform4fv"));
            _glUniform1iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1IVPROC>(loader.Invoke("glUniform1iv"));
            _glUniform2iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2IVPROC>(loader.Invoke("glUniform2iv"));
            _glUniform3iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3IVPROC>(loader.Invoke("glUniform3iv"));
            _glUniform4iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4IVPROC>(loader.Invoke("glUniform4iv"));
            _glUniformMatrix2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX2FVPROC>(loader.Invoke("glUniformMatrix2fv"));
            _glUniformMatrix3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX3FVPROC>(loader.Invoke("glUniformMatrix3fv"));
            _glUniformMatrix4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX4FVPROC>(loader.Invoke("glUniformMatrix4fv"));
            _glValidateProgram = Marshal.GetDelegateForFunctionPointer<PFNGLVALIDATEPROGRAMPROC>(loader.Invoke("glValidateProgram"));
            _glVertexAttrib1d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1DPROC>(loader.Invoke("glVertexAttrib1d"));
            _glVertexAttrib1dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1DVPROC>(loader.Invoke("glVertexAttrib1dv"));
            _glVertexAttrib1f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1FPROC>(loader.Invoke("glVertexAttrib1f"));
            _glVertexAttrib1fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1FVPROC>(loader.Invoke("glVertexAttrib1fv"));
            _glVertexAttrib1s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1SPROC>(loader.Invoke("glVertexAttrib1s"));
            _glVertexAttrib1sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1SVPROC>(loader.Invoke("glVertexAttrib1sv"));
            _glVertexAttrib2d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2DPROC>(loader.Invoke("glVertexAttrib2d"));
            _glVertexAttrib2dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2DVPROC>(loader.Invoke("glVertexAttrib2dv"));
            _glVertexAttrib2f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2FPROC>(loader.Invoke("glVertexAttrib2f"));
            _glVertexAttrib2fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2FVPROC>(loader.Invoke("glVertexAttrib2fv"));
            _glVertexAttrib2s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2SPROC>(loader.Invoke("glVertexAttrib2s"));
            _glVertexAttrib2sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2SVPROC>(loader.Invoke("glVertexAttrib2sv"));
            _glVertexAttrib3d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3DPROC>(loader.Invoke("glVertexAttrib3d"));
            _glVertexAttrib3dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3DVPROC>(loader.Invoke("glVertexAttrib3dv"));
            _glVertexAttrib3f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3FPROC>(loader.Invoke("glVertexAttrib3f"));
            _glVertexAttrib3fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3FVPROC>(loader.Invoke("glVertexAttrib3fv"));
            _glVertexAttrib3s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3SPROC>(loader.Invoke("glVertexAttrib3s"));
            _glVertexAttrib3sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3SVPROC>(loader.Invoke("glVertexAttrib3sv"));
            _glVertexAttrib4Nbv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NBVPROC>(loader.Invoke("glVertexAttrib4Nbv"));
            _glVertexAttrib4Niv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NIVPROC>(loader.Invoke("glVertexAttrib4Niv"));
            _glVertexAttrib4Nsv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NSVPROC>(loader.Invoke("glVertexAttrib4Nsv"));
            _glVertexAttrib4Nub = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUBPROC>(loader.Invoke("glVertexAttrib4Nub"));
            _glVertexAttrib4Nubv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUBVPROC>(loader.Invoke("glVertexAttrib4Nubv"));
            _glVertexAttrib4Nuiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUIVPROC>(loader.Invoke("glVertexAttrib4Nuiv"));
            _glVertexAttrib4Nusv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUSVPROC>(loader.Invoke("glVertexAttrib4Nusv"));
            _glVertexAttrib4bv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4BVPROC>(loader.Invoke("glVertexAttrib4bv"));
            _glVertexAttrib4d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4DPROC>(loader.Invoke("glVertexAttrib4d"));
            _glVertexAttrib4dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4DVPROC>(loader.Invoke("glVertexAttrib4dv"));
            _glVertexAttrib4f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4FPROC>(loader.Invoke("glVertexAttrib4f"));
            _glVertexAttrib4fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4FVPROC>(loader.Invoke("glVertexAttrib4fv"));
            _glVertexAttrib4iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4IVPROC>(loader.Invoke("glVertexAttrib4iv"));
            _glVertexAttrib4s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4SPROC>(loader.Invoke("glVertexAttrib4s"));
            _glVertexAttrib4sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4SVPROC>(loader.Invoke("glVertexAttrib4sv"));
            _glVertexAttrib4ubv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4UBVPROC>(loader.Invoke("glVertexAttrib4ubv"));
            _glVertexAttrib4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4UIVPROC>(loader.Invoke("glVertexAttrib4uiv"));
            _glVertexAttrib4usv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4USVPROC>(loader.Invoke("glVertexAttrib4usv"));
            _glVertexAttribPointer = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBPOINTERPROC>(loader.Invoke("glVertexAttribPointer"));
            _glUniformMatrix2x3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX2X3FVPROC>(loader.Invoke("glUniformMatrix2x3fv"));
            _glUniformMatrix3x2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX3X2FVPROC>(loader.Invoke("glUniformMatrix3x2fv"));
            _glUniformMatrix2x4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX2X4FVPROC>(loader.Invoke("glUniformMatrix2x4fv"));
            _glUniformMatrix4x2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX4X2FVPROC>(loader.Invoke("glUniformMatrix4x2fv"));
            _glUniformMatrix3x4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX3X4FVPROC>(loader.Invoke("glUniformMatrix3x4fv"));
            _glUniformMatrix4x3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX4X3FVPROC>(loader.Invoke("glUniformMatrix4x3fv"));
            _glColorMaski = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORMASKIPROC>(loader.Invoke("glColorMaski"));
            _glGetBooleani_v = Marshal.GetDelegateForFunctionPointer<PFNGLGETBOOLEANI_VPROC>(loader.Invoke("glGetBooleani_v"));
            _glGetIntegeri_v = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGERI_VPROC>(loader.Invoke("glGetIntegeri_v"));
            _glEnablei = Marshal.GetDelegateForFunctionPointer<PFNGLENABLEIPROC>(loader.Invoke("glEnablei"));
            _glDisablei = Marshal.GetDelegateForFunctionPointer<PFNGLDISABLEIPROC>(loader.Invoke("glDisablei"));
            _glIsEnabledi = Marshal.GetDelegateForFunctionPointer<PFNGLISENABLEDIPROC>(loader.Invoke("glIsEnabledi"));
            _glBeginTransformFeedback = Marshal.GetDelegateForFunctionPointer<PFNGLBEGINTRANSFORMFEEDBACKPROC>(loader.Invoke("glBeginTransformFeedback"));
            _glEndTransformFeedback = Marshal.GetDelegateForFunctionPointer<PFNGLENDTRANSFORMFEEDBACKPROC>(loader.Invoke("glEndTransformFeedback"));
            _glBindBufferRange = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERRANGEPROC>(loader.Invoke("glBindBufferRange"));
            _glBindBufferBase = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERBASEPROC>(loader.Invoke("glBindBufferBase"));
            _glTransformFeedbackVaryings = Marshal.GetDelegateForFunctionPointer<PFNGLTRANSFORMFEEDBACKVARYINGSPROC>(loader.Invoke("glTransformFeedbackVaryings"));
            _glGetTransformFeedbackVarying = Marshal.GetDelegateForFunctionPointer<PFNGLGETTRANSFORMFEEDBACKVARYINGPROC>(loader.Invoke("glGetTransformFeedbackVarying"));
            _glClampColor = Marshal.GetDelegateForFunctionPointer<PFNGLCLAMPCOLORPROC>(loader.Invoke("glClampColor"));
            _glBeginConditionalRender = Marshal.GetDelegateForFunctionPointer<PFNGLBEGINCONDITIONALRENDERPROC>(loader.Invoke("glBeginConditionalRender"));
            _glEndConditionalRender = Marshal.GetDelegateForFunctionPointer<PFNGLENDCONDITIONALRENDERPROC>(loader.Invoke("glEndConditionalRender"));
            _glVertexAttribIPointer = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBIPOINTERPROC>(loader.Invoke("glVertexAttribIPointer"));
            _glGetVertexAttribIiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBIIVPROC>(loader.Invoke("glGetVertexAttribIiv"));
            _glGetVertexAttribIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBIUIVPROC>(loader.Invoke("glGetVertexAttribIuiv"));
            _glVertexAttribI1i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1IPROC>(loader.Invoke("glVertexAttribI1i"));
            _glVertexAttribI2i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2IPROC>(loader.Invoke("glVertexAttribI2i"));
            _glVertexAttribI3i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3IPROC>(loader.Invoke("glVertexAttribI3i"));
            _glVertexAttribI4i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4IPROC>(loader.Invoke("glVertexAttribI4i"));
            _glVertexAttribI1ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1UIPROC>(loader.Invoke("glVertexAttribI1ui"));
            _glVertexAttribI2ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2UIPROC>(loader.Invoke("glVertexAttribI2ui"));
            _glVertexAttribI3ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3UIPROC>(loader.Invoke("glVertexAttribI3ui"));
            _glVertexAttribI4ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4UIPROC>(loader.Invoke("glVertexAttribI4ui"));
            _glVertexAttribI1iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1IVPROC>(loader.Invoke("glVertexAttribI1iv"));
            _glVertexAttribI2iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2IVPROC>(loader.Invoke("glVertexAttribI2iv"));
            _glVertexAttribI3iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3IVPROC>(loader.Invoke("glVertexAttribI3iv"));
            _glVertexAttribI4iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4IVPROC>(loader.Invoke("glVertexAttribI4iv"));
            _glVertexAttribI1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1UIVPROC>(loader.Invoke("glVertexAttribI1uiv"));
            _glVertexAttribI2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2UIVPROC>(loader.Invoke("glVertexAttribI2uiv"));
            _glVertexAttribI3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3UIVPROC>(loader.Invoke("glVertexAttribI3uiv"));
            _glVertexAttribI4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4UIVPROC>(loader.Invoke("glVertexAttribI4uiv"));
            _glVertexAttribI4bv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4BVPROC>(loader.Invoke("glVertexAttribI4bv"));
            _glVertexAttribI4sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4SVPROC>(loader.Invoke("glVertexAttribI4sv"));
            _glVertexAttribI4ubv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4UBVPROC>(loader.Invoke("glVertexAttribI4ubv"));
            _glVertexAttribI4usv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4USVPROC>(loader.Invoke("glVertexAttribI4usv"));
            _glGetUniformuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMUIVPROC>(loader.Invoke("glGetUniformuiv"));
            _glBindFragDataLocation = Marshal.GetDelegateForFunctionPointer<PFNGLBINDFRAGDATALOCATIONPROC>(loader.Invoke("glBindFragDataLocation"));
            _glGetFragDataLocation = Marshal.GetDelegateForFunctionPointer<PFNGLGETFRAGDATALOCATIONPROC>(loader.Invoke("glGetFragDataLocation"));
            _glUniform1ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1UIPROC>(loader.Invoke("glUniform1ui"));
            _glUniform2ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2UIPROC>(loader.Invoke("glUniform2ui"));
            _glUniform3ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3UIPROC>(loader.Invoke("glUniform3ui"));
            _glUniform4ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4UIPROC>(loader.Invoke("glUniform4ui"));
            _glUniform1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1UIVPROC>(loader.Invoke("glUniform1uiv"));
            _glUniform2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2UIVPROC>(loader.Invoke("glUniform2uiv"));
            _glUniform3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3UIVPROC>(loader.Invoke("glUniform3uiv"));
            _glUniform4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4UIVPROC>(loader.Invoke("glUniform4uiv"));
            _glTexParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIIVPROC>(loader.Invoke("glTexParameterIiv"));
            _glTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIUIVPROC>(loader.Invoke("glTexParameterIuiv"));
            _glGetTexParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERIIVPROC>(loader.Invoke("glGetTexParameterIiv"));
            _glGetTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERIUIVPROC>(loader.Invoke("glGetTexParameterIuiv"));
            _glClearBufferiv = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERIVPROC>(loader.Invoke("glClearBufferiv"));
            _glClearBufferuiv = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERUIVPROC>(loader.Invoke("glClearBufferuiv"));
            _glClearBufferfv = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERFVPROC>(loader.Invoke("glClearBufferfv"));
            _glClearBufferfi = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERFIPROC>(loader.Invoke("glClearBufferfi"));
            _glGetStringi = Marshal.GetDelegateForFunctionPointer<PFNGLGETSTRINGIPROC>(loader.Invoke("glGetStringi"));
            _glIsRenderbuffer = Marshal.GetDelegateForFunctionPointer<PFNGLISRENDERBUFFERPROC>(loader.Invoke("glIsRenderbuffer"));
            _glBindRenderbuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBINDRENDERBUFFERPROC>(loader.Invoke("glBindRenderbuffer"));
            _glDeleteRenderbuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETERENDERBUFFERSPROC>(loader.Invoke("glDeleteRenderbuffers"));
            _glGenRenderbuffers = Marshal.GetDelegateForFunctionPointer<PFNGLGENRENDERBUFFERSPROC>(loader.Invoke("glGenRenderbuffers"));
            _glRenderbufferStorage = Marshal.GetDelegateForFunctionPointer<PFNGLRENDERBUFFERSTORAGEPROC>(loader.Invoke("glRenderbufferStorage"));
            _glGetRenderbufferParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETRENDERBUFFERPARAMETERIVPROC>(loader.Invoke("glGetRenderbufferParameteriv"));
            _glIsFramebuffer = Marshal.GetDelegateForFunctionPointer<PFNGLISFRAMEBUFFERPROC>(loader.Invoke("glIsFramebuffer"));
            _glBindFramebuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBINDFRAMEBUFFERPROC>(loader.Invoke("glBindFramebuffer"));
            _glDeleteFramebuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEFRAMEBUFFERSPROC>(loader.Invoke("glDeleteFramebuffers"));
            _glGenFramebuffers = Marshal.GetDelegateForFunctionPointer<PFNGLGENFRAMEBUFFERSPROC>(loader.Invoke("glGenFramebuffers"));
            _glCheckFramebufferStatus = Marshal.GetDelegateForFunctionPointer<PFNGLCHECKFRAMEBUFFERSTATUSPROC>(loader.Invoke("glCheckFramebufferStatus"));
            _glFramebufferTexture1D = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURE1DPROC>(loader.Invoke("glFramebufferTexture1D"));
            _glFramebufferTexture2D = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURE2DPROC>(loader.Invoke("glFramebufferTexture2D"));
            _glFramebufferTexture3D = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURE3DPROC>(loader.Invoke("glFramebufferTexture3D"));
            _glFramebufferRenderbuffer = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERRENDERBUFFERPROC>(loader.Invoke("glFramebufferRenderbuffer"));
            _glGetFramebufferAttachmentParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETFRAMEBUFFERATTACHMENTPARAMETERIVPROC>(loader.Invoke("glGetFramebufferAttachmentParameteriv"));
            _glGenerateMipmap = Marshal.GetDelegateForFunctionPointer<PFNGLGENERATEMIPMAPPROC>(loader.Invoke("glGenerateMipmap"));
            _glBlitFramebuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBLITFRAMEBUFFERPROC>(loader.Invoke("glBlitFramebuffer"));
            _glRenderbufferStorageMultisample = Marshal.GetDelegateForFunctionPointer<PFNGLRENDERBUFFERSTORAGEMULTISAMPLEPROC>(loader.Invoke("glRenderbufferStorageMultisample"));
            _glFramebufferTextureLayer = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURELAYERPROC>(loader.Invoke("glFramebufferTextureLayer"));
            _glMapBufferRange = Marshal.GetDelegateForFunctionPointer<PFNGLMAPBUFFERRANGEPROC>(loader.Invoke("glMapBufferRange"));
            _glFlushMappedBufferRange = Marshal.GetDelegateForFunctionPointer<PFNGLFLUSHMAPPEDBUFFERRANGEPROC>(loader.Invoke("glFlushMappedBufferRange"));
            _glBindVertexArray = Marshal.GetDelegateForFunctionPointer<PFNGLBINDVERTEXARRAYPROC>(loader.Invoke("glBindVertexArray"));
            _glDeleteVertexArrays = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEVERTEXARRAYSPROC>(loader.Invoke("glDeleteVertexArrays"));
            _glGenVertexArrays = Marshal.GetDelegateForFunctionPointer<PFNGLGENVERTEXARRAYSPROC>(loader.Invoke("glGenVertexArrays"));
            _glIsVertexArray = Marshal.GetDelegateForFunctionPointer<PFNGLISVERTEXARRAYPROC>(loader.Invoke("glIsVertexArray"));
            _glDrawArraysInstanced = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWARRAYSINSTANCEDPROC>(loader.Invoke("glDrawArraysInstanced"));
            _glDrawElementsInstanced = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSINSTANCEDPROC>(loader.Invoke("glDrawElementsInstanced"));
            _glTexBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLTEXBUFFERPROC>(loader.Invoke("glTexBuffer"));
            _glPrimitiveRestartIndex = Marshal.GetDelegateForFunctionPointer<PFNGLPRIMITIVERESTARTINDEXPROC>(loader.Invoke("glPrimitiveRestartIndex"));
            _glCopyBufferSubData = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYBUFFERSUBDATAPROC>(loader.Invoke("glCopyBufferSubData"));
            _glGetUniformIndices = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMINDICESPROC>(loader.Invoke("glGetUniformIndices"));
            _glGetActiveUniformsiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMSIVPROC>(loader.Invoke("glGetActiveUniformsiv"));
            _glGetActiveUniformName = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMNAMEPROC>(loader.Invoke("glGetActiveUniformName"));
            _glGetUniformBlockIndex = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMBLOCKINDEXPROC>(loader.Invoke("glGetUniformBlockIndex"));
            _glGetActiveUniformBlockiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMBLOCKIVPROC>(loader.Invoke("glGetActiveUniformBlockiv"));
            _glGetActiveUniformBlockName = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC>(loader.Invoke("glGetActiveUniformBlockName"));
            _glUniformBlockBinding = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMBLOCKBINDINGPROC>(loader.Invoke("glUniformBlockBinding"));
            _glBindBufferRange = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERRANGEPROC>(loader.Invoke("glBindBufferRange"));
            _glBindBufferBase = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERBASEPROC>(loader.Invoke("glBindBufferBase"));
            _glGetIntegeri_v = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGERI_VPROC>(loader.Invoke("glGetIntegeri_v"));
            _glDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSBASEVERTEXPROC>(loader.Invoke("glDrawElementsBaseVertex"));
            _glDrawRangeElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC>(loader.Invoke("glDrawRangeElementsBaseVertex"));
            _glDrawElementsInstancedBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC>(loader.Invoke("glDrawElementsInstancedBaseVertex"));
            _glMultiDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC>(loader.Invoke("glMultiDrawElementsBaseVertex"));
            _glProvokingVertex = Marshal.GetDelegateForFunctionPointer<PFNGLPROVOKINGVERTEXPROC>(loader.Invoke("glProvokingVertex"));
            _glFenceSync = Marshal.GetDelegateForFunctionPointer<PFNGLFENCESYNCPROC>(loader.Invoke("glFenceSync"));
            _glIsSync = Marshal.GetDelegateForFunctionPointer<PFNGLISSYNCPROC>(loader.Invoke("glIsSync"));
            _glDeleteSync = Marshal.GetDelegateForFunctionPointer<PFNGLDELETESYNCPROC>(loader.Invoke("glDeleteSync"));
            _glClientWaitSync = Marshal.GetDelegateForFunctionPointer<PFNGLCLIENTWAITSYNCPROC>(loader.Invoke("glClientWaitSync"));
            _glWaitSync = Marshal.GetDelegateForFunctionPointer<PFNGLWAITSYNCPROC>(loader.Invoke("glWaitSync"));
            _glGetInteger64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGER64VPROC>(loader.Invoke("glGetInteger64v"));
            _glGetSynciv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSYNCIVPROC>(loader.Invoke("glGetSynciv"));
            _glGetInteger64i_v = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGER64I_VPROC>(loader.Invoke("glGetInteger64i_v"));
            _glGetBufferParameteri64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERPARAMETERI64VPROC>(loader.Invoke("glGetBufferParameteri64v"));
            _glFramebufferTexture = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTUREPROC>(loader.Invoke("glFramebufferTexture"));
            _glTexImage2DMultisample = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE2DMULTISAMPLEPROC>(loader.Invoke("glTexImage2DMultisample"));
            _glTexImage3DMultisample = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE3DMULTISAMPLEPROC>(loader.Invoke("glTexImage3DMultisample"));
            _glGetMultisamplefv = Marshal.GetDelegateForFunctionPointer<PFNGLGETMULTISAMPLEFVPROC>(loader.Invoke("glGetMultisamplefv"));
            _glSampleMaski = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLEMASKIPROC>(loader.Invoke("glSampleMaski"));
            _glBindFragDataLocationIndexed = Marshal.GetDelegateForFunctionPointer<PFNGLBINDFRAGDATALOCATIONINDEXEDPROC>(loader.Invoke("glBindFragDataLocationIndexed"));
            _glGetFragDataIndex = Marshal.GetDelegateForFunctionPointer<PFNGLGETFRAGDATAINDEXPROC>(loader.Invoke("glGetFragDataIndex"));
            _glGenSamplers = Marshal.GetDelegateForFunctionPointer<PFNGLGENSAMPLERSPROC>(loader.Invoke("glGenSamplers"));
            _glDeleteSamplers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETESAMPLERSPROC>(loader.Invoke("glDeleteSamplers"));
            _glIsSampler = Marshal.GetDelegateForFunctionPointer<PFNGLISSAMPLERPROC>(loader.Invoke("glIsSampler"));
            _glBindSampler = Marshal.GetDelegateForFunctionPointer<PFNGLBINDSAMPLERPROC>(loader.Invoke("glBindSampler"));
            _glSamplerParameteri = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIPROC>(loader.Invoke("glSamplerParameteri"));
            _glSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIVPROC>(loader.Invoke("glSamplerParameteriv"));
            _glSamplerParameterf = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERFPROC>(loader.Invoke("glSamplerParameterf"));
            _glSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERFVPROC>(loader.Invoke("glSamplerParameterfv"));
            _glSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIIVPROC>(loader.Invoke("glSamplerParameterIiv"));
            _glSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIUIVPROC>(loader.Invoke("glSamplerParameterIuiv"));
            _glGetSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERIVPROC>(loader.Invoke("glGetSamplerParameteriv"));
            _glGetSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERIIVPROC>(loader.Invoke("glGetSamplerParameterIiv"));
            _glGetSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERFVPROC>(loader.Invoke("glGetSamplerParameterfv"));
            _glGetSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERIUIVPROC>(loader.Invoke("glGetSamplerParameterIuiv"));
            _glQueryCounter = Marshal.GetDelegateForFunctionPointer<PFNGLQUERYCOUNTERPROC>(loader.Invoke("glQueryCounter"));
            _glGetQueryObjecti64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTI64VPROC>(loader.Invoke("glGetQueryObjecti64v"));
            _glGetQueryObjectui64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTUI64VPROC>(loader.Invoke("glGetQueryObjectui64v"));
            _glVertexAttribDivisor = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBDIVISORPROC>(loader.Invoke("glVertexAttribDivisor"));
            _glVertexAttribP1ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP1UIPROC>(loader.Invoke("glVertexAttribP1ui"));
            _glVertexAttribP1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP1UIVPROC>(loader.Invoke("glVertexAttribP1uiv"));
            _glVertexAttribP2ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP2UIPROC>(loader.Invoke("glVertexAttribP2ui"));
            _glVertexAttribP2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP2UIVPROC>(loader.Invoke("glVertexAttribP2uiv"));
            _glVertexAttribP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP3UIPROC>(loader.Invoke("glVertexAttribP3ui"));
            _glVertexAttribP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP3UIVPROC>(loader.Invoke("glVertexAttribP3uiv"));
            _glVertexAttribP4ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP4UIPROC>(loader.Invoke("glVertexAttribP4ui"));
            _glVertexAttribP4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP4UIVPROC>(loader.Invoke("glVertexAttribP4uiv"));
            _glVertexP2ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXP2UIPROC>(loader.Invoke("glVertexP2ui"));
            _glVertexP2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXP2UIVPROC>(loader.Invoke("glVertexP2uiv"));
            _glVertexP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXP3UIPROC>(loader.Invoke("glVertexP3ui"));
            _glVertexP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXP3UIVPROC>(loader.Invoke("glVertexP3uiv"));
            _glVertexP4ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXP4UIPROC>(loader.Invoke("glVertexP4ui"));
            _glVertexP4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXP4UIVPROC>(loader.Invoke("glVertexP4uiv"));
            _glTexCoordP1ui = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP1UIPROC>(loader.Invoke("glTexCoordP1ui"));
            _glTexCoordP1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP1UIVPROC>(loader.Invoke("glTexCoordP1uiv"));
            _glTexCoordP2ui = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP2UIPROC>(loader.Invoke("glTexCoordP2ui"));
            _glTexCoordP2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP2UIVPROC>(loader.Invoke("glTexCoordP2uiv"));
            _glTexCoordP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP3UIPROC>(loader.Invoke("glTexCoordP3ui"));
            _glTexCoordP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP3UIVPROC>(loader.Invoke("glTexCoordP3uiv"));
            _glTexCoordP4ui = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP4UIPROC>(loader.Invoke("glTexCoordP4ui"));
            _glTexCoordP4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXCOORDP4UIVPROC>(loader.Invoke("glTexCoordP4uiv"));
            _glMultiTexCoordP1ui = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP1UIPROC>(loader.Invoke("glMultiTexCoordP1ui"));
            _glMultiTexCoordP1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP1UIVPROC>(loader.Invoke("glMultiTexCoordP1uiv"));
            _glMultiTexCoordP2ui = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP2UIPROC>(loader.Invoke("glMultiTexCoordP2ui"));
            _glMultiTexCoordP2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP2UIVPROC>(loader.Invoke("glMultiTexCoordP2uiv"));
            _glMultiTexCoordP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP3UIPROC>(loader.Invoke("glMultiTexCoordP3ui"));
            _glMultiTexCoordP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP3UIVPROC>(loader.Invoke("glMultiTexCoordP3uiv"));
            _glMultiTexCoordP4ui = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP4UIPROC>(loader.Invoke("glMultiTexCoordP4ui"));
            _glMultiTexCoordP4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLMULTITEXCOORDP4UIVPROC>(loader.Invoke("glMultiTexCoordP4uiv"));
            _glNormalP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLNORMALP3UIPROC>(loader.Invoke("glNormalP3ui"));
            _glNormalP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLNORMALP3UIVPROC>(loader.Invoke("glNormalP3uiv"));
            _glColorP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORP3UIPROC>(loader.Invoke("glColorP3ui"));
            _glColorP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORP3UIVPROC>(loader.Invoke("glColorP3uiv"));
            _glColorP4ui = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORP4UIPROC>(loader.Invoke("glColorP4ui"));
            _glColorP4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORP4UIVPROC>(loader.Invoke("glColorP4uiv"));
            _glSecondaryColorP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLSECONDARYCOLORP3UIPROC>(loader.Invoke("glSecondaryColorP3ui"));
            _glSecondaryColorP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLSECONDARYCOLORP3UIVPROC>(loader.Invoke("glSecondaryColorP3uiv"));
        }
        #endregion
    }
}
