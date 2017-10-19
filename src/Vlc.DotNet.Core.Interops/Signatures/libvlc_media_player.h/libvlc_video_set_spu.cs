using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set new video subtitle.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_spu")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoSpu(VlcMediaPlayerHandle mediaPlayerInstance, int spu);
}
