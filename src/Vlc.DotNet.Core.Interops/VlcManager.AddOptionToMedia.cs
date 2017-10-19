using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
    {
        public void AddOptionToMedia(VlcMediaHandle mediaInstance, string option)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            if (string.IsNullOrEmpty(option))
                return;

            using (var handle = Utf8InteropStringConverter.ToUtf8Interop(option))
            {
                GetInteropDelegate<AddOptionToMedia>().Invoke(mediaInstance, handle.DangerousGetHandle());
            }
        }

        public void AddOptionToMedia(VlcMediaHandle mediaInstance, string[] options)
        {
            if (mediaInstance.IsInvalid)
                throw new ArgumentException("Media instance is not initialized.");
            options = options ?? new string[0];
            foreach (var option in options)
            {
                AddOptionToMedia(mediaInstance, option);
            }
        }
    }
}
