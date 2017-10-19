using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get current state of media descriptor object.
    /// </summary>
    [LibVlcFunction("libvlc_media_get_state")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate MediaStates GetMediaState(VlcMediaHandle mediaInstance);
}
