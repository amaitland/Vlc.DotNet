using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get current video subtitle.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_spu")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetVideoSpu(VlcMediaPlayerHandle mediaPlayerInstance);
}
