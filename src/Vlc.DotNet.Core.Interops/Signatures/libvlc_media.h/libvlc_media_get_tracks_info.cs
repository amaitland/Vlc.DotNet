using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get media descriptor's elementary streams description.
    /// </summary>
    [LibVlcFunction("libvlc_media_get_tracks_info")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetMediaTracksInformations(VlcMediaHandle mediaInstance, out IntPtr tracksInformationsPointer);
}
