using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Create a media with a certain given media resource location, for instance a valid URL.
    /// </summary>
    /// <returns>Return the newly created media or NULL on error.</returns>
    [LibVlcFunction("libvlc_media_new_location")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate VlcMediaHandle CreateNewMediaFromLocation(VlcInstanceHandle instance, SafeUnmanagedMemoryHandle mrl);
}
