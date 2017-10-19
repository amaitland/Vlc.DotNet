using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set an integer marquee option value.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_marquee_int")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoMarqueeInteger(VlcMediaPlayerHandle mediaPlayerInstance, VideoMarqueeOptions option, int value);
}
