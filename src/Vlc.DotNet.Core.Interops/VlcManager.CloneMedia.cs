using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public VlcMediaHandle CloneMedia(VlcMediaHandle mediaInstance)
		{
			if (mediaInstance.IsInvalid)
				throw new ArgumentException("Media instance is not initialized.");
			var newMediaInstance = GetInteropDelegate<CloneMedia>().Invoke(mediaInstance);
			newMediaInstance.ReleaseMedia = mediaInstance.ReleaseMedia;

			return newMediaInstance;
		}
	}
}
