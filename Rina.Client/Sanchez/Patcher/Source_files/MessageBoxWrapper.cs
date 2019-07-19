using System;
using System.Windows.Forms;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000012 RID: 18
	public class MessageBoxWrapper
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002476 File Offset: 0x00002476
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000247D File Offset: 0x0000247D
		public static bool IsOpen { get; set; }

		// Token: 0x06000088 RID: 136 RVA: 0x00002485 File Offset: 0x00002485
		public static void Show(string messageBoxText, string caption)
		{
			if (!MessageBoxWrapper.IsOpen)
			{
				Globals.Client.ClientiGoster();
				Globals.Client.BringToFront();
				MessageBoxWrapper.IsOpen = true;
				MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				MessageBoxWrapper.IsOpen = false;
			}
		}
	}
}
