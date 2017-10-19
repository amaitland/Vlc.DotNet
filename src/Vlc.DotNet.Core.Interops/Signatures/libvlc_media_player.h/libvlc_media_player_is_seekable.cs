using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get media is seekable.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_is_seekable")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsSeekable(VlcMediaPlayerHandle mediaPlayerInstance);
}
