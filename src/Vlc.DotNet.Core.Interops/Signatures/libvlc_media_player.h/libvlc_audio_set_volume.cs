using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set current software audio volume.
    /// </summary>
    [LibVlcFunction("libvlc_audio_set_volume")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVolume(VlcMediaPlayerHandle mediaPlayerInstance, int volume);
}
