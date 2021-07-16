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
            return ALCDelegates.alcCloseDevice(device);
        }

        public static IntPtr OpenDevice([MarshalAs(UnmanagedType.LPStr)] string devicename)
        {
            return ALCDelegates.alcOpenDevice(devicename);
        }

        public static bool IsExtensionPresent(IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string extname)
        {
            return ALCDelegates.alcIsExtensionPresent(device, extname);
        }

        public static void GetInteger(IntPtr device, int param, int size, [MarshalAs(UnmanagedType.LPArray)] int[] data)
        {
            ALCDelegates.alcGetIntegerv(device, param, size, data);
        }

        public static IntPtr CreateContext(IntPtr device, [MarshalAs(UnmanagedType.LPArray)] int[] attrlist)
        {
            return ALCDelegates.alcCreateContext(device, attrlist);
        }

        public static bool MakeContextCurrent(IntPtr context)
        {
            return ALCDelegates.alcMakeContextCurrent(context);
        }
    }
}
