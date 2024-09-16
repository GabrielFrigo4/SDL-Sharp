using System;
using System.Runtime.InteropServices;
using SDL_Sharp.Utils;

namespace SDL_Sharp;

public static unsafe partial class SDL
{
    public const string FramebufferAcceleration =
        "SDL_FRAMEBUFFER_ACCELERATION";
    public const string RenderDriver =
        "SDL_RENDER_DRIVER";
    public const string RenderOpenglShaders =
        "SDL_RENDER_OPENGL_SHADERS";
    public const string RenderDirect3dThreadsafe =
        "SDL_RENDER_DIRECT3D_THREADSAFE";
    public const string RenderVsync =
        "SDL_RENDER_VSYNC";
    public const string VideoX11Xvidmode =
        "SDL_VIDEO_X11_XVIDMODE";
    public const string VideoX11Xinerama =
        "SDL_VIDEO_X11_XINERAMA";
    public const string VideoX11Xrandr =
        "SDL_VIDEO_X11_XRANDR";
    public const string GrabKeyboard =
        "SDL_GRAB_KEYBOARD";
    public const string VideoMinimizeOnFocusLoss =
        "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS";
    public const string IdleTimerDisabled =
        "SDL_IOS_IDLE_TIMER_DISABLED";
    public const string Orientations =
        "SDL_IOS_ORIENTATIONS";
    public const string XinputEnabled =
        "SDL_XINPUT_ENABLED";
    public const string Gamecontrollerconfig =
        "SDL_GAMECONTROLLERCONFIG";
    public const string JoystickAllowBackgroundEvents =
        "SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS";
    public const string AllowTopmost =
        "SDL_ALLOW_TOPMOST";
    public const string TimerResolution =
        "SDL_TIMER_RESOLUTION";
    public const string RenderScaleQuality =
        "SDL_RENDER_SCALE_QUALITY";

    /* Only available in SDL 2.0.1 or higher. */
    public const string VideoHighdpiDisabled =
        "SDL_VIDEO_HIGHDPI_DISABLED";

    /* Only available in SDL 2.0.2 or higher. */
    public const string MacCtrlClickEmulateRightClick =
        "SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK";
    public const string VideoWinD3dcompiler =
        "SDL_VIDEO_WIN_D3DCOMPILER";
    public const string MouseRelativeModeWarp =
        "SDL_MOUSE_RELATIVE_MODE_WARP";
    public const string VideoWindowSharePixelFormat =
        "SDL_VIDEO_WINDOW_SHARE_PIXEL_FORMAT";
    public const string VideoAllowScreensaver =
        "SDL_VIDEO_ALLOW_SCREENSAVER";
    public const string AccelerometerAsJoystick =
        "SDL_ACCELEROMETER_AS_JOYSTICK";
    public const string VideoMacFullscreenSpaces =
        "SDL_VIDEO_MAC_FULLSCREEN_SPACES";

    /* Only available in SDL 2.0.3 or higher. */
    public const string WinrtPrivacyPolicyUrl =
        "SDL_WINRT_PRIVACY_POLICY_URL";
    public const string WinrtPrivacyPolicyLabel =
        "SDL_WINRT_PRIVACY_POLICY_LABEL";
    public const string WinrtHandleBackButton =
        "SDL_WINRT_HANDLE_BACK_BUTTON";

    /* Only available in SDL 2.0.4 or higher. */
    public const string NoSignalHandlers =
        "SDL_NO_SIGNAL_HANDLERS";
    public const string ImeInternalEditing =
        "SDL_IME_INTERNAL_EDITING";
    public const string AndroidSeparateMouseAndTouch =
        "SDL_ANDROID_SEPARATE_MOUSE_AND_TOUCH";
    public const string EmscriptenKeyboardElement =
        "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT";
    public const string ThreadStackSize =
        "SDL_THREAD_STACK_SIZE";
    public const string WindowFrameUsableWhileCursorHidden =
        "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN";
    public const string WindowsEnableMessageloop =
        "SDL_WINDOWS_ENABLE_MESSAGELOOP";
    public const string WindowsNoCloseOnAltF4 =
        "SDL_WINDOWS_NO_CLOSE_ON_ALT_F4";
    public const string XinputUseOldJoystickMapping =
        "SDL_XINPUT_USE_OLD_JOYSTICK_MAPPING";
    public const string MacBackgroundApp =
        "SDL_MAC_BACKGROUND_APP";
    public const string VideoX11NetWmPing =
        "SDL_VIDEO_X11_NET_WM_PING";
    public const string AndroidApkExpansionMainFileVersion =
        "SDL_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION";
    public const string AndroidApkExpansionPatchFileVersion =
        "SDL_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION";

