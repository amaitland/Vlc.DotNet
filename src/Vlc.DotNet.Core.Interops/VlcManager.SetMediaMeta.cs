using System;
using System.Runtime.InteropServices;
using System.Text;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetMediaMeta(VlcMediaHandle mediaInstance, MediaMetadatas metadata, string value)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            using (var handle = Utf8InteropStringConverter.ToUtf8Interop(value))
            {
                GetInteropDelegate<SetMediaMetadata>().Invoke(mediaInstance, metadata, handle.DangerousGetHandle());
            }
        }
    }
}
