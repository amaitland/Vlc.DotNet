using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set a string marquee option value.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_marquee_string")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoMarqueeString(VlcMediaPlayerHandle mediaPlayerInstance, VideoMarqueeOptions option, IntPtr value);
}
