using System;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void DetachEvent(VlcEventManagerHandle eventManagerInstance, EventTypes eventType, EventCallback callback)
        {
            if (eventManagerInstance.IsInvalid)
                throw new ArgumentException("Event manager is not initialized.");
            if (callback == null)
                return;
            GetInteropDelegate<DetachEvent>().Invoke(eventManagerInstance, eventType, callback, IntPtr.Zero);
        }
    }
}
