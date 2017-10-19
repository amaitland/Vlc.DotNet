using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public VlcMediaHandle GetMediaFromMediaPlayer(VlcMediaPlayerHandle mediaPlayerInstance)
		{
			if (mediaPlayerInstance.IsInvalid)
				throw new ArgumentException("Media player instance is not initialized.");

			var mediaHandle = GetInteropDelegate<GetMediaFromMediaPlayer>().Invoke(mediaPlayerInstance);
			mediaHandle.ReleaseMedia = GetInteropDelegate<ReleaseMedia>();

			return mediaHandle;
		}
	}
}
