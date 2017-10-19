using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Read a meta of the media.
    /// </summary>
    [LibVlcFunction("libvlc_media_get_meta")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetMediaMetadata(VlcMediaHandle mediaInstance, MediaMetadatas meta);
}
