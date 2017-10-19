using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public MediaStatsStructure GetMediaStats(VlcMediaHandle mediaInstance)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            MediaStatsStructure result;
            GetInteropDelegate<GetMediaStats>().Invoke(mediaInstance, out result);
            return result;
        }
    }
}
