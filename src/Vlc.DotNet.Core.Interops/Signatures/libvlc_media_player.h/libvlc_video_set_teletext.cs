using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set new teletext page to retrieve.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_teletext")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoTeletext(VlcMediaPlayerHandle mediaPlayerInstance, int page);
}
