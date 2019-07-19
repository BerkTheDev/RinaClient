using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Sanchez.Patcher.Source_files;

namespace Sanchez.Patcher
{
	// Token: 0x02000005 RID: 5
	public partial class Client : Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002DD8 File Offset: 0x00002DD8
		public Client()
		{
			Globals.Client = this;
			this.InitializeComponent();
			this.BackColor = Color.White;
			base.TransparencyKey = Color.White;
			this.settings.Parent = this.pictureBox1;
			this.settings.BackColor = Color.Transparent;
			this.minimize.Parent = this.pictureBox1;
			this.minimize.BackColor = Color.Transparent;
			this.pictureBox1.Parent = this;
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox2.Parent = this.pictureBox1;
			this.pictureBox2.BackColor = Color.Transparent;
			this.pictureBox3.Parent = this.pictureBox1;
			this.pictureBox3.BackColor = Color.Transparent;
			this.pictureBox4.Parent = this.pictureBox1;
			this.pictureBox4.BackColor = Color.Transparent;
			this.pictureBox6.Parent = this.pictureBox1;
			this.pictureBox6.BackColor = Color.Transparent;
			this.pictureBox7.Parent = this.pictureBox1;
			this.pictureBox7.BackColor = Color.Transparent;
			this.Durum.Parent = this.pictureBox1;
			this.Durum.BackColor = Color.Transparent;
			this.label1.Parent = this.pictureBox1;
			this.label1.BackColor = Color.Transparent;
			this.label1.Text = "Versiyon: " + Globals.CurrentVersion;
			this.label2.Parent = this.pictureBox1;
			this.label2.BackColor = Color.Transparent;
			this.label3.Parent = this.pictureBox1;
			this.label3.BackColor = Color.Transparent;
			this.label4.Parent = this.pictureBox1;
			this.label4.BackColor = Color.Transparent;
			this.label4.Text = "Hesap sayısı: " + Functions.ReadTextFromUrl("http://54.36.126.214/data/totalcharacter.php");
			this.label5.Parent = this.pictureBox1;
			this.label5.BackColor = Color.Transparent;
			this.label5.Text = "BTC Piyasası: " + Functions.ReadTextFromUrl("http://54.36.126.214/data/totalbtc.php") + " BTC";
			this.label6.Parent = this.pictureBox1;
			this.label6.BackColor = Color.Transparent;
			this.label6.Text = "Ekonomi: $" + Functions.ReadTextFromUrl("http://54.36.126.214/data/totalmoney.php");
			this.label7.Parent = this.pictureBox1;
			this.label7.BackColor = Color.Transparent;
			this.label7.Text = "Son 24 saat: " + Functions.ReadTextFromUrl("http://54.36.126.214/data/lastlogin.php") + " karakter";
			this.istatistik2.Parent = this.pictureBox1;
			this.istatistik2.BackColor = Color.Transparent;
			this.istatistik3.Parent = this.pictureBox1;
			this.istatistik3.BackColor = Color.Transparent;
			base.TransparencyKey = Color.Teal;
			this.BackColor = Color.Teal;
			Functions.mynameis();
			this.Functions.ayarlariokut();
			this.Functions.konumkontrol();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003158 File Offset: 0x00003158
		private void Client_Load(object sender, EventArgs e)
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			base.FormClosing += this.Client_FormClosing;
			base.FormClosed += this.Client_FormClosed;
			this.pictureBox1.MouseDown += this.pictureBox1_MouseDown;
			this.pictureBox1.MouseUp += this.pictureBox1_MouseUp;
			this.pictureBox1.MouseMove += this.pictureBox1_MouseMove;
			this.Durum.Text = "Client açıldı.";
			this.Durum.ForeColor = Color.White;
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += this.backgroundWorker1_DoWork;
			backgroundWorker.RunWorkerAsync();
			backgroundWorker.WorkerSupportsCancellation = true;
			this.istatistik2.Text = "Aktif oyuncu: N/a";
			this.istatistik3.Text = "Ping: N/a";
			this.textBox1.Text = this.Functions.g_name;
			Process currentProcess = Process.GetCurrentProcess();
			Process[] array = Process.GetProcessesByName(currentProcess.ProcessName).ToArray<Process>();
			if (array.Length > 1)
			{
				foreach (Process process in array)
				{
					int num = DateTime.Compare(process.StartTime, currentProcess.StartTime);
					if (num < 0)
					{
						process.Kill();
					}
					else if (num > 0)
					{
						currentProcess.Kill();
					}
				}
				MessageBoxWrapper.Show("Client zaten arkaplanda çalıştığı için kapatıldı.", "Rina Client zaten çalışıyor!");
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000213E File Offset: 0x0000213E
		private void Client_FormClosing(object sender, FormClosingEventArgs e)
		{
			Functions.ClientSil();
			base.Hide();
			new Settings().Close();
			Application.Exit();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000215B File Offset: 0x0000215B
		private void Client_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Functions.SetRegeditName(this.textBox1.Text);
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000211D File Offset: 0x0000211D
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000211D File Offset: 0x0000211D
		private void myProcess_Exited(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000217D File Offset: 0x0000217D
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			this.TogMove = 1;
			this.MValX = e.X;
			this.MValY = e.Y;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000219E File Offset: 0x0000219E
		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			this.TogMove = 0;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000032BC File Offset: 0x000032BC
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.TogMove == 1)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000021A7 File Offset: 0x000021A7
		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.facebook.com/rinaroleplay/");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021B4 File Offset: 0x000021B4
		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCpSDviNmE4YgrJbgvy3WP5Q");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021C1 File Offset: 0x000021C1
		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.rina-roleplay.net/discord");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003300 File Offset: 0x00003300
		public static long GetDirectorySize(string p)
		{
			string[] files = Directory.GetFiles(p, "*.*");
			long num = 0L;
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(array[i]);
				num += fileInfo.Length;
			}
			return num;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003344 File Offset: 0x00003344
		private void pictureBox6_Click(object sender, EventArgs e)
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
							this.Durum.ForeColor = Color.Red;
							this.Durum.Text = "GTA:SA açıkken giriş yapılamaz.";
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
			this.Durum.ForeColor = Color.Maroon;
			this.Durum.Text = "Kontroller sağlanıyor...";
			if (!Functions.CheckForInternetConnection())
			{
				this.Durum.ForeColor = Color.Red;
				this.Durum.Text = "Lütfen internet bağlantınızı kontrol edin.";
				return;
			}
			if (this.textBox1.Text == "")
			{
				this.Durum.ForeColor = Color.Red;
				this.Durum.Text = "Lütfen karakter adınızı girin.";
				return;
			}
			if (this.textBox1.Text.Length < 3)
			{
				this.Durum.ForeColor = Color.Red;
				this.Durum.Text = "Karakter adı bu kadar kısa olamaz.";
				return;
			}
			if (this.bankontrol(Globals.CPU + Globals.HDD, Globals.IP, Globals.MAC, Globals.RAM, Functions.GetRegeditSerial(), Functions.WMIC()))
			{
				this.Durum.ForeColor = Color.Red;
				this.Durum.Text = "Bilgisayarınız ve modeminiz sunucudan yasaklı olduğu için oyun başlatılamadı.";
				return;
			}
			string text = Functions.ReadTextFromUrl(Globals.VersionURL);
			if (text != Globals.CurrentVersion)
			{
				MessageBox.Show("Uyumsuz versiyon, lütfen internet sitemizden yeni client indiriniz.\n\nProgram versiyonu: " + Globals.CurrentVersion + "\nGüncel Versiyon: " + text);
				Application.Exit();
			}
			this.Durum.ForeColor = Color.Green;
			this.Durum.Text = "Giriş yapılıyor.";
			Globals.hashkontrol = 1;
			if (this.Functions.hilekontrol() > 0)
			{
				this.Durum.ForeColor = Color.Red;
				this.Durum.Text = "Hile bulundu oyun başlatılamıyor.";
				this.Functions.toplamhile = 0;
				this.Functions.hileler = "";
				return;
			}
			int num2;
			if ((num2 = this.girisekle(this.textBox1.Text, Globals.CPU + Globals.HDD, Globals.IP, Globals.RAM, Functions.GetRegeditSerial())) != 1)
			{
				if (num2 == 0)
				{
					this.Durum.Text = "Giriş yapılamadı, çok sık giriş yapamazsınız 15 saniye sonra tekrar deneyiniz.";
				}
				else if (num2 == -1)
				{
					this.Durum.Text = "Ters giden bir şeyler var. Sistem yöneticisine başvurunuz.";
				}
				this.Durum.ForeColor = Color.Red;
				return;
			}
			try
			{
				try
				{
					StreamReader streamReader = new StreamReader(new WebClient().OpenRead(Globals.ServerURL + Globals.CheatListName));
					while (!streamReader.EndOfStream)
					{
						ListProcessor.AddCheat(streamReader.ReadLine());
					}
				}
				catch (WebException ex2)
				{
					HttpStatusCode statusCode = ((HttpWebResponse)ex2.Response).StatusCode;
					MessageBox.Show("Code 2 sunucusuna bağlanılamadı. Hata sizden veya sunucudan\nkaynaklı olabilir lütfen bir yetkiliye ulaşınız.\n\n\nHata kodu: " + statusCode, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if (File.Exists(this.Functions.g_oyun + "\\enbseries.ini"))
				{
					try
					{
						string setting = new IniParser(this.Functions.g_oyun + "\\enbseries.ini").GetSetting("Proxy", "EnableProxyLibrary");
						if (setting == "1" || setting == "TRUE" || setting == "true")
						{
							MessageBoxWrapper.Show("ENBSeries.ini içerisinde bulunan EnableProxyLibrary segmenti kapalı olmalıdır. (false veya 0)", "Rina Anti-Cheat");
							return;
						}
					}
					catch (ArgumentException)
					{
						MessageBoxWrapper.Show("ENBSeries.ini çözümlenemiyor.", "Rina Anti-Cheat");
						return;
					}
					catch (Exception)
					{
					}
				}
				if (File.Exists(this.Functions.g_oyun + "\\enblocal.ini"))
				{
					try
					{
						string setting2 = new IniParser(this.Functions.g_oyun + "\\enblocal.ini").GetSetting("Proxy", "EnableProxyLibrary");
						if (setting2 == "1" || setting2 == "TRUE" || setting2 == "true")
						{
							MessageBoxWrapper.Show("ENBLocal.ini içerisinde bulunan EnableProxyLibrary segmenti kapalı olmalıdır. (false veya 0)", "Rina Anti-Cheat");
							return;
						}
					}
					catch (ArgumentException)
					{
						MessageBoxWrapper.Show("ENBLocal.ini çözümlenemiyor.", "Rina Anti-Cheat");
						return;
					}
					catch (Exception)
					{
					}
				}
				Process.Start(this.Functions.g_oyun + "\\samp.exe", Globals.ServerIP + " -nRina_" + this.loginkey);
				Globals.LastName = this.textBox1.Text;
				this.Durum.Text = "Oyun çalıştırıldı.";
				this.Functions.kontrolsayisi = 0;
				Functions.is_d3d9 = false;
				this.timer4.Start();
				this.izinsuresi = Client.GetTimestamp() + 10;
			}
			catch (Exception ex3)
			{
				this.Durum.Text = "Oyun çalıştırılamadı.";
				MessageBox.Show(ex3.Message);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021CE File Offset: 0x000021CE
		public static bool IsGameRunning(string name)
		{
			return Process.GetProcessesByName(name).FirstOrDefault((Process p) => p.MainModule.FileName.StartsWith("")) != null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003914 File Offset: 0x00003914
		public static long GetTimestampEx()
		{
			return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000021FD File Offset: 0x000021FD
		public static int GetTimestamp()
		{
			new Functions();
			return Convert.ToInt32(Functions.ReadTextFromUrl(Globals.TimeURL));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003944 File Offset: 0x00003944
		public static string RemoveSpecialCharacters(string str)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < str.Length; i++)
			{
				if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'A' && str[i] <= 'z') || str[i] == '.' || str[i] == '_')
				{
					stringBuilder.Append(str[i]);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000039C0 File Offset: 0x000039C0
		public static string Base64Decode(string sifreliMetin)
		{
			byte[] bytes = Convert.FromBase64String(sifreliMetin);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002214 File Offset: 0x00002214
		public static string ToBase64(string input)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000039E0 File Offset: 0x000039E0
		public int girisekle(string name, string serial, string ip, string extra, string regid)
		{
			string input = string.Concat(new string[]
			{
				ip,
				"|",
				serial,
				"|",
				Globals.MAC,
				"|",
				name,
				"|",
				extra,
				"|",
				regid,
				"|",
				Functions.WMIC(),
				"|",
				Functions.GetRandomSymbols(),
				"|",
				Globals.OSName,
				"|",
				Client.ToBase64(Client.ToBase64(Functions.g_cab))
			});
			string str = "";
			try
			{
				str = Client.ToBase64(Client.ToBase64(Client.ToBase64(input)));
			}
			catch (Exception arg)
			{
				MessageBox.Show("Beklenmeyen hata: " + arg);
			}
			string text = Functions.ReadTextFromUrl("http://54.36.126.214/data/corbayatuz.php?identity=" + str);
			if (text.Equals("importantfailed"))
			{
				return -1;
			}
			if (text.Equals("failed"))
			{
				return 0;
			}
			string text2 = text;
			text2 = Client.RemoveSpecialCharacters(text2);
			this.loginkey = Client.Base64Decode(Client.Base64Decode(text2));
			Globals.loginkey = this.loginkey;
			Clipboard.SetText("www.www.rina-roleplay.net ~ San Andreas Multiplayer Roleplay sunucusu!");
			this.UpKey();
			return 1;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003B38 File Offset: 0x00003B38
		public bool bankontrol(string serial, string ip, string mac, string extra, string regid, string wmic)
		{
			return Functions.ReadTextFromUrl(string.Concat(new string[]
			{
				"http://54.36.126.214/data/_r_ban.php?ip=",
				ip,
				"&serial=",
				serial,
				"&mac=",
				mac,
				"&extra=",
				extra,
				"&regid=",
				regid,
				"&wmic=",
				wmic
			})) == "﻿yes";
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003BB4 File Offset: 0x00003BB4
		private void timer1_Tick(object sender, EventArgs e)
		{
			new StringBuilder();
			int num = 1;
			foreach (Process process in Process.GetProcesses("."))
			{
				try
				{
					if (process.MainWindowTitle.Length > 0)
					{
						if (process.MainWindowTitle == "SA-MP 0.3" && Client.GetTimestamp() > this.izinsuresi)
						{
							Process.GetProcessesByName(process.MainWindowTitle.ToString());
							process.Kill();
							MessageBoxWrapper.Show("Client açıkken SA-MP çalıştırılamaz.", "Rina Anti-Cheat");
							this.izinsuresi = 0;
						}
						num++;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000211D File Offset: 0x0000211D
		private void servertimer_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003C64 File Offset: 0x00003C64
		private string GetMainModuleFilepath(int processId)
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + processId))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					ManagementObject managementObject = managementObjectCollection.Cast<ManagementObject>().FirstOrDefault<ManagementObject>();
					if (managementObject != null)
					{
						return (string)managementObject["ExecutablePath"];
					}
				}
			}
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003CE8 File Offset: 0x00003CE8
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker backgroundWorker = sender as BackgroundWorker;
			int num = 1;
			while (!backgroundWorker.CancellationPending)
			{
				Globals.hashkontrol = 0;
				if (this.Functions.hilekontrol() > 0)
				{
					this.Functions.toplamhile = 0;
					this.Functions.hileler = "";
				}
				this.sampquery.Send('p');
				int num2 = this.sampquery.Receive();
				if (num2 > 0)
				{
					string[] array = this.sampquery.Store(num2);
					int num3 = int.Parse(array[0]);
					this.sampquery.Send('i');
					num2 = this.sampquery.Receive();
					array = this.sampquery.Store(num2);
					if (num2 > 0)
					{
						this.istatistik2.Text = "Aktif oyuncu: " + array[1];
						this.istatistik3.Text = "Ping: " + num3;
					}
				}
				else
				{
					this.istatistik2.Text = "Aktif oyuncu: N/a";
					this.istatistik3.Text = "Ping: N/a";
				}
				num++;
			}
			e.Cancel = true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000211D File Offset: 0x0000211D
		public static void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002226 File Offset: 0x00002226
		private void settings_Click(object sender, EventArgs e)
		{
			new Settings().Show();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002232 File Offset: 0x00002232
		private void copyright_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Kullandığınız program, Rina Roleplay kuruluşu için @Hera tarafından kodlanmıştır.\n\nTüm hakları Rina Roleplay'a aittir.");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000211D File Offset: 0x0000211D
		private void Durum_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000211D File Offset: 0x0000211D
		private void istatistik3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003E04 File Offset: 0x00003E04
		private void pictureBox7_Click(object sender, EventArgs e)
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
							MessageBox.Show("Oyun açıkken client açık olmak zorundadır. Bu işlemi yapabilmek için ilk önce oyunu kapatmalısınız.", "İşlem gerçekleştirilemedi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			this.Durum.Text = "Client kapatılıyor...";
			this.Durum.ForeColor = Color.Red;
			base.Close();
			Application.Exit();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003EE0 File Offset: 0x00003EE0
		public static bool OyunAcikmi()
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
							return true;
						}
						num++;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			return false;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000223F File Offset: 0x0000223F
		private void UpKey()
		{
			Functions.ReadTextFromUrl(Globals.PostUpdateURL + "?LoginKey=" + Globals.loginkey);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000211D File Offset: 0x0000211D
		private void pictureBox5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003F74 File Offset: 0x00003F74
		private void button1_Click(object sender, EventArgs e)
		{
			foreach (Globals.File file in Globals.Cleos)
			{
				MessageBox.Show(file.Name);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003FCC File Offset: 0x00003FCC
		public int UnixTimeNow()
		{
			return (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000225B File Offset: 0x0000225B
		private void timer2_Tick(object sender, EventArgs e)
		{
			Globals.hashkontrol = 0;
			if (this.Functions.hilekontrol() > 0)
			{
				this.Functions.toplamhile = 0;
				this.Functions.hileler = "";
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003FFC File Offset: 0x00003FFC
		private void timer3_Tick(object sender, EventArgs e)
		{
			this.UpKey();
			new StringBuilder();
			foreach (Process process in Process.GetProcesses())
			{
				try
				{
					if (process.MainWindowTitle.Length > 0)
					{
						string mainModuleFilepath = this.GetMainModuleFilepath(process.Id);
						if (File.Exists(mainModuleFilepath))
						{
							DateTime lastWriteTime = File.GetLastWriteTime(mainModuleFilepath);
							string mainWindowTitle = process.MainWindowTitle;
							long length = new FileInfo(mainModuleFilepath).Length;
							foreach (Globals.Cheats cheats in Globals.Hacks)
							{
								if (mainWindowTitle.Contains(cheats.TitleName) || lastWriteTime.ToString() == cheats.LastModified || length == cheats.Size)
								{
									Process.GetProcessesByName(process.MainWindowTitle.ToString());
									try
									{
										process.Kill();
									}
									catch
									{
									}
									this.Functions.HileBulundu(cheats.TitleName, mainWindowTitle, process.ProcessName);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			if (!File.Exists(this.Functions.g_oyun + "/d3d9.dll") && Functions.is_d3d9)
			{
				Functions.GameClose();
				Functions.is_d3d9 = false;
				MessageBoxWrapper.Show("Oyun dosyalarında değişiklik tespit edildiği için oyun kapatıldı.", "Rina Anti-Cheat");
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000228D File Offset: 0x0000228D
		private void pictureBox5_Click_1(object sender, EventArgs e)
		{
			if (base.WindowState != FormWindowState.Minimized)
			{
				base.Hide();
				base.WindowState = FormWindowState.Minimized;
				this.notifyIcon1.Visible = true;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022B1 File Offset: 0x000022B1
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ClientiGoster();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000022B9 File Offset: 0x000022B9
		public void ClientiGoster()
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.Show();
				base.WindowState = FormWindowState.Normal;
				this.notifyIcon1.Visible = false;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004188 File Offset: 0x00004188
		private void timer4_Tick(object sender, EventArgs e)
		{
			if (Functions.is_d3d9)
			{
				this.timer4.Stop();
				return;
			}
			if (File.Exists(this.Functions.g_oyun + "\\d3d9.dll"))
			{
				Functions.is_d3d9 = true;
			}
			else
			{
				Functions.is_d3d9 = false;
			}
			if (Functions.is_d3d9)
			{
				this.Durum.Text = "Oyun çalıştırıldı. (D3D9 entegreli)";
			}
			this.Functions.kontrolsayisi++;
			if (this.Functions.kontrolsayisi < 10)
			{
				this.timer4.Start();
				return;
			}
			this.timer4.Stop();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000211D File Offset: 0x0000211D
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000211D File Offset: 0x0000211D
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000211D File Offset: 0x0000211D
		private void istatistik2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000211D File Offset: 0x0000211D
		private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000211D File Offset: 0x0000211D
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000211D File Offset: 0x0000211D
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000211D File Offset: 0x0000211D
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000211D File Offset: 0x0000211D
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000211D File Offset: 0x0000211D
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000211D File Offset: 0x0000211D
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000211D File Offset: 0x0000211D
		private void label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000013 RID: 19
		private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		// Token: 0x04000014 RID: 20
		private CookieContainer cookieContainer = new CookieContainer();

		// Token: 0x04000015 RID: 21
		private int kontrolzamani;

		// Token: 0x04000016 RID: 22
		private int TogMove;

		// Token: 0x04000017 RID: 23
		private int MValX;

		// Token: 0x04000018 RID: 24
		private int MValY;

		// Token: 0x04000019 RID: 25
		private int izinsuresi;

		// Token: 0x0400001A RID: 26
		private string loginkey;

		// Token: 0x0400001B RID: 27
		private Query sampquery = new Query(Globals.ServerIP, 7777);

		// Token: 0x0400001C RID: 28
		private Functions Functions = new Functions();
	}
}
