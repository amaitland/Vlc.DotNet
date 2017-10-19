using System;
using System.Runtime.InteropServices;
using System.Text;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
	public sealed partial class VlcManager
	{
		public void CreateNewInstance(string[] args)
		{
			var utf8Args = new IntPtr[args?.Length ?? 0];

			try
			{
				for (var i = 0; i < utf8Args.Length; i++)
				{
					var bytes = Encoding.UTF8.GetBytes(args[i]);
					var buffer = Marshal.AllocHGlobal(bytes.Length + 1);
					Marshal.Copy(bytes, 0, buffer, bytes.Length);
					Marshal.WriteByte(buffer, bytes.Length, 0);
					utf8Args[i] = buffer;
				}

				myVlcInstance = GetInteropDelegate<CreateNewInstance>().Invoke(utf8Args.Length, utf8Args);

				myVlcInstance.ReleaseInstance = GetInteropDelegate<ReleaseInstance>();				
			}
			finally
			{
				foreach (var arg in utf8Args)
				{
					if (arg != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(arg);
					}
				}
			}
		}
	}
}
