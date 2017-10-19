using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Parse a media meta data and tracks information async. 
    /// </summary>
    [LibVlcFunction("libvlc_media_parse_async")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void ParseMediaAsync(VlcMediaHandle mediaInstance);
}
