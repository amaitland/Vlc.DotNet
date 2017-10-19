using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public VlcMediaPlayerHandle CreateMediaPlayer()
		{
			EnsureVlcInstance();

			var mediaPlayerHandle = GetInteropDelegate<CreateMediaPlayer>().Invoke(myVlcInstance);

			mediaPlayerHandle.ReleaseDelegate = GetInteropDelegate<ReleaseMediaPlayer>();

			return mediaPlayerHandle;
		}
	}
}
