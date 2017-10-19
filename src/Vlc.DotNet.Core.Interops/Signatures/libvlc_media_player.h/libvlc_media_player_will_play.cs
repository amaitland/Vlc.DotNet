using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Is the player able to play.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_will_play")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int CouldPlay(VlcMediaPlayerHandle mediaPlayerInstance);
}
