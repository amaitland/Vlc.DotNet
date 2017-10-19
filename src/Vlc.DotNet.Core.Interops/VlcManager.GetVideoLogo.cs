using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool GetVideoLogoEnabled(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Enable) == 1;
        }

        public int GetVideoLogoX(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.X);
        }
        public int GetVideoLogoY(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Y);
        }
        public int GetVideoLogoDelay(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Delay);
        }
        public int GetVideoLogoRepeat(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Repeat);
        }
        public int GetVideoLogoOpacity(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Opacity);
        }
        public int GetVideoLogoPosition(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Position);
        }
    }
}
