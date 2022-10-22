using System;
using System.Runtime.InteropServices;
using SDL_Sharp.Utils;

namespace SDL_Sharp;
public static unsafe partial class SDL
{
	/* Only available in 2.0.6 or higher. */
	[DllImport(LibraryName, EntryPoint = "SDL_Vulkan_LoadLibrary", CallingConvention = CallingConvention.Cdecl)]
	private static extern unsafe int INTERNAL_SDL_Vulkan_LoadLibrary(
		byte* path
	);
	public static unsafe int Vulkan_LoadLibrary(string path)
	{
		byte* utf8Path = InternalUtils.Utf8EncodeHeap(path);
		int result = INTERNAL_SDL_Vulkan_LoadLibrary(
			utf8Path
		);
		Marshal.FreeHGlobal((IntPtr)utf8Path);
		return result;
	}

	/* Only available in 2.0.6 or higher. */
	[DllImport(LibraryName, EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr Vulkan_GetVkGetInstanceProcAddr();

	/* Only available in 2.0.6 or higher. */
	[DllImport(LibraryName, EntryPoint = "SDL_Vulkan_UnloadLibrary", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Vulkan_UnloadLibrary();

	/* window refers to an SDL_Window*, pNames to a const char**.
	 * Only available in 2.0.6 or higher.
	 */
	[DllImport(LibraryName, EntryPoint = "SDL_Vulkan_GetInstanceExtensions", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool Vulkan_GetInstanceExtensions(
		IntPtr window,
		out uint pCount,
		IntPtr[] pNames
	);

	/* window refers to an SDL_Window.
	 * instance refers to a VkInstance.
	 * surface refers to a VkSurfaceKHR.
	 * Only available in 2.0.6 or higher.
	 */
	[DllImport(LibraryName, EntryPoint = "SDL_Vulkan_CreateSurface", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool Vulkan_CreateSurface(
		IntPtr window,
		IntPtr instance,
		out ulong surface
	);

	/* window refers to an SDL_Window*.
	 * Only available in 2.0.6 or higher.
	 */
	[DllImport(LibraryName, EntryPoint = "SDL_Vulkan_GetDrawableSize", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Vulkan_GetDrawableSize(
		IntPtr window,
		out int w,
		out int h
	);
}
