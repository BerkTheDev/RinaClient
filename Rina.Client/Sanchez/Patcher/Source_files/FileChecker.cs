using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x0200000F RID: 15
	internal class FileChecker
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00006454 File Offset: 0x00006454
		public static void CheckFiles()
		{
			FileChecker.backgroundWorker.WorkerReportsProgress = true;
			FileChecker.backgroundWorker.DoWork += FileChecker.backgroundWorker_DoWork;
			FileChecker.backgroundWorker.ProgressChanged += FileChecker.backgroundWorker_ProgressChanged;
			FileChecker.backgroundWorker.RunWorkerCompleted += FileChecker.backgroundWorker_RunWorkerCompleted;
			if (FileChecker.backgroundWorker.IsBusy)
			{
				MessageBox.Show(Texts.GetText("UNKNOWNERROR", new object[]
				{
					"CheckFiles isBusy"
				}));
				Application.Exit();
				return;
			}
			FileChecker.backgroundWorker.RunWorkerAsync();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000064E8 File Offset: 0x000064E8
		private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			Functions functions = new Functions();
			functions.ayarlariokut();
			functions.konumkontrol();
			foreach (Globals.File file in Globals.Files)
			{
				Globals.fullSize += file.Size;
				FileChecker.backgroundWorker.ReportProgress(0, Path.GetFileName(file.Name));
				if (File.Exists(functions.g_oyun + "\\" + file.Name) && !(Common.GetHash(functions.g_oyun + "\\" + file.Name) != file.Hash))
				{
					Globals.completeSize += file.Size;
					FileChecker.backgroundWorker.ReportProgress(1);
				}
				else
				{
					Globals.OldFiles.Add(file.Name);
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000023E1 File Offset: 0x000023E1
		private static void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (e.ProgressPercentage == 0)
			{
				Common.ChangeStatus("CHECKFILE", new string[]
				{
					e.UserState.ToString()
				});
				return;
			}
			Common.UpdateCompleteProgress(Computer.Compute(Globals.completeSize));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002419 File Offset: 0x00002419
		private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			FileDownloader.DownloadFile();
		}

		// Token: 0x04000046 RID: 70
		private static BackgroundWorker backgroundWorker = new BackgroundWorker();

		// Token: 0x02000010 RID: 16
		private enum State
		{
			// Token: 0x04000048 RID: 72
			REPORT_NAME,
			// Token: 0x04000049 RID: 73
			REPORT_PROGRESS
		}
	}
}
