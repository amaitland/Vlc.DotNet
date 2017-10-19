using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public VlcMediaHandle CreateNewMediaFromFileDescriptor(int fileDescriptor)
		{
			EnsureVlcInstance();

			var mediaHandle = GetInteropDelegate<CreateNewMediaFromFileDescriptor>().Invoke(myVlcInstance, fileDescriptor); ;
			mediaHandle.ReleaseMedia = GetInteropDelegate<ReleaseMedia>();
			return mediaHandle;
		}
	}
}
