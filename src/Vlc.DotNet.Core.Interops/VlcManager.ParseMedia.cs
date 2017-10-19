using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void ParseMedia(VlcMediaHandle mediaInstance)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            GetInteropDelegate<ParseMedia>().Invoke(mediaInstance);
        }
    }
}