    /* Only available in SDL 2.0.5 or higher. */
    public const string MouseFocusClickthrough =
        "SDL_MOUSE_FOCUS_CLICKTHROUGH";
    public const string BmpSaveLegacyFormat =
        "SDL_BMP_SAVE_LEGACY_FORMAT";
    public const string WindowsDisableThreadNaming =
        "SDL_WINDOWS_DISABLE_THREAD_NAMING";
    public const string AppleTvRemoteAllowRotation =
        "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION";

    /* Only available in SDL 2.0.6 or higher. */
    public const string AudioResamplingMode =
        "SDL_AUDIO_RESAMPLING_MODE";
    public const string RenderLogicalSizeMode =
        "SDL_RENDER_LOGICAL_SIZE_MODE";
    public const string MouseNormalSpeedScale =
        "SDL_MOUSE_NORMAL_SPEED_SCALE";
    public const string MouseRelativeSpeedScale =
        "SDL_MOUSE_RELATIVE_SPEED_SCALE";
    public const string TouchMouseEvents =
        "SDL_TOUCH_MOUSE_EVENTS";
    public const string WindowsIntresourceIcon =
        "SDL_WINDOWS_INTRESOURCE_ICON";
    public const string WindowsIntresourceIconSmall =
        "SDL_WINDOWS_INTRESOURCE_ICON_SMALL";

    /* Only available in SDL 2.0.8 or higher. */
    public const string IosHideHomeIndicator =
        "SDL_IOS_HIDE_HOME_INDICATOR";
    public const string TvRemoteAsJoystick =
        "SDL_TV_REMOTE_AS_JOYSTICK";
    public const string sdlVideoX11NetWmBypassCompositor =
        "SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR";

    /* Only available in SDL 2.0.9 or higher. */
    public const string MouseDoubleClickTime =
        "SDL_MOUSE_DOUBLE_CLICK_TIME";
    public const string MouseDoubleClickRadius =
        "SDL_MOUSE_DOUBLE_CLICK_RADIUS";
    public const string JoystickHidapi =
        "SDL_JOYSTICK_HIDAPI";
    public const string JoystickHidapiPs4 =
        "SDL_JOYSTICK_HIDAPI_PS4";
    public const string JoystickHidapiPs4Rumble =
        "SDL_JOYSTICK_HIDAPI_PS4_RUMBLE";
    public const string JoystickHidapiSteam =
        "SDL_JOYSTICK_HIDAPI_STEAM";
    public const string JoystickHidapiSwitch =
        "SDL_JOYSTICK_HIDAPI_SWITCH";
    public const string JoystickHidapiXbox =
        "SDL_JOYSTICK_HIDAPI_XBOX";
    public const string EnableSteamControllers =
        "SDL_ENABLE_STEAM_CONTROLLERS";
    public const string AndroidTrapBackButton =
        "SDL_ANDROID_TRAP_BACK_BUTTON";

    /* Only available in SDL 2.0.10 or higher. */
    public const string MouseTouchEvents =
        "SDL_MOUSE_TOUCH_EVENTS";
    public const string GamecontrollerconfigFile =
        "SDL_GAMECONTROLLERCONFIG_FILE";
    public const string AndroidBlockOnPause =
        "SDL_ANDROID_BLOCK_ON_PAUSE";
    public const string RenderBatching =
        "SDL_RENDER_BATCHING";
    public const string EventLogging =
        "SDL_EVENT_LOGGING";
    public const string WaveRiffChunkSize =
        "SDL_WAVE_RIFF_CHUNK_SIZE";
    public const string WaveTruncation =
        "SDL_WAVE_TRUNCATION";
    public const string WaveFactChunk =
        "SDL_WAVE_FACT_CHUNK";

    /* Only available in SDL 2.0.11 or higher. */
    public const string VidoX11WindowVisualid =
        "SDL_VIDEO_X11_WINDOW_VISUALID";
    public const string GamecontrollerUseButtonLabels =
        "SDL_GAMECONTROLLER_USE_BUTTON_LABELS";
    public const string VideoExternalContext =
        "SDL_VIDEO_EXTERNAL_CONTEXT";
    public const string JoystickHidapiGamecube =
        "SDL_JOYSTICK_HIDAPI_GAMECUBE";
    public const string DisplayUsableBounds =
        "SDL_DISPLAY_USABLE_BOUNDS";
    public const string VideoX11ForceEgl =
        "SDL_VIDEO_X11_FORCE_EGL";
    public const string Gamecontrollertype =
        "SDL_GAMECONTROLLERTYPE";

