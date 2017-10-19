using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoMarqueeEnabled(VlcMediaPlayerHandle mediaPlayerInstance, bool value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Enable, value ? 1 : 0);
        }
        public void SetVideoMarqueeText(VlcMediaPlayerHandle mediaPlayerInstance, string value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            using (var valueInterop = Utf8InteropStringConverter.ToUtf8Interop(value))
            {
                GetInteropDelegate<SetVideoMarqueeString>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Text, valueInterop.DangerousGetHandle());
            }
        }
        public void SetVideoMarqueeColor(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Color, value);
        }
        public void SetVideoMarqueeOpacity(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Opacity, value);
        }
        public void SetVideoMarqueePosition(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Position, value);
        }
        public void SetVideoMarqueeRefresh(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Refresh, value);
        }
        public void SetVideoMarqueeSize(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Size, value);
        }
        public void SetVideoMarqueeTimeout(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Timeout, value);
        }
        public void SetVideoMarqueeX(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.X, value);
        }
        public void SetVideoMarqueeY(VlcMediaPlayerHandle mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Y, value);
        }
    }
}
