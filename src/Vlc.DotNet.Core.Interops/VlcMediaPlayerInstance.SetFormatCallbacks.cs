using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public void SetVideoFormatCallbacks(VlcMediaPlayerHandle mediaPlayerInstance, VideoFormatCallback videoFormatCallback, CleanupVideoCallback cleanupCallback)
		{
			GetInteropDelegate<SetVideoFormatCallbacks>().Invoke(mediaPlayerInstance, videoFormatCallback, cleanupCallback);
		}
	}
}
