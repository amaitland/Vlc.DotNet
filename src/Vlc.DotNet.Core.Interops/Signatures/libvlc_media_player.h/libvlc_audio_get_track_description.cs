using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get the description of available audio tracks.
    /// </summary>
    [LibVlcFunction("libvlc_audio_get_track_description")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetAudioTracksDescriptions(VlcMediaPlayerHandle mediaPlayerInstance);
}
