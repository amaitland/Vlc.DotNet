using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoCropGeometry(VlcMediaPlayerHandle mediaPlayerInstance, string cropGeometry)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");

            using (var cropGeometryInterop = Utf8InteropStringConverter.ToUtf8Interop(cropGeometry))
            {
                GetInteropDelegate<SetVideoCropGeometry>()
                    .Invoke(mediaPlayerInstance, cropGeometryInterop.DangerousGetHandle());
            }
        }
    }
}
