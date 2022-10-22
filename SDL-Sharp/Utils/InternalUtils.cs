using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL_Sharp.Utils;
internal unsafe class InternalUtils
{
    internal static string GetString(byte* ptr)
    {
        int count = 0;
        while (*(ptr + count) != 0)
        {
            count += 1;
        }

        return Encoding.UTF8.GetString(ptr, count);
    }

    internal static unsafe byte* Utf8EncodeHeap(string str)
    {
        if (str == null)
        {
            return (byte*)0;
        }

        int bufferSize = Utf8Size(str);
        byte* buffer = (byte*)Marshal.AllocHGlobal(bufferSize);
        fixed (char* strPtr = str)
        {
            Encoding.UTF8.GetBytes(strPtr, str.Length + 1, buffer, bufferSize);
        }
        return buffer;
    }

    internal static int Utf8Size(string str)
    {
        Debug.Assert(str != null);
        return (str.Length * 4) + 1;
    }

    internal static int Utf8SizeNullable(string str)
    {
        return str != null ? (str.Length * 4) + 1 : 0;
    }

    internal static unsafe byte* Utf8Encode(string str, byte* buffer, int bufferSize)
    {
        Debug.Assert(str != null);
        fixed (char* strPtr = str)
        {
            Encoding.UTF8.GetBytes(strPtr, str.Length + 1, buffer, bufferSize);
        }
        return buffer;
    }

    internal static unsafe byte* Utf8EncodeNullable(string str, byte* buffer, int bufferSize)
    {
        if (str == null)
        {
            return (byte*)0;
        }
        fixed (char* strPtr = str)
        {
            Encoding.UTF8.GetBytes(strPtr, str.Length + 1, buffer, bufferSize);
        }
        return buffer;
    }

    internal static unsafe byte* Utf8Encode(string str)
    {
        Debug.Assert(str != null);
        int bufferSize = Utf8Size(str);
        byte* buffer = (byte*)Marshal.AllocHGlobal(bufferSize);
        fixed (char* strPtr = str)
        {
            Encoding.UTF8.GetBytes(strPtr, str.Length + 1, buffer, bufferSize);
        }
        return buffer;
    }
    internal static unsafe byte* Utf8EncodeNullable(string str)
    {
        if (str == null)
        {
            return (byte*)0;
        }
        int bufferSize = Utf8Size(str);
        byte* buffer = (byte*)Marshal.AllocHGlobal(bufferSize);
        fixed (char* strPtr = str)
        {
            Encoding.UTF8.GetBytes(
                strPtr,
                (str != null) ? (str.Length + 1) : 0,
                buffer,
                bufferSize
            );
        }
        return buffer;
    }
}