    /* Only available in SDL 2.0.14 or higher. */
    public const string JoystickHidapiCorrelateXinput =
        "SDL_JOYSTICK_HIDAPI_CORRELATE_XINPUT"; /* note: this was removed in 2.0.16. */
    public const string JoystickRawinput =
        "SDL_JOYSTICK_RAWINPUT";
    public const string AudioDeviceAppName =
        "SDL_AUDIO_DEVICE_APP_NAME";
    public const string AudioDeviceStreamName =
        "SDL_AUDIO_DEVICE_STREAM_NAME";
    public const string PreferredLocales =
        "SDL_PREFERRED_LOCALES";
    public const string ThreadPriorityPolicy =
        "SDL_THREAD_PRIORITY_POLICY";
    public const string EmscriptenAsyncify =
        "SDL_EMSCRIPTEN_ASYNCIFY";
    public const string LinuxJoystickDeadzones =
        "SDL_LINUX_JOYSTICK_DEADZONES";
    public const string AndroidBlockOnPausePauseaudio =
        "SDL_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO";
    public const string JoystickHidapiPs5 =
        "SDL_JOYSTICK_HIDAPI_PS5";
    public const string ThreadForceRealtimeTimeCritical =
        "SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL";
    public const string JoystickThread =
        "SDL_JOYSTICK_THREAD";
    public const string AutoUpdateJoysticks =
        "SDL_AUTO_UPDATE_JOYSTICKS";
    public const string AutoUpdateSensors =
        "SDL_AUTO_UPDATE_SENSORS";
    public const string MouseRelativeScaling =
        "SDL_MOUSE_RELATIVE_SCALING";
    public const string JoystickHidapiPs5Rumble =
        "SDL_JOYSTICK_HIDAPI_PS5_RUMBLE";

    /* Only available in SDL 2.0.16 or higher. */
    public const string WindowsForceMutexCriticalSections =
        "SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS";
    public const string WindowsForceSemaphoreKernel =
        "SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL";
    public const string JoystickHidapiPs5PlayerLed =
        "SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED";
    public const string WindowsUseD3d9ex =
        "SDL_WINDOWS_USE_D3D9EX";
    public const string JoystickHidapiJoyCons =
        "SDL_JOYSTICK_HIDAPI_JOY_CONS";
    public const string JoystickHidapiStadia =
        "SDL_JOYSTICK_HIDAPI_STADIA";
    public const string JoystickHidapiSwitchHomeLed =
        "SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED";
    public const string AllowAltTabWhileGrabbed =
        "SDL_ALLOW_ALT_TAB_WHILE_GRABBED";
    public const string KmsdrmRequireDrmMaster =
        "SDL_KMSDRM_REQUIRE_DRM_MASTER";
    public const string AudioDeviceStreamRole =
        "SDL_AUDIO_DEVICE_STREAM_ROLE";
    public const string X11ForceOverrideRedirect =
        "SDL_X11_FORCE_OVERRIDE_REDIRECT";
    public const string JoystickHidapiLuna =
        "SDL_JOYSTICK_HIDAPI_LUNA";
    public const string JoystickRawinputCorrelateXinput =
        "SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT";
    public const string AudioIncludeMonitors =
        "SDL_AUDIO_INCLUDE_MONITORS";
    public const string VideoWaylandAllowLibdecor =
        "SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR";

    /* Only available in SDL 2.0.18 or higher. */
    public const string VideoEglAllowTransparency =
        "SDL_VIDEO_EGL_ALLOW_TRANSPARENCY";
    public const string AppName =
        "SDL_APP_NAME";
    public const string ScreensaverInhibitActivityName =
        "SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME";
    public const string ImeShowUi =
        "SDL_IME_SHOW_UI";
    public const string WindowNoActivationWhenShown =
        "SDL_WINDOW_NO_ACTIVATION_WHEN_SHOWN";
    public const string PollSentinel =
        "SDL_POLL_SENTINEL";
    public const string JoystickDevice =
        "SDL_JOYSTICK_DEVICE";
    public const string LinuxJoystickClassic =
        "SDL_LINUX_JOYSTICK_CLASSIC";

    /* Only available in SDL 2.0.20 or higher. */
    public const string RenderLineMethod =
        "SDL_RENDER_LINE_METHOD";

