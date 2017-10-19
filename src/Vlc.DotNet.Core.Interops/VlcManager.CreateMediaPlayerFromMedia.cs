using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public VlcMediaPlayerHandle CreateMediaPlayerFromMedia(VlcMediaHandle mediaInstance)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            return GetInteropDelegate<CreateMediaPlayerFromMedia>().Invoke(mediaInstance);
        }
    }
}
