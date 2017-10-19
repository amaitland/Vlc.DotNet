﻿using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Create an empty Media Player object.
    /// </summary>
    /// <returns>Return a new media player object, or NULL on error.</returns>
    [LibVlcFunction("libvlc_media_player_new")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate VlcMediaPlayerHandle CreateMediaPlayer(VlcInstanceHandle instance);
}
