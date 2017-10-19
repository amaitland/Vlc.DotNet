using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    ///  Get long name of device, if not available short name given.
    /// </summary>
    [LibVlcFunction("libvlc_audio_output_device_longname")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr GetAudioOutputDeviceLongName(VlcInstanceHandle instance, IntPtr audioOutputName, int deviceIndex);
}
