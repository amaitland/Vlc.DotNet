using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Returns a list of video filters that are available.
    /// </summary>
    [LibVlcFunction("libvlc_video_filter_list_get")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetVideoFilterList(VlcInstanceHandle instance);
}
