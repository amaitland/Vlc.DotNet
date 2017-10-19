using System;
using System.Runtime.InteropServices;
using System.Security;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops.Handles
{
    [SecurityCritical]
    public sealed class VlcMediaHandle : SafeHandle
    {
        private static IntPtr MinusOne = new IntPtr(-1);

        internal ReleaseMedia ReleaseMedia { get; set; }

        [SecurityCritical]
        internal VlcMediaHandle() : base(IntPtr.Zero, true)
        {
        }

        [SecurityCritical]
        internal VlcMediaHandle(IntPtr handle, bool ownsHandle) : base(IntPtr.Zero, ownsHandle)
        {
            SetHandle(handle);
        }

        [SecurityCritical]
        protected override bool ReleaseHandle()
        {
            ReleaseMedia.Invoke(handle);

            return true;
        }

        public override bool IsInvalid
        {
            [SecurityCritical]
            get { return handle == IntPtr.Zero || handle == MinusOne; }
        }
    }
}
