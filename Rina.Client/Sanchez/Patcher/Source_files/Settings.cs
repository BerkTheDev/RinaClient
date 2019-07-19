using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000022 RID: 34
	public partial class Settings : Form
	{
		// Token: 0x060000CF RID: 207 RVA: 0x000025FE File Offset: 0x000025FE
		public Settings()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000090F0 File Offset: 0x000090F0
		private void Settings_Load(object sender, EventArgs e)
		{
			this.Functions.ayarlariokut();
			this.textBox1.Text = this.Functions.g_oyun;
			this.geciciyol = this.Functions.g_oyun;
			this.label2.Text = string.Concat(new string[]
			{
				"HWID:",
				Globals.CPU,
				"\nIP:",
				Globals.IP,
				"MAC:",
				Globals.MAC,
				"\nEXT:",
				Globals.HDD,
				"\nWMIC: ",
				Functions.WMIC()
			});
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002622 File Offset: 0x00002622
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Klasor.Description = "GTA-SA / SA-MP'nın kurulu olduğu klasörü seçiniz;";
			this.Klasor.ShowDialog();
			this.geciciyol = this.Klasor.SelectedPath;
			this.textBox1.Text = this.geciciyol;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00009198 File Offset: 0x00009198
		private void button1_Click(object sender, EventArgs e)
		{
			new StringBuilder();
			int num = 1;
			foreach (Process process in Process.GetProcesses("."))
			{
				try
				{
					if (process.MainWindowTitle.Length > 0)
					{
						if (process.MainWindowTitle.Contains("GTA: San Andreas") || process.MainWindowTitle.Contains("GTA:SA:MP"))
						{
							Process.GetProcessesByName(process.MainWindowTitle.ToString());
							MessageBox.Show("Bu işlemi yapabilmek için ilk önce oyunu kapatmalısınız.", "İşlem gerçekleştirilemedi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return;
						}
						num++;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			if (!File.Exists(this.geciciyol + "/samp.exe") || !File.Exists(this.geciciyol + "/gta_sa.exe"))
			{
				MessageBox.Show("Seçilen klasörde SA-MP veya GTA:SA yok.");
				return;
			}
			if (this.Functions.g_oyun == this.geciciyol)
			{
				base.Hide();
				MessageBox.Show("Herhangi bir ayar yapmadınız.");
				return;
			}
			string g_oyun = this.Functions.g_oyun;
			this.Functions.g_oyun = this.Klasor.SelectedPath;
			if (this.Functions.hilekontrol() > 0)
			{
				MessageBox.Show("Seçtiğiniz oyun yolunda hile bulunduğu için kaydedilemedi.");
				this.Functions.g_oyun = g_oyun;
				return;
			}
			Registry.CurrentUser.OpenSubKey("Software\\SAMP\\", true).SetValue("gta_sa_exe", this.Klasor.SelectedPath);
			MessageBox.Show("Oyun yolunu başarıyla değiştirdiniz, clienti tekrar çalıştırmanız gerekmektedir.");
			Application.Exit();
			base.Hide();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000211D File Offset: 0x0000211D
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000933C File Offset: 0x0000933C
		private void label2_Click_1(object sender, EventArgs e)
		{
			Clipboard.SetText(string.Concat(new string[]
			{
				Globals.CPU,
				Globals.HDD,
				" - ",
				Globals.MAC,
				" - ",
				Globals.IP
			}));
			MessageBox.Show("Client bilgileriniz panoya kopyalandı.", "Kopyalandı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0400009E RID: 158
		private string geciciyol;

		// Token: 0x0400009F RID: 159
		private FolderBrowserDialog Klasor = new FolderBrowserDialog();

		// Token: 0x040000A0 RID: 160
		private Functions Functions = new Functions();
	}
}
