using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Create and initialize a libvlc instance.
    /// </summary>
    /// <returns>Return the libvlc instance or NULL in case of error.</returns>
    [LibVlcFunction("libvlc_new")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate VlcInstanceHandle CreateNewInstance(int argc, IntPtr[] argv);
}
