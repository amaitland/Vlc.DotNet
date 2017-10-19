using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoAdjustEnabled(VlcMediaPlayerHandle mediaPlayerInstance, bool value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustInteger>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Enable, value ? 1 : 0);
        }
        public void SetVideoAdjustContrast(VlcMediaPlayerHandle mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Contrast, value);
        }
        public void SetVideoAdjustBrightness(VlcMediaPlayerHandle mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Brightness, value);
        }
        public void SetVideoAdjustHue(VlcMediaPlayerHandle mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Hue, value);
        }
        public void SetVideoAdjustSaturation(VlcMediaPlayerHandle mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Saturation, value);
        }
        public void SetVideoAdjustGamma(VlcMediaPlayerHandle mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Gamma, value);
        }
    }
}
