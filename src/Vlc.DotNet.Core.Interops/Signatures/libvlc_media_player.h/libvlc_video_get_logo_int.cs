using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get integer logo option.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_logo_int")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoLogoInteger(VlcMediaPlayerHandle mediaPlayerInstance, VideoLogoOptions option);
}
