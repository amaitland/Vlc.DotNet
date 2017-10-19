using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetMediaPosition(VlcMediaPlayerHandle mediaPlayerInstance, float position)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetMediaPosition>().Invoke(mediaPlayerInstance, position);
        }
    }
}
