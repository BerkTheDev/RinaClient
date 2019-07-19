using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000021 RID: 33
	internal class Networking
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00009028 File Offset: 0x00009028
		public static void CheckNetwork()
		{
			Common.ChangeStatus("CONNECTING", new string[0]);
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += Networking.backgroundWorker_DoWork;
			backgroundWorker.RunWorkerCompleted += Networking.backgroundWorker_RunWorkerCompleted;
			if (backgroundWorker.IsBusy)
			{
				MessageBox.Show(Texts.GetText("UNKNOWNERROR", new object[]
				{
					"CheckNetwork isBusy"
				}));
				Application.Exit();
				return;
			}
			backgroundWorker.RunWorkerAsync();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000090A4 File Offset: 0x000090A4
		private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				new WebClient().OpenRead(Globals.ServerURL);
				e.Result = true;
			}
			catch
			{
				e.Result = false;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000025CE File Offset: 0x000025CE
		private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!Convert.ToBoolean(e.Result))
			{
				MessageBox.Show(Texts.GetText("NONETWORK", new object[0]));
				Application.Exit();
				return;
			}
			ListDownloader.DownloadList();
		}
	}
}
