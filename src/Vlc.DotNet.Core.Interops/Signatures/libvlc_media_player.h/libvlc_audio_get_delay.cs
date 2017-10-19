using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
	/// <summary>
	/// Get current audio delay.
	/// </summary>
	[LibVlcFunction("libvlc_audio_get_delay")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate long GetAudioDelay(VlcMediaPlayerHandle mediaPlayerInstance);
}
