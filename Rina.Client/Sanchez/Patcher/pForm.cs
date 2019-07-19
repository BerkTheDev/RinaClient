using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sanchez.Patcher.Source_files;

namespace Sanchez.Patcher
{
	// Token: 0x02000004 RID: 4
	public partial class pForm : Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000027DC File Offset: 0x000027DC
		public pForm()
		{
			this.InitializeComponent();
			Globals.pForm = this;
			int id = Process.GetCurrentProcess().Id;
			new StringBuilder();
			foreach (Process process in Process.GetProcesses("."))
			{
				try
				{
					if (process.MainWindowTitle.Length > 0 && process.Id != id && process.MainWindowTitle == "Rina Roleplay")
					{
						process.Kill();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002884 File Offset: 0x00002884
		private void pForm_Shown(object sender, EventArgs e)
		{
			Functions functions = new Functions();
			functions.ayarlariokut();
			functions.konumkontrol();
			if (!Functions.CheckForInternetConnection())
			{
				MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz, internete bağlanılamadı!");
				Application.Exit();
			}
			string text = Functions.ReadTextFromUrl(Globals.VersionURL);
			if (text != Globals.CurrentVersion)
			{
				MessageBox.Show("Uyumsuz versiyon, lütfen internet sitemizden yeni client indiriniz.\n\nProgram versiyonu: " + Globals.CurrentVersion + "\nGüncel Versiyon: " + text);
				Application.Exit();
			}
			Networking.CheckNetwork();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002101 File Offset: 0x00002101
		private void Start_Click(object sender, EventArgs e)
		{
			new pForm().Close();
			new Client().Show();
			base.Hide();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000211D File Offset: 0x0000211D
		private void pForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000009 RID: 9
		private Functions Functions = new Functions();
	}
}
