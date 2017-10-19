using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool IsPlaying(VlcMediaPlayerHandle mediaPlayerInstance)
        {
            if (mediaPlayerInstance.IsInvalid) return false;
            //This seems to be called multiple time
            //Eventually throwing an uncaught exception on close
            //An unhandled exception of type 'System.ArgumentException' occurred in Vlc.DotNet.Core.Interops.dll
            //Additional information: Media player instance is not initialized.
            //if (mediaPlayerInstance.IsInvalid)
            //    throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<IsPlaying>().Invoke(mediaPlayerInstance) == 1;
        }
    }
}
