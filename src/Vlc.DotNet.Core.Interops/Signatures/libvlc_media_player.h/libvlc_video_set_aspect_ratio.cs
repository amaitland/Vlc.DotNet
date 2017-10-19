using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set current crop filter geometry.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_aspect_ratio")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoAspectRatio(VlcMediaPlayerHandle mediaPlayerInstance, IntPtr cropGeometry);
}
