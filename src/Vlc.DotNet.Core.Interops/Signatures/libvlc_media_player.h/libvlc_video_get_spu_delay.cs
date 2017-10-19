using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get the current subtitle delay.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_spu_delay")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate long GetVideoSpuDelay(VlcMediaPlayerHandle mediaPlayerInstance);
}
