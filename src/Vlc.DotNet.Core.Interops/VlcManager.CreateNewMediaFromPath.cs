using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public VlcMediaHandle CreateNewMediaFromPath(string mrl)
		{
			EnsureVlcInstance();

			using (var handle = Utf8InteropStringConverter.ToUtf8Interop(mrl))
			{
				var mediaHandle = GetInteropDelegate<CreateNewMediaFromPath>().Invoke(myVlcInstance, handle); ;
				mediaHandle.ReleaseMedia = GetInteropDelegate<ReleaseMedia>();
				return mediaHandle;
			}
		}
	}
}
