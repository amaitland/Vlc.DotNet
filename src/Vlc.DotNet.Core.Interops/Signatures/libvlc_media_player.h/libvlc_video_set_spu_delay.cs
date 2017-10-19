using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set the subtitle delay.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_spu_delay")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoSpuDelay(VlcMediaPlayerHandle mediaPlayerInstance, long delay);
}
