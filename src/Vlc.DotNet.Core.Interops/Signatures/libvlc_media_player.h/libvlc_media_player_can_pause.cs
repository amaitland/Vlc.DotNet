using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Check if media player can pause.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_can_pause")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsPausable(VlcMediaPlayerHandle mediaPlayerInstance);
}
