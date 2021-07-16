using System;
using System.Security;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SDL_Sharp.OpenAL
{
	public static class ALCDelegates
	{
		static ALCDelegates()
		{
#if DEBUG
			Stopwatch sw = new Stopwatch();
			sw.Start();
#endif
			Type alInterop = (IntPtr.Size == 8) ? typeof(ALC64) : typeof(ALC32);
			FieldInfo[] fields = typeof(ALCDelegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
			foreach (FieldInfo fi in fields)
			{
				MethodInfo mi = alInterop.GetMethod(fi.Name, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
				Delegate function = Delegate.CreateDelegate(fi.FieldType, mi);
				fi.SetValue(null, function);
			}
#if DEBUG
			sw.Stop();
			Console.WriteLine("Copying OpenAL delegates took {0} milliseconds.", sw.ElapsedMilliseconds);
#endif
		}

		[SuppressUnmanagedCodeSecurity]
		internal delegate bool CloseDevice(IntPtr device);
		[SuppressUnmanagedCodeSecurity]
		internal delegate IntPtr OpenDevice([MarshalAs(UnmanagedType.LPStr)] string devicename);
		[SuppressUnmanagedCodeSecurity]
		internal delegate bool IsExtensionPresent(IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string extname);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetInteger(IntPtr device, int param, int size, [MarshalAs(UnmanagedType.LPArray)] int[] data);
		[SuppressUnmanagedCodeSecurity]
		internal delegate IntPtr CreateContext(IntPtr device, [MarshalAs(UnmanagedType.LPArray)] int[] attrlist);
		[SuppressUnmanagedCodeSecurity]
		internal delegate bool MakeContextCurrent(IntPtr context);

		internal static CloseDevice alcCloseDevice;
		internal static OpenDevice alcOpenDevice;
		internal static IsExtensionPresent alcIsExtensionPresent;
		internal static GetInteger alcGetIntegerv;
		internal static CreateContext alcCreateContext;
		internal static MakeContextCurrent alcMakeContextCurrent;
	}
}
