using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000013 RID: 19
	internal class Functions
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000067D4 File Offset: 0x000067D4
		public static string GetPCInformation()
		{
			return string.Concat(new object[]
			{
				Environment.ProcessorCount,
				"/",
				Environment.MachineName,
				"/",
				Environment.UserDomainName,
				"\\",
				Environment.UserName,
				"/",
				Environment.GetLogicalDrives().Length
			});
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006844 File Offset: 0x00006844
		public static string ReadTextFromUrl(string url)
		{
			CookieContainer cookieContainer = new CookieContainer();
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.CookieContainer = cookieContainer;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006890 File Offset: 0x00006890
		public static string ol()
		{
			int num = 45;
			string[] array = new string[45];
			double num2 = 0.0;
			Random random = new Random();
			int num3 = random.Next(0, 9);
			int num4 = random.Next(0, 9);
			int num5 = random.Next(0, 9);
			int num6 = random.Next(0, 9);
			int num7 = random.Next(0, 9);
			int num8 = random.Next(0, 9);
			int num9 = random.Next(0, 9);
			int num10 = random.Next(0, 9);
			int num11 = random.Next(0, 9);
			int num12 = random.Next(0, 9);
			int num13 = random.Next(0, 9);
			int num14 = random.Next(0, 9);
			int num15 = random.Next(0, 9);
			int num16 = random.Next(0, 9);
			int num17 = random.Next(0, 9);
			int num18 = random.Next(0, 9);
			int num19 = random.Next(0, 9);
			int num20 = random.Next(0, 9);
			int num21 = random.Next(0, 9);
			int num22 = random.Next(0, 9);
			array[0] = num3.ToString();
			array[1] = num4.ToString();
			array[2] = num5.ToString();
			array[3] = num6.ToString();
			array[8] = num7.ToString();
			array[9] = num8.ToString();
			array[10] = num9.ToString();
			array[11] = num10.ToString();
			array[21] = num11.ToString();
			array[23] = num12.ToString();
			array[25] = num13.ToString();
			array[27] = num14.ToString();
			array[29] = num15.ToString();
			array[31] = num16.ToString();
			array[33] = num17.ToString();
			array[35] = num18.ToString();
			array[37] = num19.ToString();
			array[39] = num20.ToString();
			array[41] = num21.ToString();
			array[43] = num22.ToString();
			for (int i = 0; i < num; i++)
			{
				if ((i < 0 || i > 3) && (i < 8 || i > 11) && i != 21 && i != 23 && i != 25 && i != 27 && i != 29 && i != 31 && i != 33 && i != 35 && i != 37 && i != 39 && i != 41 && i != 43)
				{
					if (i == 4)
					{
						num2 = (double)(num6 + 2);
					}
					else if (i == 5)
					{
						num2 = (double)(num6 + 3);
					}
					else if (i == 6)
					{
						num2 = (double)(num3 + 1);
					}
					else if (i == 7)
					{
						num2 = (double)(num4 + 6);
					}
					else if (i == 12)
					{
						num2 = (double)(num9 + 1);
					}
					else if (i == 13)
					{
						num2 = (double)(num9 + 9);
					}
					else if (i == 14)
					{
						num2 = (double)(num8 + 12);
					}
					else if (i == 15)
					{
						num2 = (double)(num10 + 15);
					}
					else if (i == 16)
					{
						num2 = (double)(num5 + 25);
					}
					else if (i == 17)
					{
						num2 = (double)(num7 + 31);
					}
					else if (i == 18)
					{
						num2 = (double)(num6 + num3);
					}
					else if (i == 19)
					{
						num2 = (double)(num8 + num4);
					}
					else if (i == 20)
					{
						num2 = (double)(num5 + num9);
					}
					else if (i == 22)
					{
						num2 = (double)(num11 + num8);
					}
					else if (i == 24)
					{
						num2 = (double)(num12 + num11);
					}
					else if (i == 26)
					{
						num2 = (double)(num12 + num13);
					}
					else if (i == 28)
					{
						num2 = (double)(num14 + num13);
					}
					else if (i == 30)
					{
						num2 = (double)(num15 + num14);
					}
					else if (i == 32)
					{
						num2 = (double)(num16 + num15);
					}
					else if (i == 34)
					{
						num2 = (double)(num17 + num16);
					}
					else if (i == 36)
					{
						num2 = (double)(num18 + 2);
					}
					else if (i == 38)
					{
						num2 = (double)(num19 + num18 + 7);
					}
					else if (i == 40)
					{
						num2 = (double)(num20 + num19);
					}
					else if (i == 42)
					{
						num2 = (double)(num21 + num20 + num6);
					}
					else if (i == 44)
					{
						num2 = (double)(num22 + num20);
					}
					if (num2 > 9.0)
					{
						double num23 = Math.Floor(num2 / 10.0);
						num2 -= num23 * 10.0;
					}
					array[i] = num2.ToString();
				}
			}
			string text = "";
			for (int i = 0; i < num; i++)
			{
				text += array[i];
			}
			Functions.g_cab = text;
			if (Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\vbii", true) == null)
			{
				Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\vbii");
			}
			return text;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006D2C File Offset: 0x00006D2C
		public string GenerateNumber()
		{
			Random random = new Random();
			string text = "";
			for (int i = 1; i < 20; i++)
			{
				text += random.Next(0, 9).ToString();
			}
			return text;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006D6C File Offset: 0x00006D6C
		public void ayarlariokut()
		{
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\\\SAMP", true))
				{
					if (registryKey != null)
					{
						object value = registryKey.GetValue("gta_sa_exe");
						if (value != null)
						{
							this.g_oyun = value.ToString();
						}
						else
						{
							registryKey.SetValue("gta_sa_exe", "NULL");
							registryKey.SetValue("PlayerName", "NULL");
						}
						this.g_oyun = this.g_oyun.Replace("\\gta_sa.exe", "");
						RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\gameyr", true);
						if (registryKey2 == null)
						{
							registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\gameyr");
						}
						if (registryKey2.GetValue("serial") == null)
						{
							registryKey2.SetValue("serial", this.GenerateNumber());
						}
						else
						{
							Functions.g_serial = registryKey2.GetValue("serial").ToString();
						}
						if (registryKey2.GetValue("file") == null)
						{
							registryKey2.SetValue("file", this.g_oyun);
						}
						if (registryKey2.GetValue("name") == null)
						{
							this.g_name = "Ad_Soyad";
						}
						else
						{
							this.g_name = (string)registryKey2.GetValue("name");
						}
					}
					else
					{
						Registry.CurrentUser.CreateSubKey("Software\\\\SAMP");
						this.ayarlariokut();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006EEC File Offset: 0x00006EEC
		public static void mynameis()
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion", true);
			if (registryKey != null)
			{
				if (registryKey.GetValue("WAB") == null)
				{
					registryKey.SetValue("WAB", Functions.ol());
					return;
				}
				Functions.g_cab = registryKey.GetValue("WAB").ToString();
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000024B9 File Offset: 0x000024B9
		public static int IsValidCAB()
		{
			if (Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\vbii", true) != null)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006F40 File Offset: 0x00006F40
		public void SetRegeditName(string name)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\gameyr", true);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\gameyr");
			}
			registryKey.SetValue("name", name);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000024D0 File Offset: 0x000024D0
		public static string GetRegeditSerial()
		{
			return Functions.g_serial;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006F80 File Offset: 0x00006F80
		public static string MAC()
		{
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("Select * FROM Win32_NetworkAdapterConfiguration").Get();
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				object obj = managementObject["MacAddress"];
				if (obj != null)
				{
					if (text == string.Empty)
					{
						text = obj.ToString();
					}
					managementObject.Dispose();
				}
			}
			text = text.Replace(":", "");
			return text;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024D7 File Offset: 0x000024D7
		public static string IPCek()
		{
			return Functions.ReadTextFromUrl(Globals.GetIPUrl);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000024E3 File Offset: 0x000024E3
		public static string GetMachineGUID()
		{
			return null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007018 File Offset: 0x00007018
		public bool UrlIsValid(string url)
		{
			try
			{
				HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
				httpWebRequest.Timeout = 5000;
				httpWebRequest.Method = "HEAD";
				int statusCode = (int)(httpWebRequest.GetResponse() as HttpWebResponse).StatusCode;
				if (statusCode >= 100 && statusCode < 400)
				{
					return true;
				}
				if (statusCode >= 500 && statusCode <= 510)
				{
					return false;
				}
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.ProtocolError)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000070A0 File Offset: 0x000070A0
		public static string CPUSeriNoCek()
		{
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("Select * FROM WIN32_Processor").Get())
			{
				result = ((ManagementObject)managementBaseObject)["ProcessorId"].ToString();
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000024E6 File Offset: 0x000024E6
		public static string GetRandomSymbols()
		{
			return Functions.GetRandomSymbols(8);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000710C File Offset: 0x0000710C
		public static string GetRandomSymbols(int count)
		{
			int index = Functions.randomSymbolsIndex;
			string result = new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", count).Select(delegate(string s)
			{
				index += Functions.random.Next(s.Length);
				if (index >= s.Length)
				{
					index -= s.Length;
				}
				return s[index];
			}).ToArray<char>());
			Functions.randomSymbolsIndex = index;
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000715C File Offset: 0x0000715C
		public static bool CheckForInternetConnection()
		{
			bool result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("http://clients3.google.com/generate_204"))
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000071C4 File Offset: 0x000071C4
		public static string GetOsName(OperatingSystem os_info)
		{
			string text = os_info.Version.Major.ToString() + "." + os_info.Version.Minor.ToString();
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 3236114161u)
			{
				if (num <= 3185781304u)
				{
					if (num != 2793341610u)
					{
						if (num == 3185781304u)
						{
							if (text == "5.2")
							{
								return "Server 2003 R2/Server 2003/XP 64-Bit Edition";
							}
						}
					}
					else if (text == "10.0")
					{
						return "10/Server 2016";
					}
				}
				else if (num != 3219336542u)
				{
					if (num == 3236114161u)
					{
						if (text == "5.1")
						{
							return "XP";
						}
					}
				}
				else if (text == "5.0")
				{
					return "2000";
				}
			}
			else if (num <= 4235161167u)
			{
				if (num != 4218383548u)
				{
					if (num == 4235161167u)
					{
						if (text == "6.0")
						{
							return "Server 2008/Vista";
						}
					}
				}
				else if (text == "6.1")
				{
					return "7/Server 2008 R2";
				}
			}
			else if (num != 4251938786u)
			{
				if (num == 4268716405u)
				{
					if (text == "6.2")
					{
						return "8/Server 2012";
					}
				}
			}
			else if (text == "6.3")
			{
				return "8.1/Server 2012 R2";
			}
			return "Unknown";
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007318 File Offset: 0x00007318
		public static string WMIC()
		{
			string result = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				try
				{
					result = managementObject.GetPropertyValue("SerialNumber").ToString();
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007398 File Offset: 0x00007398
		public static string getUUID()
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "CMD.exe",
				Arguments = "/C wmic csproduct get UUID"
			};
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			return process.StandardOutput.ReadToEnd();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00007404 File Offset: 0x00007404
		public static string getOSInfo()
		{
			OperatingSystem osversion = Environment.OSVersion;
			Version version = osversion.Version;
			string text = "";
			if (osversion.Platform == PlatformID.Win32Windows)
			{
				int minor = version.Minor;
				if (minor != 0)
				{
					if (minor != 10)
					{
						if (minor == 90)
						{
							text = "Me";
						}
					}
					else if (version.Revision.ToString() == "2222A")
					{
						text = "98SE";
					}
					else
					{
						text = "98";
					}
				}
				else
				{
					text = "95";
				}
			}
			else if (osversion.Platform == PlatformID.Win32NT)
			{
				switch (version.Major)
				{
				case 3:
					text = "NT 3.51";
					break;
				case 4:
					text = "NT 4.0";
					break;
				case 5:
					if (version.Minor == 0)
					{
						text = "2000";
					}
					else
					{
						text = "XP";
					}
					break;
				case 6:
					if (version.Minor == 0)
					{
						text = "Vista";
					}
					else if (version.Minor == 1)
					{
						text = "7";
					}
					else if (version.Minor == 2)
					{
						text = "8";
					}
					else
					{
						text = "8.1";
					}
					break;
				case 10:
					text = "10";
					break;
				}
			}
			if (text != "")
			{
				text = "Windows " + text;
				if (osversion.ServicePack != "")
				{
					text = text + " " + osversion.ServicePack;
				}
			}
			return text;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007570 File Offset: 0x00007570
		public static string HDDSeriNoCek()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_LogicalDisk").GetInstances();
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				text += Convert.ToString(managementObject["VolumeSerialNumber"]);
			}
			return text;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000075E4 File Offset: 0x000075E4
		public static string[] GetFiles(string sourceFolder, string filters, SearchOption searchOption)
		{
			return filters.Split(new char[]
			{
				'|'
			}).SelectMany((string filter) => Directory.GetFiles(sourceFolder, filter, searchOption)).ToArray<string>();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000762C File Offset: 0x0000762C
		public int hilekontrol()
		{
			Functions.<>c__DisplayClass40_0 CS$<>8__locals1 = new Functions.<>c__DisplayClass40_0();
			CS$<>8__locals1.<>4__this = this;
			string text = Registry.CurrentUser.OpenSubKey("SOFTWARE").OpenSubKey("SAMP").GetValue("gta_sa_exe").ToString();
			text = text.Replace("\\gta_sa.exe", "");
			if (!this.g_oyun.Equals(text))
			{
				Functions.GameClose();
				MessageBoxWrapper.Show("Oyun yolu açığı tespit edildiği için oyun ve client kapatılıyor!\n\nA: " + this.g_oyun + "\nB: " + text, "Rina Anti-Cheat");
			}
			Directory.GetDirectories(this.g_oyun);
			string[] files = Directory.GetFiles(this.g_oyun);
			this.cleoboyutu = 0L;
			this.toplamhile = 0;
			this.hileler = "";
			string[] array;
			if (Directory.Exists(this.g_oyun + "\\cleo"))
			{
				Directory.GetDirectories(this.g_oyun + "\\cleo");
				array = Directory.GetFiles(this.g_oyun + "\\cleo");
				for (int i = 0; i < array.Length; i++)
				{
					FileInfo fileInfo = new FileInfo(array[i]);
					new Functions();
					this.cleoboyutu += fileInfo.Length;
					long length = fileInfo.Length;
					string name = fileInfo.Name;
					string text2 = Path.GetExtension(this.g_oyun + "\\cleo\\" + name);
					text2 = text2.ToUpper(new CultureInfo("en-US", false));
					if (!text2.Contains(".TXT") && !text2.Contains(".FXT") && !text2.Contains(".DLL") && !text2.Contains(".INI") && Common.CleoControl(name, length) == 1)
					{
						this.hileler = this.hileler + name + "\n";
						this.toplamhile++;
					}
				}
				if (this.toplamhile > 0)
				{
					Functions.GameClose();
					MessageBoxWrapper.Show("İzinsiz CLEO bulundu.\n\n" + this.hileler + "\nGTA-SA'nın kurulu olduğu klasör içerisinde bulunan CLEO dosyasından bu cleoları silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
					return 1;
				}
			}
			string[] array2 = new string[]
			{
				"ANTTWEAKBAR.DLL",
				"SQLITE3.DLL",
				"DSOUND.DLL",
				"SAMPFUNCS.ASI",
				"ZMENU_HUDCOLOR.INI",
				"MOONLOADER.ASI",
				"M0D_S0BEIT_SA.INI",
				"MOD_SA.INI",
				"SPEEDO.PNG",
				"NEEDLE.PNG",
				"S0BEIT_ATHLON.INI"
			};
			array = files;
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo2 = new FileInfo(array[i]);
				string name2 = fileInfo2.Name;
				string fullName = fileInfo2.FullName;
				long length2 = fileInfo2.Length;
				if (!(name2 == "Thumbs.db") && !(name2 == "cleo.log"))
				{
					if (name2.Contains(".asi"))
					{
						long length3 = new FileInfo(this.g_oyun + "\\" + name2).Length;
						if (!Common.IsAcceptedAsi(Common.GetHash(this.g_oyun + "\\" + name2), length3))
						{
							this.hileler = this.hileler + name2 + "\n";
							this.toplamhile++;
						}
					}
					if (name2.ToUpper(new CultureInfo("en-US", false)) == "D3D9.DLL")
					{
						int num = 0;
						long length4 = new FileInfo(this.g_oyun + "\\" + name2).Length;
						using (List<Globals.DLLFile>.Enumerator enumerator = Globals.Enbs.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Globals.DLLFile dllfile = enumerator.Current;
								if (length4 == dllfile.Size && Common.GetHash(this.g_oyun + "\\" + name2) == dllfile.Hash)
								{
									num = 1;
									break;
								}
							}
							goto IL_441;
						}
						goto IL_3E1;
						IL_441:
						if (num == 0)
						{
							Functions.GameClose();
							MessageBoxWrapper.Show("İzinsiz D3D9.dll bulundu.\n\nGTA-SA'nın kurulu olduğu klasör içerisinde bulunan D3D9.dll dosyasını silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
							return 1;
						}
					}
					IL_3E1:
					for (int j = 0; j < array2.Length; j++)
					{
						if (name2.ToUpper(new CultureInfo("en-US", false)) == array2[j])
						{
							this.hileler = this.hileler + name2 + "\n";
							this.toplamhile++;
						}
					}
				}
			}
			if (Directory.Exists(this.g_oyun + "\\mod_sa"))
			{
				this.hileler += "mod_sa\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\moonloader"))
			{
				this.hileler += "moonloader\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\EliteModSa"))
			{
				this.hileler += "EliteModSa\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\Sobreit 0.3DL"))
			{
				this.hileler += "Sobreit 0.3DL\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\OverLight Custom"))
			{
				this.hileler += "OverLight Custom\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\OverLight"))
			{
				this.hileler += "OverLight\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\Sobreit"))
			{
				this.hileler += "Sobreit\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\Menyoo"))
			{
				this.hileler += "Menyoo\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\OverLight_Mod"))
			{
				this.hileler += "OverLight_Mod\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\glance_mod"))
			{
				this.hileler += "glance_mod\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\RedEclipseMod"))
			{
				this.hileler += "RedEclipseMod\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\StealingData"))
			{
				this.hileler += "StealingData\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\BlueEclipseMod"))
			{
				this.hileler += "BlueEclipseMod\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\CustomSAA2"))
			{
				this.hileler += "CustomSAA2\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\LiquidMod"))
			{
				this.hileler += "LiquidMod\n";
				this.toplamhile++;
			}
			if (Directory.Exists(this.g_oyun + "\\H3X"))
			{
				this.hileler += "H3X\n";
				this.toplamhile++;
			}
			CS$<>8__locals1.extensions = new string[]
			{
				"cs",
				"CS",
				"CT",
				"cleo",
				"CLEO",
				"ct",
				"scm",
				"SCM",
				"cm",
				"CM",
				"COL",
				"col"
			};
			if (Directory.Exists(this.g_oyun + "\\modloader"))
			{
				Functions.<>c__DisplayClass40_1 CS$<>8__locals2 = new Functions.<>c__DisplayClass40_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				(from f in Directory.GetFiles(this.g_oyun + "\\modloader", "*.*")
				where CS$<>8__locals2.CS$<>8__locals1.extensions.Contains(f.Split(new char[]
				{
					'.'
				}).Last<string>().ToLower())
				select f).ToArray<string>();
				this.izinsizmod = 0;
				CS$<>8__locals2.CS$<>8__locals1.method_0(this.g_oyun + "\\modloader", 0);
				for (int k = 0; k < 1; k++)
				{
					string[] directories = Directory.GetDirectories(this.g_oyun + "\\modloader");
					for (int l = 0; l < directories.Length; l++)
					{
						CS$<>8__locals2.CS$<>8__locals1.method_0(directories[l], 1);
					}
					if (this.izinsizmod != 0)
					{
						Functions.GameClose();
						MessageBoxWrapper.Show("Modloader içine CLEO ve COL dosyaları koyamazsınız! (Tespit edilen: " + this.izinsizmod + " adet CLEO / COL)", "Rina Anti-Cheat");
						return 1;
					}
				}
				int num2 = 0;
				string str = "";
				CS$<>8__locals2.extensions2 = new string[]
				{
					"ASI",
					"asi"
				};
				(from f in Directory.GetFiles(this.g_oyun + "\\modloader", "*.*")
				where CS$<>8__locals2.extensions2.Contains(f.Split(new char[]
				{
					'.'
				}).Last<string>().ToLower())
				select f).ToArray<string>();
				this.izinsizmod = 0;
				CS$<>8__locals2.method_0(this.g_oyun + "\\modloader", 0);
				for (int m = 0; m < 1; m++)
				{
					string[] directories2 = Directory.GetDirectories(this.g_oyun + "\\modloader");
					for (int n = 0; n < directories2.Length; n++)
					{
						CS$<>8__locals2.method_0(directories2[n], 1);
					}
					if (num2 != 0)
					{
						Functions.GameClose();
						MessageBoxWrapper.Show("İzinsiz ASI bulundu.\n\n" + str + "\nGTA-SA'nın kurulu olduğu klasör içerisinde bulunan MODLOADER dosyasından bu asileri silerek sorunu çözebilirsiniz.", "Rina Anti-Cheat");
						Application.Exit();
						return 1;
					}
				}
			}
			if (Directory.Exists(this.g_oyun + "\\scripts"))
			{
				Functions.<>c__DisplayClass40_2 CS$<>8__locals3 = new Functions.<>c__DisplayClass40_2();
				CS$<>8__locals3.scriptsasi = 0;
				CS$<>8__locals3.extensions3 = new string[]
				{
					"ASI",
					"asi"
				};
				(from f in Directory.GetFiles(this.g_oyun + "\\scripts", "*.*")
				where CS$<>8__locals3.extensions3.Contains(f.Split(new char[]
				{
					'.'
				}).Last<string>().ToLower())
				select f).ToArray<string>();
				this.izinsizmod = 0;
				CS$<>8__locals3.method_0(this.g_oyun + "\\scripts", 0);
				for (int num3 = 0; num3 < 1; num3++)
				{
					string[] directories3 = Directory.GetDirectories(this.g_oyun + "\\scripts");
					for (int num4 = 0; num4 < directories3.Length; num4++)
					{
						CS$<>8__locals3.method_0(directories3[num4], 1);
					}
					if (CS$<>8__locals3.scriptsasi != 0)
					{
						Functions.GameClose();
						MessageBoxWrapper.Show("SCRIPTS klasörü içerisine ASI koyamazsınız! (Tespit edilen: " + CS$<>8__locals3.scriptsasi + " adet ASI)", "Rina Anti-Cheat");
						return 1;
					}
				}
			}
			if (Directory.Exists(this.g_oyun + "\\modloader"))
			{
				Functions.<>c__DisplayClass40_3 CS$<>8__locals4 = new Functions.<>c__DisplayClass40_3();
				CS$<>8__locals4.extensions4 = new string[]
				{
					"DLL",
					"dll"
				};
				CS$<>8__locals4.yasakli_bulundu = 0;
				(from f in Directory.GetFiles(this.g_oyun + "\\modloader", "*.*")
				where CS$<>8__locals4.extensions4.Contains(f.Split(new char[]
				{
					'.'
				}).Last<string>().ToLower())
				select f).ToArray<string>();
				CS$<>8__locals4.method_0(this.g_oyun + "\\modloader", 0);
				for (int num5 = 0; num5 < 1; num5++)
				{
					string[] directories4 = Directory.GetDirectories(this.g_oyun + "\\modloader");
					for (int num6 = 0; num6 < directories4.Length; num6++)
					{
						CS$<>8__locals4.method_0(directories4[num6], 1);
					}
					if (CS$<>8__locals4.yasakli_bulundu != 0)
					{
						Functions.GameClose();
						MessageBoxWrapper.Show("MODLOADER klasörü içerisine yasaklı DLL (D3D9 / D3D2) koyamazsınız! (Tespit edilen: " + CS$<>8__locals4.yasakli_bulundu + " adet yasaklı DLL)", "Rina Anti-Cheat");
						return 1;
					}
				}
			}
			if (this.toplamhile > 0)
			{
				Functions.GameClose();
				MessageBoxWrapper.Show(string.Concat(new object[]
				{
					"Hile bulundu!\n\n",
					this.hileler,
					"\nToplam hile: ",
					this.toplamhile
				}), "Rina Anti-Cheat");
			}
			return this.toplamhile;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008334 File Offset: 0x00008334
		public void HileRaporla(string hileadi, string title, string dosya)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					string logHackURL = Globals.LogHackURL;
					webClient.UploadValues(logHackURL, new NameValueCollection
					{
						{
							"IP",
							Globals.IP
						},
						{
							"LoginKey",
							Globals.loginkey
						},
						{
							"Serial",
							Globals.CPU + Globals.HDD
						},
						{
							"Reg",
							Functions.GetRegeditSerial()
						},
						{
							"Name",
							Globals.LastName
						},
						{
							"Cheat",
							hileadi
						},
						{
							"Title",
							title
						},
						{
							"Process",
							dosya
						}
					});
				}
			}
			catch (Exception arg)
			{
				MessageBox.Show("Logging Error: " + arg);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008418 File Offset: 0x00008418
		public void HileBulundu(string hileadi, string title, string dosya)
		{
			this.HileRaporla(hileadi, title, dosya);
			Functions.GameClose();
			MessageBoxWrapper.Show(string.Concat(new string[]
			{
				"Bilgisayarınızda sizi diğer oyunculardan üstün tutacak ",
				dosya,
				" (",
				title,
				") adlı hile bulundu."
			}), "Rina Anti-Cheat");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000846C File Offset: 0x0000846C
		public static bool procIsRunning(string process)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName == process)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000084A0 File Offset: 0x000084A0
		public static int GameClose()
		{
			foreach (Process process in Process.GetProcesses("."))
			{
				try
				{
					if (process.MainWindowTitle.Length > 0 && (process.MainWindowTitle.Contains("GTA: San Andreas") || process.MainWindowTitle.Contains("GTA:SA:MP")))
					{
						Functions.ClientSil();
						Functions.is_d3d9 = false;
						Process.GetProcessesByName(process.MainWindowTitle.ToString());
						process.Kill();
						return 1;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			return 0;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00008548 File Offset: 0x00008548
		public static int ClientSil()
		{
			Functions.ReadTextFromUrl(string.Concat(new string[]
			{
				"http://54.36.126.214/data/se.php?serial=",
				Globals.CPU,
				Globals.HDD,
				"&loginkey=",
				Globals.loginkey,
				"&ip=",
				Globals.IP
			}));
			return 0;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000085A0 File Offset: 0x000085A0
		public static int CleoBoyutHesapla()
		{
			Functions functions = new Functions();
			long num = 0L;
			functions.ayarlariokut();
			Directory.GetDirectories(functions.g_oyun);
			Directory.GetFiles(functions.g_oyun);
			if (Directory.Exists(functions.g_oyun + "\\cleo"))
			{
				Directory.GetDirectories(functions.g_oyun + "\\cleo");
				string[] files = Directory.GetFiles(functions.g_oyun + "\\cleo");
				for (int i = 0; i < files.Length; i++)
				{
					num = new FileInfo(files[i]).Length;
				}
			}
			functions.cleoboyutu = num;
			return 1;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008644 File Offset: 0x00008644
		public void konumkontrol()
		{
			if (!Directory.Exists(this.g_oyun))
			{
				this.Klasor.Description = "GTA-SA'nın kurulu olduğu klasörü seçiniz;";
				this.Klasor.ShowDialog();
				this.g_oyun = this.Klasor.SelectedPath;
				Registry.CurrentUser.OpenSubKey("Software\\SAMP\\", true).SetValue("gta_sa_exe", this.Klasor.SelectedPath + "\\gta_sa.exe");
				this.konumkontrol();
				return;
			}
			if (!File.Exists(this.g_oyun + "/samp.exe"))
			{
				this.Klasor.Description = "SA-MP'nın kurulu olduğu klasörü seçiniz;";
				this.Klasor.ShowDialog();
				this.g_oyun = this.Klasor.SelectedPath;
				Registry.CurrentUser.OpenSubKey("Software\\SAMP\\", true).SetValue("gta_sa_exe", this.Klasor.SelectedPath + "\\gta_sa.exe");
				this.konumkontrol();
				return;
			}
			if (!File.Exists(this.g_oyun + "/gta_sa.exe"))
			{
				this.Klasor.Description = "GTA-SA'nın kurulu olduğu klasörü seçiniz;";
				this.Klasor.ShowDialog();
				this.g_oyun = this.Klasor.SelectedPath;
				Registry.CurrentUser.OpenSubKey("Software\\SAMP\\", true).SetValue("gta_sa_exe", this.Klasor.SelectedPath + "\\gta_sa.exe");
				this.konumkontrol();
			}
		}

		// Token: 0x0400004F RID: 79
		public string g_oyun;

		// Token: 0x04000050 RID: 80
		public string hileler;

		// Token: 0x04000051 RID: 81
		public string g_name;

		// Token: 0x04000052 RID: 82
		public static string g_serial;

		// Token: 0x04000053 RID: 83
		public static string g_cab;

		// Token: 0x04000054 RID: 84
		public int toplamhile;

		// Token: 0x04000055 RID: 85
		public static bool is_d3d9;

		// Token: 0x04000056 RID: 86
		public int kontrolsayisi;

		// Token: 0x04000057 RID: 87
		public long cleoboyutu;

		// Token: 0x04000058 RID: 88
		private string uzakdosyaadi;

		// Token: 0x04000059 RID: 89
		public int toplamcleo;

		// Token: 0x0400005A RID: 90
		public int izinsizmod;

		// Token: 0x0400005B RID: 91
		private FolderBrowserDialog Klasor = new FolderBrowserDialog();

		// Token: 0x0400005C RID: 92
		private static readonly Random random = new Random();

		// Token: 0x0400005D RID: 93
		private const int randomSymbolsDefaultCount = 8;

		// Token: 0x0400005E RID: 94
		private const string availableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

		// Token: 0x0400005F RID: 95
		private static int randomSymbolsIndex = 0;
	}
}
