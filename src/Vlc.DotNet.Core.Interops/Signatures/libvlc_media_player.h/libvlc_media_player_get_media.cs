﻿using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get the media used by the media_player.
    /// </summary>
    /// <returns>Return the media associated with p_mi, or NULL if no media is associated.</returns>
    [LibVlcFunction("libvlc_media_player_get_media")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate VlcMediaHandle GetMediaFromMediaPlayer(VlcMediaPlayerHandle mediaPlayerInstance);
}
