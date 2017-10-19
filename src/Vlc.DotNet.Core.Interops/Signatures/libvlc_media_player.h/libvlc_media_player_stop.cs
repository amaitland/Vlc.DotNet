using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Stop.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_stop")]
    [UnmanagedFunctionPointer(callingConvention: CallingConvention.Cdecl)]
    internal delegate void Stop(VlcMediaPlayerHandle mediaPlayerInstance);
}
