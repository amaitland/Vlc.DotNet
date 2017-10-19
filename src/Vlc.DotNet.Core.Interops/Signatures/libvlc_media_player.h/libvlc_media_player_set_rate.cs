using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set the requested media play rate.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_set_rate")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetRate(VlcMediaPlayerHandle mediaPlayerInstance, float rate);
}
