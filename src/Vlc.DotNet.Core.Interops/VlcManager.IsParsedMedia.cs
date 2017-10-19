using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool IsParsedMedia(VlcMediaHandle mediaInstance)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            return GetInteropDelegate<IsParsedMedia>().Invoke(mediaInstance) == 1;
        }
    }
}
