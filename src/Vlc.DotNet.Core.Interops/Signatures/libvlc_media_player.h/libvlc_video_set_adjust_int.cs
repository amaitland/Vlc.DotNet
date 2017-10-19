using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set adjust option as integer.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_adjust_int")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoAdjustInteger(VlcMediaPlayerHandle mediaPlayerInstance, VideoAdjustOptions option, int value);
}
