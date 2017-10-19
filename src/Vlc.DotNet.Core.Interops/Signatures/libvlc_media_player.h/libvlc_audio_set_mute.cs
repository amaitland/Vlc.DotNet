using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set current mute status.
    /// </summary>
    [LibVlcFunction("libvlc_audio_set_mute")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMute(VlcMediaPlayerHandle mediaPlayerInstance, int status);
}
