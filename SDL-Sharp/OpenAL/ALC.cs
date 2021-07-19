using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SDL_Sharp.OpenAL
{
    public static partial class ALC
    {
        public static bool CloseDevice(IntPtr device)
        {
            return ALC32.alcCloseDevice(device);
        }

        public static IntPtr OpenDevice([MarshalAs(UnmanagedType.LPStr)] string devicename)
        {
            return ALC32.alcOpenDevice(devicename);
        }

        public static bool IsExtensionPresent(IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string extname)
        {
            return ALC32.alcIsExtensionPresent(device, extname);
        }

        public static void GetInteger(IntPtr device, int param, int size, [MarshalAs(UnmanagedType.LPArray)] int[] data)
        {
            ALC32.alcGetIntegerv(device, param, size, data);
        }

        public static IntPtr CreateContext(IntPtr device, [MarshalAs(UnmanagedType.LPArray)] int[] attrlist)
        {
            return ALC32.alcCreateContext(device, attrlist);
        }

        public static bool MakeContextCurrent(IntPtr context)
        {
            return ALC32.alcMakeContextCurrent(context);
        }
    }
}
