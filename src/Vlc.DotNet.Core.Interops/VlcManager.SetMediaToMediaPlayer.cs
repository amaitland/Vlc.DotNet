using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetMediaToMediaPlayer(VlcMediaPlayerHandle mediaPlayerInstance, VlcMediaHandle mediaInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            GetInteropDelegate<SetMediaToMediaPlayer>().Invoke(mediaPlayerInstance, mediaInstance);
        }
    }
}
