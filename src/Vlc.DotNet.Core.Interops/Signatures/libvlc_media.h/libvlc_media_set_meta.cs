using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set the meta of the media (this function will not save the meta, call SaveMediaMeta in order to save the meta)
    /// </summary>
    [LibVlcFunction("libvlc_media_set_meta")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaMetadata(VlcMediaHandle mediaInstance, MediaMetadatas meta, IntPtr value);
}
