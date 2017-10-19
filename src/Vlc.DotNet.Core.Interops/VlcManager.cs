﻿using System;
using System.Collections.Generic;
using System.IO;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager : VlcInteropsManager
    {
        private static readonly Dictionary<DirectoryInfo, VlcManager> MyAllInstance = new Dictionary<DirectoryInfo, VlcManager>();
        private VlcInstanceHandle myVlcInstance;

        public string VlcVersion => Utf8InteropStringConverter.Utf8InteropToString(GetInteropDelegate<GetVersion>().Invoke());

        public Version VlcVersionNumber
        {
            get
            {
                var versionString = this.VlcVersion;
                versionString = versionString.Split('-', ' ')[0];

                return new Version(versionString);
            }
        }

        internal VlcManager(DirectoryInfo dynamicLinkLibrariesPath)
            : base(dynamicLinkLibrariesPath)
        {
        }

        public override void Dispose(bool disposing)
        {
            if (myVlcInstance != null)
                myVlcInstance.Dispose();

            if (MyAllInstance.ContainsValue(this))
            {
                foreach (var kv in new Dictionary<DirectoryInfo, VlcManager>(MyAllInstance))
                {
                    if(kv.Value == this)
                        MyAllInstance.Remove(kv.Key);
                }
            }
            base.Dispose(disposing);
        }

        public static VlcManager GetInstance(DirectoryInfo dynamicLinkLibrariesPath)
        {
            if (!MyAllInstance.ContainsKey(dynamicLinkLibrariesPath))
                MyAllInstance[dynamicLinkLibrariesPath] = new VlcManager(dynamicLinkLibrariesPath);
            return MyAllInstance[dynamicLinkLibrariesPath];
        }

        private void EnsureVlcInstance()
        {
            if (myVlcInstance == null)
            {
                throw new InvalidOperationException("This VlcManager has not yet been initialized. Call CreateNewInstance to initialize it.");
            }
        }
    }
}