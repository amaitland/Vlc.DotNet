using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get length of movie playing
    /// </summary>
    /// <returns>Get the requested movie play rate.</returns>
    [LibVlcFunction("libvlc_media_player_get_length")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate long GetLength(VlcMediaPlayerHandle mediaPlayerInstance);
}
