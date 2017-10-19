using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Release a list of module descriptions.
    /// </summary>
    [LibVlcFunction("libvlc_audio_filter_list_get")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetAudioFilterList(VlcInstanceHandle instance);
}
