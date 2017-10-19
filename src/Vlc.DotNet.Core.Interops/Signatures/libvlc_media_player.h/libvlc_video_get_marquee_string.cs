using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get a string marquee option value.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_marquee_string")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetVideoMarqueeString(VlcMediaPlayerHandle mediaPlayerInstance, VideoMarqueeOptions option);
}
