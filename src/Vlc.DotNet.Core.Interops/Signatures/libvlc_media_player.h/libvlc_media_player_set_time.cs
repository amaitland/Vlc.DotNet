using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get time at which movie is playing.
    /// </summary>
    /// <returns>Get the requested movie play time.</returns>
    [LibVlcFunction("libvlc_media_player_set_time")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetTime(VlcMediaPlayerHandle mediaPlayerInstance, long time);
}