using System;
using System.Collections.Generic;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x0200001A RID: 26
	internal class Globals
	{
		// Token: 0x0400006B RID: 107
		public static string OSName = Functions.getOSInfo();

		// Token: 0x0400006C RID: 108
		public static string ServerURL = "http://54.36.126.214/data/";

		// Token: 0x0400006D RID: 109
		public static string PatchlistName = "patchlist.txt";

		// Token: 0x0400006E RID: 110
		public static string CheatListName = "cheatlist.txt";

		// Token: 0x0400006F RID: 111
		public static string CleoName = "cleos.txt";

		// Token: 0x04000070 RID: 112
		public static string EnbName = "d3d9.txt";

		// Token: 0x04000071 RID: 113
		public static string AsiName = "asi.txt";

		// Token: 0x04000072 RID: 114
		public static string BinaryName = "samp.bin";

		// Token: 0x04000073 RID: 115
		public static int suspend_time = 0;

		// Token: 0x04000074 RID: 116
		public static int hashkontrol = 0;

		// Token: 0x04000075 RID: 117
		public static string loginkey = "";

		// Token: 0x04000076 RID: 118
		public static string LastName = "";

		// Token: 0x04000077 RID: 119
		public static string GetIPUrl = "http://54.36.126.214/data/getip.php";

		// Token: 0x04000078 RID: 120
		public static string CPU = Functions.CPUSeriNoCek();

		// Token: 0x04000079 RID: 121
		public static string MAC = Functions.MAC();

		// Token: 0x0400007A RID: 122
		public static string IP = Functions.IPCek();

		// Token: 0x0400007B RID: 123
		public static string RAM = Functions.GetPCInformation();

		// Token: 0x0400007C RID: 124
		public static string HDD = Functions.HDDSeriNoCek();

		// Token: 0x0400007D RID: 125
		public static string ServerIP = Functions.ReadTextFromUrl("http://54.36.126.214/data/serverip.txt");

		// Token: 0x0400007E RID: 126
		public static string NewsURL = "http://54.36.126.214/data/news.html";

		// Token: 0x0400007F RID: 127
		public static string VersionURL = "http://54.36.126.214/data/version.php";

		// Token: 0x04000080 RID: 128
		public static string LogHackURL = "http://54.36.126.214/data/loghack.php";

		// Token: 0x04000081 RID: 129
		public static string TimeURL = "http://54.36.126.214/data/timestamp.php";

		// Token: 0x04000082 RID: 130
		public static string PostUpdateURL = "http://54.36.126.214/data/pupdate.php";

		// Token: 0x04000083 RID: 131
		public static string CurrentVersion = "EIS 2.1";

		// Token: 0x04000084 RID: 132
		public static string MARY = Functions.GetMachineGUID();

		// Token: 0x04000085 RID: 133
		public static pForm pForm;

		// Token: 0x04000086 RID: 134
		public static Client Client;

		// Token: 0x04000087 RID: 135
		public static List<Globals.File> Files = new List<Globals.File>();

		// Token: 0x04000088 RID: 136
		public static List<Globals.File> Cleos = new List<Globals.File>();

		// Token: 0x04000089 RID: 137
		public static List<Globals.DLLFile> Enbs = new List<Globals.DLLFile>();

		// Token: 0x0400008A RID: 138
		public static List<Globals.ASIFile> Asiler = new List<Globals.ASIFile>();

		// Token: 0x0400008B RID: 139
		public static List<Globals.Cheats> Hacks = new List<Globals.Cheats>();

		// Token: 0x0400008C RID: 140
		public static List<string> OldFiles = new List<string>();

		// Token: 0x0400008D RID: 141
		public static long fullSize;

		// Token: 0x0400008E RID: 142
		public static long completeSize;

		// Token: 0x0400008F RID: 143
		public static int indimi;

		// Token: 0x04000090 RID: 144
		public static int GameStarted = 0;

		// Token: 0x0200001B RID: 27
		public struct File
		{
			// Token: 0x04000091 RID: 145
			public string Name;

			// Token: 0x04000092 RID: 146
			public string Hash;

			// Token: 0x04000093 RID: 147
			public long Size;
		}

		// Token: 0x0200001C RID: 28
		public struct DLLFile
		{
			// Token: 0x04000094 RID: 148
			public string Name;

			// Token: 0x04000095 RID: 149
			public string Hash;

			// Token: 0x04000096 RID: 150
			public long Size;
		}

		// Token: 0x0200001D RID: 29
		public struct ASIFile
		{
			// Token: 0x04000097 RID: 151
			public string Hash;

			// Token: 0x04000098 RID: 152
			public long Size;
		}

		// Token: 0x0200001E RID: 30
		public struct Cheats
		{
			// Token: 0x04000099 RID: 153
			public string ProcessName;

			// Token: 0x0400009A RID: 154
			public string TitleName;

			// Token: 0x0400009B RID: 155
			public long Size;

			// Token: 0x0400009C RID: 156
			public string Description;

			// Token: 0x0400009D RID: 157
			public string LastModified;
		}
	}
}
