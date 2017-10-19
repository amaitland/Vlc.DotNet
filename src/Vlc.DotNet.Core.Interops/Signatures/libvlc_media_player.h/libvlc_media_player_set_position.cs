using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get media position.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_set_position")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaPosition(VlcMediaPlayerHandle mediaPlayerInstance, float position);
}
