using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Navigate through DVD Menu.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_navigate")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void Navigate(VlcMediaPlayerHandle mediaPlayerInstance, NavigateModes navigate);
}
