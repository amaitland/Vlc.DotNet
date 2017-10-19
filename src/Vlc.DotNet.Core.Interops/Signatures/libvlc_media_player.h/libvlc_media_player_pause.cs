using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Toggle pause (no effect if there is no media).
    /// </summary>
    [LibVlcFunction("libvlc_media_player_pause")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void Pause(VlcMediaPlayerHandle mediaPlayerInstance);
}
