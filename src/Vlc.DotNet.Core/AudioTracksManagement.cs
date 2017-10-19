using System.Collections.Generic;
using Vlc.DotNet.Core.Interops;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core
{
    public sealed class AudioTracksManagement : ITracksManagement
    {
        private readonly VlcManager myManager;
        private readonly VlcMediaPlayerHandle myMediaPlayer;

        internal AudioTracksManagement(VlcManager manager, VlcMediaPlayerHandle mediaPlayerInstance)
        {
            myManager = manager;
            myMediaPlayer = mediaPlayerInstance;
        }

        public int Count
        {
            get { return myManager.GetAudioTracksCount(myMediaPlayer); }
        }

        public TrackDescription Current
        {
            get
            {
                var currentId = myManager.GetAudioTrack(myMediaPlayer);
                foreach (var track in All)
                {
                    if (track.ID == currentId)
                        return track;
                }
                return null;
            }
            set { myManager.SetAudioTrack(myMediaPlayer, value.ID); }
        }

        public IEnumerable<TrackDescription> All
        {
            get
            {
                var module = myManager.GetAudioTracksDescriptions(myMediaPlayer);
                var result = TrackDescription.GetSubTrackDescription(module);
                myManager.ReleaseTrackDescription(module);
                return result;
            }
        }
    }
}
