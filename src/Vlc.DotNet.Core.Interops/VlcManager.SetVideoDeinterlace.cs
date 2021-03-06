﻿using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoDeinterlace(VlcMediaPlayerHandle mediaPlayerInstance, string deinterlaceMode)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            using (var deinterlaceModeInterop = Utf8InteropStringConverter.ToUtf8Interop(deinterlaceMode))
            {
                GetInteropDelegate<SetVideoDeinterlace>().Invoke(mediaPlayerInstance, deinterlaceModeInterop.DangerousGetHandle());
            }
        }
    }
}
