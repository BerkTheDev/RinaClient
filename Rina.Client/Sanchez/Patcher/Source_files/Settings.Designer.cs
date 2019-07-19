namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000022 RID: 34
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00002662 File Offset: 0x00002662
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000939C File Offset: 0x0000939C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Sanchez.Patcher.Source_files.Settings));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(534, 185);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ayarlar";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label2.Location = new global::System.Drawing.Point(19, 93);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			this.label2.Click += new global::System.EventHandler(this.label2_Click_1);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(469, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(31, 27);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new global::System.Drawing.Point(81, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(382, 20);
			this.textBox1.TabIndex = 2;
			this.button1.Location = new global::System.Drawing.Point(436, 84);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(20, 46);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Oyun Yolu";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(558, 207);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Settings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rina Roleplay";
			base.Load += new global::System.EventHandler(this.Settings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000A1 RID: 161
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label label2;
	}
}
