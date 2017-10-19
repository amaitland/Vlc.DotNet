using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Add an option to the media.
    /// </summary>
    [LibVlcFunction("libvlc_media_add_option")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void AddOptionToMedia(VlcMediaHandle mediaInstance, IntPtr mrl);
}
