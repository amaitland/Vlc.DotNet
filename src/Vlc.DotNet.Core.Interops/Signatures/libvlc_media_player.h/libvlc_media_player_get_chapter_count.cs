using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get media chapter count.
    /// </summary>
    [LibVlcFunction("libvlc_media_player_get_chapter_count")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int GetMediaChapterCount(VlcMediaPlayerHandle mediaPlayerInstance);
}
