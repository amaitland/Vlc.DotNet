using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoLogoEnabled(VlcMediaPlayerHandle mediaPlayerInstance, bool value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Enable, value ? 1 : 0);
        }
        public void SetVideoLogoFile(VlcMediaPlayerHandle mediaPlayerInstance, string value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            using (var valueInterop = Utf8InteropStringConverter.ToUtf8Interop(value))
            {
                GetInteropDelegate<SetVideoLogoString>().Invoke(mediaPlayerInstance, VideoLogoOptions.File, valueInterop.DangerousGetHandle());
            }
        }
        public void SetVideoLogoX(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.X, value);
        }
        public void SetVideoLogoY(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Y, value);
        }
        public void SetVideoLogoDelay(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Delay, value);
        }
        public void SetVideoLogoRepeat(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Repeat, value);
        }
        public void SetVideoLogoOpacity(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Opacity, value);
        }
        public void SetVideoLogoPosition(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Position, value);
        }
    }
}
