using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set current crop filter geometry.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_crop_geometry")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoCropGeometry(VlcMediaPlayerHandle mediaPlayerInstance, IntPtr cropGeometry);
}
