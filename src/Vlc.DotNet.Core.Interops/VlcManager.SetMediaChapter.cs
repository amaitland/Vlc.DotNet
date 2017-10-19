using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetMediaChapter(VlcMediaPlayerHandle mediaPlayerInstance, int chapter)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetMediaChapter>().Invoke(mediaPlayerInstance, chapter);
        }
    }
}
