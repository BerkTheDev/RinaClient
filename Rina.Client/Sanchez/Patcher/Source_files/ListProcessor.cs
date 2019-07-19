using System;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000020 RID: 32
	internal class ListProcessor
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00008DC8 File Offset: 0x00008DC8
		public static void AddFile(string File)
		{
			Globals.File item = default(Globals.File);
			item.Name = File.Split(new char[]
			{
				' '
			})[0];
			item.Hash = File.Split(new char[]
			{
				' '
			})[1];
			item.Size = Convert.ToInt64(File.Split(new char[]
			{
				' '
			})[2]);
			Globals.Files.Add(item);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00008E3C File Offset: 0x00008E3C
		public static void AddENB(string File)
		{
			Globals.DLLFile item = default(Globals.DLLFile);
			item.Name = File.Split(new char[]
			{
				'|'
			})[0];
			item.Hash = File.Split(new char[]
			{
				'|'
			})[1];
			item.Size = Convert.ToInt64(File.Split(new char[]
			{
				'|'
			})[2]);
			Globals.Enbs.Add(item);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008EB0 File Offset: 0x00008EB0
		public static void AddASI(string File)
		{
			Globals.ASIFile item = default(Globals.ASIFile);
			item.Hash = File.Split(new char[]
			{
				'|'
			})[0];
			item.Size = Convert.ToInt64(File.Split(new char[]
			{
				'|'
			})[1]);
			Globals.Asiler.Add(item);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00008F0C File Offset: 0x00008F0C
		public static void AddCleo(string File)
		{
			Globals.File item = default(Globals.File);
			item.Name = File.Split(new char[]
			{
				' '
			})[0];
			item.Hash = File.Split(new char[]
			{
				' '
			})[1];
			item.Size = Convert.ToInt64(File.Split(new char[]
			{
				' '
			})[2]);
			Globals.Cleos.Add(item);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00008F80 File Offset: 0x00008F80
		public static void AddCheat(string File)
		{
			Globals.Cheats item = default(Globals.Cheats);
			item.ProcessName = File.Split(new char[]
			{
				'|'
			})[0];
			item.TitleName = File.Split(new char[]
			{
				'|'
			})[1];
			item.Size = Convert.ToInt64(File.Split(new char[]
			{
				'|'
			})[2]);
			item.Description = File.Split(new char[]
			{
				'|'
			})[3];
			item.LastModified = File.Split(new char[]
			{
				'|'
			})[4];
			Globals.Hacks.Add(item);
		}
	}
}
