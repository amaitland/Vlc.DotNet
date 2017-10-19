using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get number of available audio tracks.
    /// </summary>
    [LibVlcFunction("libvlc_audio_get_track_count")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetAudioTracksCount(VlcMediaPlayerHandle mediaPlayerInstance);
}
