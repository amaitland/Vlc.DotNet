using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
#if NETSTANDARD1_3
using System.Linq;
#endif
using System.Reflection;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Handles;

namespace Vlc.DotNet.Core.Interops
{
	public abstract class VlcInteropsManager : IDisposable
	{
		/// <summary>
		/// Caches of the delegates that were resolved from the libvlc.
		/// These delegates are cast to the correct delegate type when a query is made
		/// </summary>
		private readonly Dictionary<string, object> myInteropDelegates = new Dictionary<string, object>();
		private VlcDllHandle myLibGccDllHandle;
		private VlcDllHandle myLibVlcDllHandle;
		private VlcDllHandle myLibVlcCoreDllHandle;

		protected VlcInteropsManager(DirectoryInfo dynamicLinkLibrariesPath)
		{
			if (!dynamicLinkLibrariesPath.Exists)
				throw new DirectoryNotFoundException();

			var libGccDllPath = Path.Combine(dynamicLinkLibrariesPath.FullName, "libgcc_s_seh-1.dll");
			if (File.Exists(libGccDllPath))
			{
				myLibGccDllHandle = new VlcDllHandle(Win32Interops.LoadLibrary(libGccDllPath), true);
				if (myLibGccDllHandle.IsInvalid)
					throw new Win32Exception(Marshal.GetLastWin32Error());
			}

			var libVlcCoreDllPath = Path.Combine(dynamicLinkLibrariesPath.FullName, "libvlccore.dll");
			if (!File.Exists(libVlcCoreDllPath))
				throw new FileNotFoundException();
			myLibVlcCoreDllHandle = new VlcDllHandle(Win32Interops.LoadLibrary(libVlcCoreDllPath), true);
			if (myLibVlcCoreDllHandle.IsInvalid)
				throw new Win32Exception(Marshal.GetLastWin32Error());

			var libVlcDllPath = Path.Combine(dynamicLinkLibrariesPath.FullName, "libvlc.dll");
			if (!File.Exists(libVlcDllPath))
				throw new FileNotFoundException();
			myLibVlcDllHandle = new VlcDllHandle(Win32Interops.LoadLibrary(libVlcDllPath), true);
			if (myLibVlcDllHandle.IsInvalid)
				throw new Win32Exception(Marshal.GetLastWin32Error());
		}

		internal T GetInteropDelegate<T>()
		{
			string vlcFunctionName = null;
			try
			{
#if NETSTANDARD1_3
				var attrs = typeof(T).GetTypeInfo().GetCustomAttributes(typeof(LibVlcFunctionAttribute), false).ToArray();
#else
				var attrs = typeof(T).GetCustomAttributes(typeof(LibVlcFunctionAttribute), false);
#endif
				if (attrs.Length == 0)
					throw new Exception("Could not find the LibVlcFunctionAttribute.");
				var attr = (LibVlcFunctionAttribute)attrs[0];
				vlcFunctionName = attr.FunctionName;
				if (myInteropDelegates.ContainsKey(vlcFunctionName))
				{
					return (T) myInteropDelegates[attr.FunctionName];
				}

				var procAddress = Win32Interops.GetProcAddress(myLibVlcDllHandle, attr.FunctionName);
				if (procAddress == IntPtr.Zero)
					throw new Win32Exception();

				object delegateForFunctionPointer;
#if NET20||NET35||NET40||NET45
				delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
#else
				// The GetDelegateForFunctionPointer with two parameters is now deprecated.
				delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer<T>(procAddress);
#endif
				myInteropDelegates[attr.FunctionName] = delegateForFunctionPointer;
				return (T)delegateForFunctionPointer;
			}
			catch (Win32Exception e)
			{
				throw new MissingMethodException(string.Format("The address of the function '{0}' does not exist in libvlc library.", vlcFunctionName), e);
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (myLibVlcDllHandle != null)
				{
					myLibVlcDllHandle.Dispose();
					myLibVlcDllHandle = null;
				}
				if (myLibVlcCoreDllHandle != null)
				{
					myLibVlcCoreDllHandle.Dispose();
					myLibVlcCoreDllHandle = null;
				}
				if (myLibGccDllHandle != null)
				{
					myLibGccDllHandle.Dispose();
					myLibGccDllHandle = null;
				}
			}
		}

		~VlcInteropsManager()
		{
			Dispose(false);
		}
	}
}
