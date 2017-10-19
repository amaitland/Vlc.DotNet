using System;
using System.Runtime.InteropServices;
using System.Security;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops.Handles
{
	[SecurityCritical] 
	public sealed class VlcInstanceHandle : SafeHandle
	{
		private static IntPtr MinusOne = new IntPtr(-1);

		internal ReleaseInstance ReleaseInstance { get; set; }

		[SecurityCritical]
		internal VlcInstanceHandle() : base(IntPtr.Zero, true)
		{
		}

		[SecurityCritical]
		internal VlcInstanceHandle(IntPtr handle, bool ownsHandle) : base(IntPtr.Zero, ownsHandle)
		{
			SetHandle(handle);
		}

		[SecurityCritical]
		protected override bool ReleaseHandle()
		{
			ReleaseInstance.Invoke(handle);

			return true;
		}

		public override bool IsInvalid
		{
			[SecurityCritical]
			get { return handle == IntPtr.Zero || handle == MinusOne; }
		}
	}
}
