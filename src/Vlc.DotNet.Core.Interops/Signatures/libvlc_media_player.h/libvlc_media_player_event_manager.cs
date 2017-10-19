﻿using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get the Event Manager from which the media player send event.
    /// </summary>
    /// <returns>Return the event manager associated with media player.</returns>
    [LibVlcFunction("libvlc_media_player_event_manager")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate VlcEventManagerHandle GetMediaPlayerEventManager(VlcMediaPlayerHandle mediaPlayerInstance);
}
