using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetTime(VlcMediaPlayerHandle mediaInstance, long timeInMs)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            GetInteropDelegate<SetTime>().Invoke(mediaInstance, timeInMs);
        }
    }
}