using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool GetVideoMarqueeEnabled(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Enable) == 1;
        }
        public string GetVideoMarqueeText(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return Utf8InteropStringConverter.Utf8InteropToString(GetInteropDelegate<GetVideoMarqueeString>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Text));
        }
        public int GetVideoMarqueeColor(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Color);
        }
        public int GetVideoMarqueeOpacity(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Opacity);
        }
        public int GetVideoMarqueePosition(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Position);
        }
        public int GetVideoMarqueeRefresh(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Refresh);
        }
        public int GetVideoMarqueeSize(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Size);
        }
        public int GetVideoMarqueeTimeout(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Timeout);
        }
        public int GetVideoMarqueeX(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.X);
        }
        public int GetVideoMarqueeY(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Y);
        }
    }
}
