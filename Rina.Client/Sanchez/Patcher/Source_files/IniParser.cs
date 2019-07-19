using System;
using System.Collections;
using System.IO;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x0200000A RID: 10
	public class IniParser
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00005C38 File Offset: 0x00005C38
		public IniParser(string iniPath)
		{
			TextReader textReader = null;
			string text = null;
			this.iniFilePath = iniPath;
			if (File.Exists(iniPath))
			{
				try
				{
					textReader = new StreamReader(iniPath);
					for (string text2 = textReader.ReadLine(); text2 != null; text2 = textReader.ReadLine())
					{
						text2 = text2.Trim().ToUpper();
						if (text2 != "")
						{
							if (text2.StartsWith("[") && text2.EndsWith("]"))
							{
								text = text2.Substring(1, text2.Length - 2);
							}
							else
							{
								string[] array = text2.Split(new char[]
								{
									'='
								}, 2);
								string value = null;
								if (text == null)
								{
									text = "ROOT";
								}
								IniParser.SectionPair sectionPair;
								sectionPair.Section = text;
								sectionPair.Key = array[0];
								if (array.Length > 1)
								{
									value = array[1];
								}
								this.keyPairs.Add(sectionPair, value);
							}
						}
					}
					return;
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					if (textReader != null)
					{
						textReader.Close();
					}
				}
			}
			throw new FileNotFoundException("Unable to locate " + iniPath);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005D60 File Offset: 0x00005D60
		public string GetSetting(string sectionName, string settingName)
		{
			IniParser.SectionPair sectionPair;
			sectionPair.Section = sectionName.ToUpper();
			sectionPair.Key = settingName.ToUpper();
			return (string)this.keyPairs[sectionPair];
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005DA0 File Offset: 0x00005DA0
		public string[] EnumSection(string sectionName)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.keyPairs.Keys)
			{
				IniParser.SectionPair sectionPair = (IniParser.SectionPair)obj;
				if (sectionPair.Section == sectionName.ToUpper())
				{
					arrayList.Add(sectionPair.Key);
				}
			}
			return (string[])arrayList.ToArray(typeof(string));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005E34 File Offset: 0x00005E34
		public void AddSetting(string sectionName, string settingName, string settingValue)
		{
			IniParser.SectionPair sectionPair;
			sectionPair.Section = sectionName.ToUpper();
			sectionPair.Key = settingName.ToUpper();
			if (this.keyPairs.ContainsKey(sectionPair))
			{
				this.keyPairs.Remove(sectionPair);
			}
			this.keyPairs.Add(sectionPair, settingValue);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002336 File Offset: 0x00002336
		public void AddSetting(string sectionName, string settingName)
		{
			this.AddSetting(sectionName, settingName, null);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005E94 File Offset: 0x00005E94
		public void DeleteSetting(string sectionName, string settingName)
		{
			IniParser.SectionPair sectionPair;
			sectionPair.Section = sectionName.ToUpper();
			sectionPair.Key = settingName.ToUpper();
			if (this.keyPairs.ContainsKey(sectionPair))
			{
				this.keyPairs.Remove(sectionPair);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005EE0 File Offset: 0x00005EE0
		public void SaveSettings(string newFilePath)
		{
			ArrayList arrayList = new ArrayList();
			string text = "";
			foreach (object obj in this.keyPairs.Keys)
			{
				IniParser.SectionPair sectionPair = (IniParser.SectionPair)obj;
				if (!arrayList.Contains(sectionPair.Section))
				{
					arrayList.Add(sectionPair.Section);
				}
			}
			foreach (object obj2 in arrayList)
			{
				string text2 = (string)obj2;
				text = text + "[" + text2 + "]\r\n";
				foreach (object obj3 in this.keyPairs.Keys)
				{
					IniParser.SectionPair sectionPair2 = (IniParser.SectionPair)obj3;
					if (sectionPair2.Section == text2)
					{
						string text3 = (string)this.keyPairs[sectionPair2];
						if (text3 != null)
						{
							text3 = "=" + text3;
						}
						text = text + sectionPair2.Key + text3 + "\r\n";
					}
				}
				text += "\r\n";
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter(newFilePath);
				streamWriter.Write(text);
				streamWriter.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002341 File Offset: 0x00002341
		public void SaveSettings()
		{
			this.SaveSettings(this.iniFilePath);
		}

		// Token: 0x0400003F RID: 63
		private Hashtable keyPairs = new Hashtable();

		// Token: 0x04000040 RID: 64
		private string iniFilePath;

		// Token: 0x0200000B RID: 11
		private struct SectionPair
		{
			// Token: 0x04000041 RID: 65
			public string Section;

			// Token: 0x04000042 RID: 66
			public string Key;
		}
	}
}
