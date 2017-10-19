using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoSpu(VlcMediaPlayerHandle mediaPlayerInstance, TrackDescriptionStructure trackDescription)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            SetVideoSpu(mediaPlayerInstance, trackDescription.Id);
        }

        public void SetVideoSpu(VlcMediaPlayerHandle mediaPlayerInstance, int id)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            GetInteropDelegate<SetVideoSpu>().Invoke(mediaPlayerInstance, id);
        }
    }
}
