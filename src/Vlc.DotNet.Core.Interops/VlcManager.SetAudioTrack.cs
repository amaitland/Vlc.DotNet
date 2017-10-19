using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetAudioTrack(VlcMediaPlayerHandle mediaPlayerInstance, TrackDescriptionStructure trackDescription)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            SetAudioTrack(mediaPlayerInstance, trackDescription.Id);
        }

        public void SetAudioTrack(VlcMediaPlayerHandle mediaPlayerInstance, int id)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetAudioTrack>().Invoke(mediaPlayerInstance, id);
        }
    }
}
