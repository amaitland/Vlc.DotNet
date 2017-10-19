using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core
{
	public partial class VlcMedia
	{
		private EventCallback myOnMediaSubItemTreeAddedInternalEventCallback;
		public event EventHandler<VlcMediaSubItemTreeAddedEventArgs> SubItemTreeAdded;

		private void OnMediaSubItemTreeAddedInternal(IntPtr ptr)
		{
#if NET20 || NET35 || NET40 || NET45
			var args = (VlcEventArg)Marshal.PtrToStructure(ptr, typeof(VlcEventArg));
#else
			var args = Marshal.PtrToStructure<VlcEventArg>(ptr);
#endif
			//TODO: Look at strongly typing arg property
			var mediaInstance = new VlcMediaHandle(args.eventArgsUnion.MediaSubItemTreeAdded.MediaInstance, true)
			{
				ReleaseMedia = myVlcMediaPlayer.Manager.GetInteropDelegate<ReleaseMedia>()
			};

			OnMediaSubItemTreeAdded(new VlcMedia(myVlcMediaPlayer, mediaInstance));
		}

		public void OnMediaSubItemTreeAdded(VlcMedia newSubItemAdded)
		{
			var del = SubItemTreeAdded;
			if (del != null)
				del(this, new VlcMediaSubItemTreeAddedEventArgs(newSubItemAdded));
		}
	}
}