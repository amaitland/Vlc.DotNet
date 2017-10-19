using System;
using System.Collections.Generic;
using System.Text;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops
{
	public static class VlcMediaInstanceExtensions
	{
#if NET20
		public static VlcMediaHandle AddOptionToMedia(VlcMediaHandle mediaInstance, VlcManager manager, string option)
#else
		public static VlcMediaHandle AddOptionToMedia(this VlcMediaHandle mediaInstance, VlcManager manager, string option)
#endif
		{
			manager.AddOptionToMedia(mediaInstance, option);
			return mediaInstance;
		}

#if NET20
		public static VlcMediaHandle AddOptionToMedia(VlcMediaHandle mediaInstance, VlcManager manager, string[] option)
#else
		public static VlcMediaHandle AddOptionToMedia(this VlcMediaHandle mediaInstance, VlcManager manager, string[] option)
#endif
		{
			manager.AddOptionToMedia(mediaInstance, option);
			return mediaInstance;
		}
	}
}
