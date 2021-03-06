﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core
{
    public sealed class AudioOutputDescription
    {
        private VlcManager myManager;
        private VlcMediaPlayerHandle myMediaPlayerHandle;

        public string Name { get; private set; }
        public string Description { get; private set; }

        internal AudioOutputDescription(string name, string description, VlcManager manager, VlcMediaPlayerHandle mediaPlayerInstance)
        {
            Name = name;
            Description = description;
            myManager = manager;
            myMediaPlayerHandle = mediaPlayerInstance;
            Devices = new AudioOutputDevices(this, manager, myMediaPlayerHandle);
        }

        internal static List<AudioOutputDescription> GetSubOutputDescription(AudioOutputDescriptionStructure module, VlcManager manager, VlcMediaPlayerHandle mediaPlayerInstance)
        {
            var result = new List<AudioOutputDescription>();
            result.Add(new AudioOutputDescription(module.Name, module.Description, manager, mediaPlayerInstance));
            if (module.NextAudioOutputDescription != IntPtr.Zero)
            {
#if NET20 || NET35 || NET40 || NET45
                var nextModule = (AudioOutputDescriptionStructure)Marshal.PtrToStructure(module.NextAudioOutputDescription, typeof(AudioOutputDescriptionStructure));
#else
                var nextModule = Marshal.PtrToStructure<AudioOutputDescriptionStructure>(module.NextAudioOutputDescription);
#endif
                var data = GetSubOutputDescription(nextModule, manager, mediaPlayerInstance);
                result.AddRange(data);
            }
            return result;
        }

        public AudioOutputDevices Devices { get; private set; }
    }

}
