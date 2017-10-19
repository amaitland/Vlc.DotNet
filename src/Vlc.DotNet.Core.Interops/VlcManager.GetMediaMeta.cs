using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public string GetMediaMeta(VlcMediaHandle mediaInstance, MediaMetadatas metadata)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            var ptr = GetInteropDelegate<GetMediaMetadata>().Invoke(mediaInstance, metadata);
            return Utf8InteropStringConverter.Utf8InteropToString(ptr);
        }
    }
}
