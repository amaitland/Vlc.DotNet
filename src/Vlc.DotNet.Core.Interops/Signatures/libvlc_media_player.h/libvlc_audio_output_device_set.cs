﻿using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    ///  Set audio output device. Changes are only effective after stop and play.
    /// </summary>
    [LibVlcFunction("libvlc_audio_output_device_set")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetAudioOutputDevice(VlcMediaPlayerHandle mediaPlayerInstance, IntPtr audioOutputName, IntPtr deviceName);
}
