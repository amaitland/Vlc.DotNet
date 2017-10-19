using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoAspectRatio(VlcMediaPlayerHandle mediaPlayerInstance, string aspectRatio)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");

            using (var aspectRatioInterop = Utf8InteropStringConverter.ToUtf8Interop(aspectRatio))
            {
                GetInteropDelegate<SetVideoAspectRatio>().Invoke(mediaPlayerInstance, aspectRatioInterop.DangerousGetHandle());
            }
        }
    }
}
