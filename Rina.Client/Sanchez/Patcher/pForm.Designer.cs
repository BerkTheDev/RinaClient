namespace Sanchez.Patcher
{
	// Token: 0x02000004 RID: 4
	public partial class pForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000211F File Offset: 0x0000211F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028F8 File Offset: 0x000028F8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Sanchez.Patcher.pForm));
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.Status = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.completeProgress = new global::System.Windows.Forms.ProgressBar();
			this.currentProgress = new global::System.Windows.Forms.ProgressBar();
			this.completeProgressText = new global::System.Windows.Forms.Label();
			this.currentProgressText = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.statusStrip.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.statusStrip.BackColor = global::System.Drawing.SystemColors.Control;
			this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Status
			});
			this.statusStrip.Location = new global::System.Drawing.Point(0, 148);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new global::System.Drawing.Size(460, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "Status";
			this.Status.Name = "Status";
			this.Status.Size = new global::System.Drawing.Size(0, 17);
			this.completeProgress.Location = new global::System.Drawing.Point(11, 80);
			this.completeProgress.Name = "completeProgress";
			this.completeProgress.Size = new global::System.Drawing.Size(436, 21);
			this.completeProgress.TabIndex = 1;
			this.currentProgress.Location = new global::System.Drawing.Point(12, 121);
			this.currentProgress.Name = "currentProgress";
			this.currentProgress.Size = new global::System.Drawing.Size(436, 21);
			this.currentProgress.TabIndex = 2;
			this.completeProgressText.AutoSize = true;
			this.completeProgressText.Location = new global::System.Drawing.Point(8, 64);
			this.completeProgressText.Name = "completeProgressText";
			this.completeProgressText.Size = new global::System.Drawing.Size(101, 13);
			this.completeProgressText.TabIndex = 3;
			this.completeProgressText.Text = "Toplam İlerleme: 0%";
			this.currentProgressText.AutoSize = true;
			this.currentProgressText.Location = new global::System.Drawing.Point(9, 105);
			this.currentProgressText.Name = "currentProgressText";
			this.currentProgressText.Size = new global::System.Drawing.Size(163, 13);
			this.currentProgressText.TabIndex = 4;
			this.currentProgressText.Text = "Dosya İlerlemesi: 0%  |  0.00 kb/s";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(217, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(28, 34);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.Location = new global::System.Drawing.Point(103, 41);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(249, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Hoşgeldiniz, bu bir dosya yükleme aracıdır.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(460, 170);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.currentProgressText);
			base.Controls.Add(this.completeProgressText);
			base.Controls.Add(this.currentProgress);
			base.Controls.Add(this.completeProgress);
			base.Controls.Add(this.statusStrip);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(476, 209);
			this.MinimumSize = new global::System.Drawing.Size(476, 209);
			base.Name = "pForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Güncelleme";
			base.Load += new global::System.EventHandler(this.pForm_Load);
			base.Shown += new global::System.EventHandler(this.pForm_Shown);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.StatusStrip statusStrip;

		// Token: 0x0400000C RID: 12
		public global::System.Windows.Forms.ToolStripStatusLabel Status;

		// Token: 0x0400000D RID: 13
		public global::System.Windows.Forms.ProgressBar completeProgress;

		// Token: 0x0400000E RID: 14
		public global::System.Windows.Forms.ProgressBar currentProgress;

		// Token: 0x0400000F RID: 15
		public global::System.Windows.Forms.Label completeProgressText;

		// Token: 0x04000010 RID: 16
		public global::System.Windows.Forms.Label currentProgressText;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label1;
	}
}
