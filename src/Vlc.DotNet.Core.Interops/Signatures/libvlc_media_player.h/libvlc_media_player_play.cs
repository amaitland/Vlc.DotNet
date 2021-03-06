﻿using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Play.
    /// </summary>
    /// <returns>Return 0 if playback started (and was already started), or -1 on error.</returns>
    [LibVlcFunction("libvlc_media_player_play")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int Play(VlcMediaPlayerHandle mediaPlayerInstance);
}
