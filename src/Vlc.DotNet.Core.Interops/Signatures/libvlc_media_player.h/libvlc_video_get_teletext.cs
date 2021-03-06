﻿using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get current teletext page requested.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_teletext")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoTeletext(VlcMediaPlayerHandle mediaPlayerInstance);
}