    /* Only available in SDL 2.0.22 or higher. */
    public const string ForceRaisewindow =
        "SDL_HINT_FORCE_RAISEWINDOW";
    public const string ImeSupportExtendedText =
        "SDL_IME_SUPPORT_EXTENDED_TEXT";
    public const string JoystickGamecubeRumbleBrake =
        "SDL_JOYSTICK_GAMECUBE_RUMBLE_BRAKE";
    public const string JoystickRogChakram =
        "SDL_JOYSTICK_ROG_CHAKRAM";
    public const string MouseRelativeModeCenter =
        "SDL_MOUSE_RELATIVE_MODE_CENTER";
    public const string MouseAutoCapture =
        "SDL_MOUSE_AUTO_CAPTURE";
    public const string VitaTouchMouseDevice =
        "SDL_HINT_VITA_TOUCH_MOUSE_DEVICE";
    public const string VideoWaylandPreferLibdecor =
        "SDL_VIDEO_WAYLAND_PREFER_LIBDECOR";
    public const string VideoForeignWindowOpengl =
        "SDL_VIDEO_FOREIGN_WINDOW_OPENGL";
    public const string VideoForeignWindowVulkan =
        "SDL_VIDEO_FOREIGN_WINDOW_VULKAN";
    public const string X11WindowType =
        "SDL_X11_WINDOW_TYPE";
    public const string QuitOnLastWindowClose =
        "SDL_QUIT_ON_LAST_WINDOW_CLOSE";

    public enum HintPriority
    {
        Default,
        Normal,
        Override
    }
    
    [DllImport(LibraryName, EntryPoint = "SDL_ClearHints", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClearHints();

    [DllImport(LibraryName, EntryPoint = "SDL_GetHint", CallingConvention = CallingConvention.Cdecl)]
    private static extern unsafe IntPtr INTERNAL_GetHint(byte* name);
    public static unsafe string? GetHint(string name)
    {
        int utf8NameBufSize = InternalUtils.Utf8Size(name);
        byte* utf8Name = stackalloc byte[utf8NameBufSize];
        return UTF8_ToManaged(
            INTERNAL_GetHint(
                InternalUtils.Utf8Encode(name, utf8Name, utf8NameBufSize)
            )
        );
    }

    [DllImport(LibraryName, EntryPoint = "SDL_SetHint", CallingConvention = CallingConvention.Cdecl)]
    private static extern unsafe bool INTERNAL_SetHint(
        byte* name,
        byte* value
    );
    public static unsafe bool SetHint(string name, string value)
    {
        int utf8NameBufSize = InternalUtils.Utf8Size(name);
        byte* utf8Name = stackalloc byte[utf8NameBufSize];

        int utf8ValueBufSize = InternalUtils.Utf8Size(value);
        byte* utf8Value = stackalloc byte[utf8ValueBufSize];

        return INTERNAL_SetHint(
            InternalUtils.Utf8Encode(name, utf8Name, utf8NameBufSize),
            InternalUtils.Utf8Encode(value, utf8Value, utf8ValueBufSize)
        );
    }

    [DllImport(LibraryName, EntryPoint = "SDL_SetHintWithPriority", CallingConvention = CallingConvention.Cdecl)]
    private static extern unsafe bool INTERNAL_SetHintWithPriority(
        byte* name,
        byte* value,
        HintPriority priority
    );
    public static unsafe bool SetHintWithPriority(
        string name,
        string value,
         HintPriority priority
    )
    {
        int utf8NameBufSize = InternalUtils.Utf8Size(name);
        byte* utf8Name = stackalloc byte[utf8NameBufSize];

        int utf8ValueBufSize = InternalUtils.Utf8Size(value);
        byte* utf8Value = stackalloc byte[utf8ValueBufSize];

        return INTERNAL_SetHintWithPriority(
            InternalUtils.Utf8Encode(name, utf8Name, utf8NameBufSize),
            InternalUtils.Utf8Encode(value, utf8Value, utf8ValueBufSize),
            priority
        );
    }

    /* Only available in 2.0.5 or higher. */
    [DllImport(LibraryName, EntryPoint = "SDL_GetHintBoolean", CallingConvention = CallingConvention.Cdecl)]
    private static extern unsafe bool INTERNAL_GetHintBoolean(
        byte* name,
        bool default_value
    );
    public static unsafe bool GetHintBoolean(
        string name,
        bool default_value
    )
    {
        int utf8NameBufSize = InternalUtils.Utf8Size(name);
        byte* utf8Name = stackalloc byte[utf8NameBufSize];
        return INTERNAL_GetHintBoolean(
            InternalUtils.Utf8Encode(name, utf8Name, utf8NameBufSize),
            default_value
        );
    }
}