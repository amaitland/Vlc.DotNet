using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get media chapter (if applicable).
    /// </summary>
    [LibVlcFunction("libvlc_media_player_get_chapter")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetMediaChapter(VlcMediaPlayerHandle mediaPlayerInstance);
}
