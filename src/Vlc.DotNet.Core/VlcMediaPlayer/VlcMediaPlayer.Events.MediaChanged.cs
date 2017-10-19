using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core
{
	public sealed partial class VlcMediaPlayer
	{
		private EventCallback myOnMediaPlayerMediaChangedInternalEventCallback;
		public event EventHandler<VlcMediaPlayerMediaChangedEventArgs> MediaChanged;

		private void OnMediaPlayerMediaChangedInternal(IntPtr ptr)
		{
#if NET20 || NET35 || NET40 || NET45
			var args = (VlcEventArg)Marshal.PtrToStructure(ptr, typeof(VlcEventArg));
#else
			var args = Marshal.PtrToStructure<VlcEventArg>(ptr);
#endif
			//TODO: Look at strongly typing arg property
			var mediaInstance = new VlcMediaHandle(args.eventArgsUnion.MediaPlayerMediaChanged.MediaInstance, true)
			{
				ReleaseMedia = Manager.GetInteropDelegate<ReleaseMedia>()
			};
			OnMediaPlayerMediaChanged(new VlcMedia(this, mediaInstance));
		}

		public void OnMediaPlayerMediaChanged(VlcMedia media)
		{
			var del = MediaChanged;
			if (del != null)
				del(this, new VlcMediaPlayerMediaChangedEventArgs(media));
		}
	}
}