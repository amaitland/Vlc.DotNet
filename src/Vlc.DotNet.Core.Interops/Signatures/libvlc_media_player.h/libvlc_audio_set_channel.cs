using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set current audio channel.
    /// </summary>
    [LibVlcFunction("libvlc_audio_set_channel")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAudioChannel(VlcMediaPlayerHandle mediaPlayerInstance, int channel);
}
