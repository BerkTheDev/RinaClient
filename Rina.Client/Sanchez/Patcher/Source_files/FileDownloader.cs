using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000011 RID: 17
	internal class FileDownloader
	{
		// Token: 0x06000081 RID: 129 RVA: 0x000065E8 File Offset: 0x000065E8
		public static void DownloadFile()
		{
			if (Globals.OldFiles.Count <= 0)
			{
				Common.ChangeStatus("CHECKCOMPLETE", new string[0]);
				Common.EnableStart();
				return;
			}
			if (FileDownloader.curFile >= Globals.OldFiles.Count)
			{
				Common.ChangeStatus("DOWNLOADCOMPLETE", new string[0]);
				Common.EnableStart();
				Globals.indimi = 1;
				return;
			}
			Functions functions = new Functions();
			functions.ayarlariokut();
			functions.konumkontrol();
			if (Globals.OldFiles[FileDownloader.curFile].Contains("/"))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(functions.g_oyun + "\\" + Globals.OldFiles[FileDownloader.curFile]));
			}
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += FileDownloader.webClient_DownloadProgressChanged;
			webClient.DownloadFileCompleted += FileDownloader.webClient_DownloadFileCompleted;
			FileDownloader.stopWatch.Start();
			webClient.DownloadFileAsync(new Uri(Globals.ServerURL + Globals.OldFiles[FileDownloader.curFile]), functions.g_oyun + "\\" + Globals.OldFiles[FileDownloader.curFile]);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00006714 File Offset: 0x00006714
		private static void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			FileDownloader.currentBytes = FileDownloader.lastBytes + e.BytesReceived;
			Common.ChangeStatus("DOWNLOADFILE", new string[]
			{
				Globals.OldFiles[FileDownloader.curFile],
				Computer.ComputeDownloadSize((double)e.BytesReceived).ToString("0.00") + " MB ",
				Computer.ComputeDownloadSize((double)e.TotalBytesToReceive).ToString("0.00") + " MB"
			});
			Common.UpdateCompleteProgress(Computer.Compute(Globals.completeSize + FileDownloader.currentBytes));
			Common.UpdateCurrentProgress((long)e.ProgressPercentage, Computer.ComputeDownloadSpeed((double)e.BytesReceived, FileDownloader.stopWatch));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000242C File Offset: 0x0000242C
		private static void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			FileDownloader.lastBytes = FileDownloader.currentBytes;
			Common.UpdateCurrentProgress(100L, 0.0);
			FileDownloader.curFile++;
			FileDownloader.stopWatch.Reset();
			FileDownloader.DownloadFile();
		}

		// Token: 0x0400004A RID: 74
		private static int curFile;

		// Token: 0x0400004B RID: 75
		private static long lastBytes;

		// Token: 0x0400004C RID: 76
		private static long currentBytes;

		// Token: 0x0400004D RID: 77
		private static Stopwatch stopWatch = new Stopwatch();
	}
}
