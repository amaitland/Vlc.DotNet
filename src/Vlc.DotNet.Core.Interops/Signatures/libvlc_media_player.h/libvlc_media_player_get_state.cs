using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get the media state.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_get_state")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate MediaStates GetMediaPlayerState(VlcMediaPlayerHandle mediaPlayerInstance);
}
