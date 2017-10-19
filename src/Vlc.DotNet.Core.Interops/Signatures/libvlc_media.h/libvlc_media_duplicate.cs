using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Duplicate a media descriptor object.
    /// </summary>
    /// <returns>Return a media descriptor object.</returns>
    [LibVlcFunction("libvlc_media_duplicate")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate VlcMediaHandle CloneMedia(VlcMediaHandle mediaInstance);
}
