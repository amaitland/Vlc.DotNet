using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
	{
		public void SetVideoCallbacks(VlcMediaPlayerHandle mediaPlayerInstance, LockVideoCallback lockVideoCallback, UnlockVideoCallback unlockVideoCallback, DisplayVideoCallback displayVideoCallback, IntPtr userData)
		{
			GetInteropDelegate<SetVideoCallbacks>().Invoke(mediaPlayerInstance, lockVideoCallback, unlockVideoCallback, displayVideoCallback, userData);
		}
	}
}
