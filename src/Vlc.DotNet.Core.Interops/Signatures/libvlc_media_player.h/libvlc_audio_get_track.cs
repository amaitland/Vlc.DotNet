using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
	/// <summary>
	/// Get current audio track.
	/// </summary>
	[LibVlcFunction("libvlc_audio_get_track")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int GetAudioTrack(VlcMediaPlayerHandle mediaPlayerInstance);
}
