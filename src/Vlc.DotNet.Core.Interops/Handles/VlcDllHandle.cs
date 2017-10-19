using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Vlc.DotNet.Core.Interops.Handles
{
    [SecurityCritical]
    public sealed class VlcDllHandle : SafeHandle
    {
        private static IntPtr MinusOne = new IntPtr(-1);

        [SecurityCritical]
        internal VlcDllHandle() : base(IntPtr.Zero, true)
        {
        }

        [SecurityCritical]
        internal VlcDllHandle(IntPtr handle, bool ownsHandle) : base(IntPtr.Zero, ownsHandle)
        {
            SetHandle(handle);
        }

        [SecurityCritical]
        protected override bool ReleaseHandle()
        {
            return Win32Interops.FreeLibrary(handle);
        }

        public override bool IsInvalid
        {
            [SecurityCritical]
            get { return handle == IntPtr.Zero || handle == MinusOne; }
        }
    }
}
