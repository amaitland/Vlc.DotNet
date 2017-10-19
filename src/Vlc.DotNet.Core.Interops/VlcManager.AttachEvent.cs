using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public int AttachEvent(VlcEventManagerHandle eventManagerInstance, EventTypes eventType, EventCallback callback)
        {
            if (eventManagerInstance.IsInvalid)
                throw new ArgumentException("Event manager instance is not initialized.");
            if (callback == null)
                throw new ArgumentException("Callback for event is not initialized.");
            return GetInteropDelegate<AttachEvent>().Invoke(eventManagerInstance, eventType, callback, IntPtr.Zero);
        }
    }
}
