using System;
using System.IO;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void TakeSnapshot(VlcMediaPlayerHandle mediaPlayerInstance, FileInfo file, uint width, uint height)
        {
            if (mediaPlayerInstance.IsInvalid)
                throw new ArgumentException("Media player instance is not initialized.");
            if(file == null)
                throw new ArgumentNullException("file");
            GetInteropDelegate<TakeSnapshot>().Invoke(mediaPlayerInstance, 0, file.FullName, width, height);
        }
    }
}
