using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get current video track.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_track")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoTrack(VlcMediaPlayerHandle mediaPlayerInstance);
}
