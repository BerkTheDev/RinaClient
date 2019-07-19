using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x0200001F RID: 31
	internal class ListDownloader
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00008C30 File Offset: 0x00008C30
		public static void DownloadList()
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			Common.ChangeStatus("LISTDOWNLOAD", new string[0]);
			backgroundWorker.DoWork += ListDownloader.backgroundWorker_DoWork;
			backgroundWorker.RunWorkerCompleted += ListDownloader.backgroundWorker_RunWorkerCompleted;
			if (backgroundWorker.IsBusy)
			{
				MessageBox.Show(Texts.GetText("UNKNOWNERROR", new object[]
				{
					"DownloadList isBusy"
				}));
				Application.Exit();
				return;
			}
			backgroundWorker.RunWorkerAsync();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008CAC File Offset: 0x00008CAC
		private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				WebClient webClient = new WebClient();
				StreamReader streamReader = new StreamReader(webClient.OpenRead(Globals.ServerURL + Globals.PatchlistName));
				while (!streamReader.EndOfStream)
				{
					ListProcessor.AddFile(streamReader.ReadLine());
				}
				streamReader = new StreamReader(webClient.OpenRead(Globals.ServerURL + Globals.CleoName));
				while (!streamReader.EndOfStream)
				{
					ListProcessor.AddCleo(streamReader.ReadLine());
				}
				streamReader = new StreamReader(webClient.OpenRead(Globals.ServerURL + Globals.EnbName));
				while (!streamReader.EndOfStream)
				{
					ListProcessor.AddENB(streamReader.ReadLine());
				}
				streamReader = new StreamReader(webClient.OpenRead(Globals.ServerURL + Globals.AsiName));
				while (!streamReader.EndOfStream)
				{
					ListProcessor.AddASI(streamReader.ReadLine());
				}
			}
			catch (WebException ex)
			{
				HttpStatusCode statusCode = ((HttpWebResponse)ex.Response).StatusCode;
				MessageBox.Show("İndirme sunucusuna bağlanılamadı. Hata sizden veya sunucudan\nkaynaklı olabilir lütfen bir yetkiliye ulaşınız.\n\n\nHata kodu: " + statusCode, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000025C7 File Offset: 0x000025C7
		private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			FileChecker.CheckFiles();
		}
	}
}
