using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get current mute status.
    /// </summary>
    [LibVlcFunction("libvlc_audio_get_mute")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsMute(VlcMediaPlayerHandle mediaPlayerInstance);
}
