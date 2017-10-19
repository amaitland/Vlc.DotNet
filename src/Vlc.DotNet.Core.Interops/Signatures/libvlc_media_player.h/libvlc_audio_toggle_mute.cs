using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Toggle mute status.
    /// </summary>
    [LibVlcFunction("libvlc_audio_toggle_mute")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ToggleMute(VlcMediaPlayerHandle mediaPlayerInstance);
}
