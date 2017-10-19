﻿using System;
using System.Collections.Generic;
using System.IO;
using Vlc.DotNet.Core.Interops;
using Vlc.DotNet.Core.Interops.Handles;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core
{
	public sealed partial class VlcMedia : IDisposable
	{
		private readonly VlcMediaPlayer myVlcMediaPlayer;

		internal static Dictionary<VlcMediaPlayer, List<VlcMedia>> LoadedMedias { get; private set; }

		static VlcMedia()
		{
			LoadedMedias = new Dictionary<VlcMediaPlayer, List<VlcMedia>>();
		}

		internal VlcMedia(VlcMediaPlayer player, FileInfo file, params string[] options)
#if NET20
			: this(player, VlcMediaInstanceExtensions.AddOptionToMedia(player.Manager.CreateNewMediaFromPath(file.FullName), player.Manager, options))
#else
			: this(player, player.Manager.CreateNewMediaFromPath(file.FullName).AddOptionToMedia(player.Manager, options))
#endif
		{
		}

		internal VlcMedia(VlcMediaPlayer player, Uri uri, params string[] options)
#if NET20
			: this(player, VlcMediaInstanceExtensions.AddOptionToMedia(player.Manager.CreateNewMediaFromLocation(uri.AbsoluteUri), player.Manager, options))
#else
			: this(player, player.Manager.CreateNewMediaFromLocation(uri.AbsoluteUri).AddOptionToMedia(player.Manager, options))
#endif
		{
		}
		
		internal VlcMedia(VlcMediaPlayer player, string mrl, params string[] options)
#if NET20
			: this(player, VlcMediaInstanceExtensions.AddOptionToMedia(player.Manager.CreateNewMediaFromLocation(mrl), player.Manager, options))
#else
			: this(player, player.Manager.CreateNewMediaFromLocation(mrl).AddOptionToMedia(player.Manager, options))
#endif
		{
		}

		internal VlcMedia(VlcMediaPlayer player, Stream stream, params string[] options)
#if NET20
			: this(player, VlcMediaInstanceExtensions.AddOptionToMedia(player.Manager.CreateNewMediaFromStream(stream), player.Manager, options))
#else
			: this(player, player.Manager.CreateNewMediaFromStream(stream).AddOptionToMedia(player.Manager, options))
#endif
		{
		}

		internal VlcMedia(VlcMediaPlayer player, VlcMediaHandle mediaInstance)
		{
			if(!LoadedMedias.ContainsKey(player))
				LoadedMedias[player] = new List<VlcMedia>();
			LoadedMedias[player].Add(this);
			MediaInstance = mediaInstance;
			myVlcMediaPlayer = player;
			RegisterEvents();
		}

		internal VlcMediaHandle MediaInstance { get; private set; }

		public string Mrl
		{
			get { return myVlcMediaPlayer.Manager.GetMediaMrl(MediaInstance); }
		}

		public MediaStates State
		{
			get { return myVlcMediaPlayer.Manager.GetMediaState(MediaInstance); }
		}

		public TimeSpan Duration
		{
			get { return new TimeSpan(myVlcMediaPlayer.Manager.GetMediaDuration(MediaInstance) * 10000); }
		}

		public void Dispose()
		{
			Dispose(true);
		}

		private void Dispose(bool disposing)
		{
			if (!MediaInstance.IsInvalid)
			{
				UnregisterEvents();
				MediaInstance.Dispose();
			}
			GC.SuppressFinalize(this);
		}

		~VlcMedia()
		{
			Dispose(false);
		}

		public VlcMedia Clone()
		{
			var cloned = myVlcMediaPlayer.Manager.CloneMedia(MediaInstance);
			if (cloned.IsInvalid)
				return null;
			return new VlcMedia(myVlcMediaPlayer, cloned);
		}

		public MediaStatsStructure Statistics
		{
			get { return myVlcMediaPlayer.Manager.GetMediaStats(MediaInstance); }
		}

		public MediaTrackInfosStructure[] TracksInformations
		{
			get { return myVlcMediaPlayer.Manager.GetMediaTracksInformations(MediaInstance); }
		}

		private void RegisterEvents()
		{
			var eventManager = myVlcMediaPlayer.Manager.GetMediaEventManager(MediaInstance);
			//myVlcMediaPlayer.Manager.AttachEvent(eventManager, EventTypes.MediaDurationChanged, myOnMediaDurationChangedInternalEventCallback = OnMediaDurationChangedInternal);
			myVlcMediaPlayer.Manager.AttachEvent(eventManager, EventTypes.MediaFreed, myOnMediaFreedInternalEventCallback = OnMediaFreedInternal);
			myVlcMediaPlayer.Manager.AttachEvent(eventManager, EventTypes.MediaMetaChanged, myOnMediaMetaChangedInternalEventCallback = OnMediaMetaChangedInternal);
			myVlcMediaPlayer.Manager.AttachEvent(eventManager, EventTypes.MediaParsedChanged, myOnMediaParsedChangedInternalEventCallback = OnMediaParsedChangedInternal);
			myVlcMediaPlayer.Manager.AttachEvent(eventManager, EventTypes.MediaStateChanged, myOnMediaStateChangedInternalEventCallback = OnMediaStateChangedInternal);
			myVlcMediaPlayer.Manager.AttachEvent(eventManager, EventTypes.MediaSubItemAdded, myOnMediaSubItemAddedInternalEventCallback = OnMediaSubItemAddedInternal);
			myVlcMediaPlayer.Manager.AttachEvent(eventManager, EventTypes.MediaSubItemTreeAdded, myOnMediaSubItemTreeAddedInternalEventCallback = OnMediaSubItemTreeAddedInternal);
			eventManager.Dispose();
		}

		private void UnregisterEvents()
		{
			var eventManager = myVlcMediaPlayer.Manager.GetMediaEventManager(MediaInstance);
			//myVlcMediaPlayer.Manager.DetachEvent(eventManager, EventTypes.MediaDurationChanged, myOnMediaDurationChangedInternalEventCallback);
			myVlcMediaPlayer.Manager.DetachEvent(eventManager, EventTypes.MediaFreed, myOnMediaFreedInternalEventCallback);
			myVlcMediaPlayer.Manager.DetachEvent(eventManager, EventTypes.MediaMetaChanged, myOnMediaMetaChangedInternalEventCallback);
			myVlcMediaPlayer.Manager.DetachEvent(eventManager, EventTypes.MediaParsedChanged, myOnMediaParsedChangedInternalEventCallback);
			myVlcMediaPlayer.Manager.DetachEvent(eventManager, EventTypes.MediaStateChanged, myOnMediaStateChangedInternalEventCallback);
			myVlcMediaPlayer.Manager.DetachEvent(eventManager, EventTypes.MediaSubItemAdded, myOnMediaSubItemAddedInternalEventCallback);
			myVlcMediaPlayer.Manager.DetachEvent(eventManager, EventTypes.MediaSubItemTreeAdded, myOnMediaSubItemTreeAddedInternalEventCallback);
			eventManager.Dispose();
		}
	}
}