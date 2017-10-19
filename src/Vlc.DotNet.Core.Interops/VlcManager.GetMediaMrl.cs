using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public string GetMediaMrl(VlcMediaHandle mediaInstance)
		{
			if (mediaInstance.IsInvalid)
				throw new ArgumentException("Media instance is not initialized.");
			var ptr = GetInteropDelegate<GetMediaMrl>().Invoke(mediaInstance);
			return Utf8InteropStringConverter.Utf8InteropToString(ptr);
		}
	}
}
