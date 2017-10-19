using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Enable or disable deinterlace filter.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_deinterlace")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoDeinterlace(VlcMediaPlayerHandle mediaPlayerInstance, IntPtr mode);
}
