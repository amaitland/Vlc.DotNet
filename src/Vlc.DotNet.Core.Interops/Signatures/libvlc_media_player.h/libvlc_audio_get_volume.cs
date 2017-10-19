using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get current software audio volume.
    /// </summary>
    [LibVlcFunction("libvlc_audio_get_volume")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVolume(VlcMediaPlayerHandle mediaPlayerInstance);
}
