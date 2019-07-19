using System;
using System.Diagnostics;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x0200000E RID: 14
	internal class Computer
	{
		// Token: 0x06000077 RID: 119 RVA: 0x000023B7 File Offset: 0x000023B7
		public static long Compute(long Size)
		{
			return Size * 100L / Globals.fullSize;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000023CA File Offset: 0x000023CA
		public static double ComputeDownloadSize(double Size)
		{
			return Size / 1024.0 / 1024.0;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000642C File Offset: 0x0000642C
		public static double ComputeDownloadSpeed(double Size, Stopwatch stopWatch)
		{
			return Size / 1024.0 / stopWatch.Elapsed.TotalSeconds;
		}
	}
}
