using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get event manager from media descriptor object.
    /// </summary>
    [LibVlcFunction("libvlc_media_event_manager")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate VlcEventManagerHandle GetMediaEventManager(VlcMediaHandle mediaInstance);
}
