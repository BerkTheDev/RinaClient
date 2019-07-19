using System;
using System.Windows.Forms;

namespace Sanchez.Patcher
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00005BF0 File Offset: 0x00005BF0
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				Application.Run(new pForm());
			}
			catch (Exception arg)
			{
				MessageBox.Show("Beklenmeyen hata: " + arg);
			}
		}
	}
}
