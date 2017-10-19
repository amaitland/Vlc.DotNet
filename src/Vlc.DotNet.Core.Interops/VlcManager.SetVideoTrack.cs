using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoTrack(VlcMediaPlayerHandle mediaPlayerInstance, TrackDescriptionStructure trackDescription)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            SetVideoTrack(mediaPlayerInstance, trackDescription.Id);
        }

        public void SetVideoTrack(VlcMediaPlayerHandle mediaPlayerInstance, int id)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoTrack>().Invoke(mediaPlayerInstance, id);
        }
    }
}
