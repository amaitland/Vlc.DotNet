using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set media chapter (if applicable).
    /// </summary>
    [LibVlcFunction("libvlc_media_player_set_chapter")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetMediaChapter(VlcMediaPlayerHandle mediaPlayerInstance, int chapter);
}
