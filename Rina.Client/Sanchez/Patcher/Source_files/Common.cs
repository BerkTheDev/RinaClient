using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Cyclic.Redundancy.Check;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x0200000C RID: 12
	internal class Common
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00006090 File Offset: 0x00006090
		public static void ChangeStatus(string Key, params string[] Arguments)
		{
			Globals.pForm.Status.Text = Texts.GetText(Key, Arguments);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000060B8 File Offset: 0x000060B8
		public static void UpdateCompleteProgress(long Value)
		{
			if (Value >= 0L && Value <= 100L)
			{
				Globals.pForm.completeProgress.Value = Convert.ToInt32(Value);
				Globals.pForm.completeProgressText.Text = Texts.GetText("COMPLETEPROGRESS", new object[]
				{
					Value
				});
				return;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000611C File Offset: 0x0000611C
		public static void UpdateCurrentProgress(long Value, double Speed)
		{
			if (Value >= 0L && Value <= 100L)
			{
				Globals.pForm.currentProgress.Value = Convert.ToInt32(Value);
				Globals.pForm.currentProgressText.Text = Texts.GetText("CURRENTPROGRESS", new object[]
				{
					Value,
					Speed.ToString("0.00")
				});
				return;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006190 File Offset: 0x00006190
		public static int IsAcceptedCleo(string Name, long Length)
		{
			foreach (Globals.File file in Globals.Cleos)
			{
				if (file.Name == Name && file.Size == Length)
				{
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000061FC File Offset: 0x000061FC
		public static bool IsAcceptedAsi(string Hash, long Length)
		{
			foreach (Globals.ASIFile asifile in Globals.Asiler)
			{
				if (asifile.Hash == Hash && asifile.Size == Length)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00006268 File Offset: 0x00006268
		public static int IsAcceptedCleoSize(int Size)
		{
			using (List<Globals.File>.Enumerator enumerator = Globals.Cleos.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Size == (long)Size)
					{
						return 1;
					}
				}
			}
			return 0;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000062C8 File Offset: 0x000062C8
		public static int IsAcceptedHash(string Name, string Hash)
		{
			foreach (Globals.File file in Globals.Cleos)
			{
				if (file.Name == Name && Hash != file.Hash)
				{
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006338 File Offset: 0x00006338
		public static int CleoControl(string Name, long Length)
		{
			Functions functions = new Functions();
			functions.ayarlariokut();
			if (Globals.hashkontrol == 0)
			{
				if (Common.IsAcceptedCleo(Name, Length) != 1)
				{
					return 1;
				}
				return 0;
			}
			else
			{
				if (Globals.hashkontrol != 1)
				{
					return 1;
				}
				if (Common.IsAcceptedHash(Name, Common.GetHash(functions.g_oyun + "\\cleo\\" + Name)) != 0)
				{
					return 1;
				}
				if (Common.IsAcceptedCleo(Name, Length) != 1)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000063A0 File Offset: 0x000063A0
		public static string GetHash(string Name)
		{
			if (Name == string.Empty)
			{
				return string.Empty;
			}
			CRC crc = new CRC();
			string text = string.Empty;
			using (FileStream fileStream = File.Open(Name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				foreach (byte b in crc.ComputeHash(fileStream))
				{
					text += b.ToString("x2").ToLower();
				}
			}
			return text;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000234F File Offset: 0x0000234F
		public static void EnableStart()
		{
			Globals.pForm.Hide();
			new Client().Show();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002365 File Offset: 0x00002365
		public static bool IsGameRunning()
		{
			return Process.GetProcessesByName(Globals.BinaryName).FirstOrDefault((Process p) => p.MainModule.FileName.StartsWith("")) != null;
		}

		// Token: 0x04000043 RID: 67
		private Functions Functions = new Functions();
	}
}
