using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetMute(VlcMediaPlayerHandle mediaPlayerInstance, bool status)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetMute>().Invoke(mediaPlayerInstance, status ? 1 : 0);
        }
    }
}
