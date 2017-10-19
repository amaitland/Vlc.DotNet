using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public IntPtr GetMediaPlayerVideoHostHandle(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetMediaPlayerVideoHostHandle>().Invoke(mediaPlayerInstance);
        }
    }
}
