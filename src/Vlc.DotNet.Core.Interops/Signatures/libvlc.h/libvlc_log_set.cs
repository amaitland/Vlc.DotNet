using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
	/// <summary>
	/// Registers a log callback
	/// </summary>
	/// <param name="instance">The libvlc instance.</param>
	/// <param name="callback">The method that will be called whenever a log is available.</param>
	/// <param name="userData">User provided data to carry with the event.</param>
	[LibVlcFunction("libvlc_log_set")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SetLog(VlcInstanceHandle instance, LogCallback callback, IntPtr userData);
}
