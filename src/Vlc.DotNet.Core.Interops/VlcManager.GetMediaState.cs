using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public MediaStates GetMediaState(VlcMediaHandle mediaInstance)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            return GetInteropDelegate<GetMediaState>().Invoke(mediaInstance);
        }
    }
}
