using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool GetVideoAdjustEnabled(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustInteger>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Enable) == 1;
        }

        public float GetVideoAdjustContrast(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Contrast);
        }

        public float GetVideoAdjustBrightness(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Brightness);
        }

        public float GetVideoAdjustHue(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Hue);
        }

        public float GetVideoAdjustSaturation(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Saturation);
        }

        public float GetVideoAdjustGamma(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Gamma);
        }
    }
}
