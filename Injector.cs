using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XFORCE
{
    class Injector
    {

		// Token: 0x02000016 RID: 22
		public enum DllInjectionResult
		{
			// Token: 0x040000B4 RID: 180
			DllNotFound,
			// Token: 0x040000B5 RID: 181
			GameProcessNotFound,
			// Token: 0x040000B6 RID: 182
			InjectionFailed,
			// Token: 0x040000B7 RID: 183
			Success
		}

		// Token: 0x02000017 RID: 23
		public sealed class DllInjector
		{
			// Token: 0x060000AC RID: 172
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

			// Token: 0x060000AD RID: 173
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int CloseHandle(IntPtr hObject);

			// Token: 0x060000AE RID: 174
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

			// Token: 0x060000AF RID: 175
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetModuleHandle(string lpModuleName);

			// Token: 0x060000B0 RID: 176
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

			// Token: 0x060000B1 RID: 177
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

			// Token: 0x060000B2 RID: 178
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x000058C0 File Offset: 0x00003AC0
			public static Injector.DllInjector GetInstance
			{
				get
				{
					bool flag = Injector.DllInjector._instance == null;
					bool flag2 = flag;
					bool flag3 = flag2;
					if (flag3)
					{
						Injector.DllInjector._instance = new Injector.DllInjector();
					}
					return Injector.DllInjector._instance;
				}
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000020B0 File Offset: 0x000002B0
			private DllInjector()
			{
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x000058F4 File Offset: 0x00003AF4
			public Injector.DllInjectionResult Inject(string sProcName, string sDllPath)
			{
				bool flag = !File.Exists(sDllPath);
				bool flag2 = flag;
				bool flag3 = flag2;
				Injector.DllInjectionResult result;
				if (flag3)
				{
					result = Injector.DllInjectionResult.DllNotFound;
				}
				else
				{
					uint num = 0u;
					Process[] processes = Process.GetProcesses();
					for (int i = 0; i < processes.Length; i++)
					{
						bool flag4 = processes[i].ProcessName == sProcName;
						bool flag5 = flag4;
						bool flag6 = flag5;
						if (flag6)
						{
							num = (uint)processes[i].Id;
							break;
						}
					}
					bool flag7 = num == 0u;
					bool flag8 = flag7;
					bool flag9 = flag8;
					if (flag9)
					{
						result = Injector.DllInjectionResult.GameProcessNotFound;
					}
					else
					{
						bool flag10 = !this.bInject(num, sDllPath);
						bool flag11 = flag10;
						bool flag12 = flag11;
						if (flag12)
						{
							result = Injector.DllInjectionResult.InjectionFailed;
						}
						else
						{
							result = Injector.DllInjectionResult.Success;
						}
					}
				}
				return result;
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x000059B8 File Offset: 0x00003BB8
			private bool bInject(uint pToBeInjected, string sDllPath)
			{
				IntPtr intPtr = Injector.DllInjector.OpenProcess(1082u, 1, pToBeInjected);
				bool flag = intPtr == Injector.DllInjector.INTPTR_ZERO;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool result;
				if (flag3)
				{
					result = false;
				}
				else
				{
					IntPtr procAddress = Injector.DllInjector.GetProcAddress(Injector.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
					bool flag4 = procAddress == Injector.DllInjector.INTPTR_ZERO;
					bool flag5 = flag4;
					bool flag6 = flag5;
					if (flag6)
					{
						result = false;
					}
					else
					{
						IntPtr intPtr2 = Injector.DllInjector.VirtualAllocEx(intPtr, (IntPtr)null, (IntPtr)sDllPath.Length, 12288u, 64u);
						bool flag7 = intPtr2 == Injector.DllInjector.INTPTR_ZERO;
						bool flag8 = flag7;
						bool flag9 = flag8;
						if (flag9)
						{
							result = false;
						}
						else
						{
							byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
							bool flag10 = Injector.DllInjector.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0;
							bool flag11 = flag10;
							bool flag12 = flag11;
							if (flag12)
							{
								result = false;
							}
							else
							{
								bool flag13 = Injector.DllInjector.CreateRemoteThread(intPtr, (IntPtr)null, Injector.DllInjector.INTPTR_ZERO, procAddress, intPtr2, 0u, (IntPtr)null) == Injector.DllInjector.INTPTR_ZERO;
								bool flag14 = flag13;
								bool flag15 = flag14;
								if (flag15)
								{
									result = false;
								}
								else
								{
									Injector.DllInjector.CloseHandle(intPtr);
									result = true;
								}
							}
						}
					}
				}
				return result;
			}

			// Token: 0x040000B8 RID: 184
			private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

			// Token: 0x040000B9 RID: 185
			private static Injector.DllInjector _instance;
		}
	}
} 
