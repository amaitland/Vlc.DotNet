using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set logo option as integer.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_logo_int")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoLogoInteger(VlcMediaPlayerHandle mediaPlayerInstance, VideoLogoOptions option, int value);
}
