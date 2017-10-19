using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get the description of available video subtitles.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_spu_description")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetVideoSpuDescription(VlcMediaPlayerHandle mediaPlayerInstance);
}
