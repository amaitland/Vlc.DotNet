using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set video track.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_track")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoTrack(VlcMediaPlayerHandle mediaPlayerInstance, int trackId);
}
