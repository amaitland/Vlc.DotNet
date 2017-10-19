using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get current audio channel.
    /// </summary>
    [LibVlcFunction("libvlc_audio_get_channel")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetAudioChannel(VlcMediaPlayerHandle mediaPlayerInstance);
}
