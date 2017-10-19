using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set audio track.
    /// </summary>
    [LibVlcFunction("libvlc_audio_set_track")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAudioTrack(VlcMediaPlayerHandle mediaPlayerInstance, int trackId);
}
