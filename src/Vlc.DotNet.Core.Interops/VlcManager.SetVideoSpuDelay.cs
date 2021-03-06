﻿using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoSpuDelay(VlcMediaPlayerHandle mediaPlayerInstance, long delay)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoSpuDelay>().Invoke(mediaPlayerInstance, delay);
        }
    }
}
