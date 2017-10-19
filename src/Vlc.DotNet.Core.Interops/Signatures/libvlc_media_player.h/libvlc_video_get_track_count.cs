using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get number of available video tracks.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_track_count")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoTracksCount(VlcMediaPlayerHandle mediaPlayerInstance);
}
