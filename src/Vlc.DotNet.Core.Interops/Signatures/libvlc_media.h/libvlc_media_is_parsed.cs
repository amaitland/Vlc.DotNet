using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get Parsed status for media descriptor object.
    /// </summary>
    [LibVlcFunction("libvlc_media_is_parsed")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int IsParsedMedia(VlcMediaHandle mediaInstance);
}
