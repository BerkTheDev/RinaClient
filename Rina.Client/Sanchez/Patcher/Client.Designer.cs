namespace Sanchez.Patcher
{
	// Token: 0x02000005 RID: 5
	public partial class Client : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000022DD File Offset: 0x000022DD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004224 File Offset: 0x00004224
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Sanchez.Patcher.Client));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Durum = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.istatistik2 = new global::System.Windows.Forms.Label();
			this.istatistik3 = new global::System.Windows.Forms.Label();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.settings = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox6 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox7 = new global::System.Windows.Forms.PictureBox();
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.timer3 = new global::System.Windows.Forms.Timer(this.components);
			this.minimize = new global::System.Windows.Forms.PictureBox();
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.timer4 = new global::System.Windows.Forms.Timer(this.components);
			this.label5 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.settings).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.minimize).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.BackColor = global::System.Drawing.SystemColors.ControlText;
			this.pictureBox1.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.ErrorImage");
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(-3, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(902, 445);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.Durum.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.Durum.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.Durum.ForeColor = global::System.Drawing.Color.Black;
			this.Durum.Location = new global::System.Drawing.Point(362, 414);
			this.Durum.Name = "Durum";
			this.Durum.Size = new global::System.Drawing.Size(487, 22);
			this.Durum.TabIndex = 2;
			this.Durum.Text = "Fonksiyonlar kontrol ediliyor...";
			this.Durum.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Durum.Click += new global::System.EventHandler(this.Durum_Click);
			this.textBox1.BackColor = global::System.Drawing.Color.White;
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new global::System.Drawing.Point(598, 337);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(165, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(516, 341);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(77, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Karakter Adı";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.istatistik2.AutoSize = true;
			this.istatistik2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.istatistik2.ForeColor = global::System.Drawing.Color.Gray;
			this.istatistik2.Location = new global::System.Drawing.Point(700, 271);
			this.istatistik2.Name = "istatistik2";
			this.istatistik2.Size = new global::System.Drawing.Size(13, 13);
			this.istatistik2.TabIndex = 9;
			this.istatistik2.Text = "\"";
			this.istatistik2.Click += new global::System.EventHandler(this.istatistik2_Click);
			this.istatistik3.AutoSize = true;
			this.istatistik3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.istatistik3.ForeColor = global::System.Drawing.Color.Gray;
			this.istatistik3.Location = new global::System.Drawing.Point(700, 248);
			this.istatistik3.Name = "istatistik3";
			this.istatistik3.Size = new global::System.Drawing.Size(14, 13);
			this.istatistik3.TabIndex = 10;
			this.istatistik3.Text = "3";
			this.istatistik3.Click += new global::System.EventHandler(this.istatistik3_Click);
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
			this.settings.BackColor = global::System.Drawing.Color.Transparent;
			this.settings.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("settings.BackgroundImage");
			this.settings.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("settings.ErrorImage");
			this.settings.Location = new global::System.Drawing.Point(785, 24);
			this.settings.Name = "settings";
			this.settings.Size = new global::System.Drawing.Size(32, 32);
			this.settings.TabIndex = 13;
			this.settings.TabStop = false;
			this.settings.Click += new global::System.EventHandler(this.settings_Click);
			this.pictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage");
			this.pictureBox2.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.ErrorImage");
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new global::System.Drawing.Point(85, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(27, 27);
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click_1);
			this.pictureBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.BackgroundImage");
			this.pictureBox3.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.ErrorImage");
			this.pictureBox3.Location = new global::System.Drawing.Point(20, 27);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(27, 27);
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new global::System.EventHandler(this.pictureBox3_Click_1);
			this.pictureBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox4.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.BackgroundImage");
			this.pictureBox4.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.ErrorImage");
			this.pictureBox4.Location = new global::System.Drawing.Point(53, 27);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(27, 27);
			this.pictureBox4.TabIndex = 16;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new global::System.EventHandler(this.pictureBox4_Click_1);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.ForeColor = global::System.Drawing.Color.Gray;
			this.label1.Location = new global::System.Drawing.Point(17, 420);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(21, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "v2";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.pictureBox6.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox6.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox6.BackgroundImage");
			this.pictureBox6.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox6.ErrorImage");
			this.pictureBox6.Location = new global::System.Drawing.Point(769, 337);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new global::System.Drawing.Size(60, 20);
			this.pictureBox6.TabIndex = 19;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new global::System.EventHandler(this.pictureBox6_Click);
			this.pictureBox7.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox7.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox7.BackgroundImage");
			this.pictureBox7.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox7.ErrorImage");
			this.pictureBox7.Location = new global::System.Drawing.Point(814, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new global::System.Drawing.Size(34, 32);
			this.pictureBox7.TabIndex = 20;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Click += new global::System.EventHandler(this.pictureBox7_Click);
			this.timer2.Enabled = true;
			this.timer2.Interval = 1000;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(577, 371);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(252, 12);
			this.label3.TabIndex = 21;
			this.label3.Text = "(Türkçe isim, ünlü isim, mizah-i isimler yasaktır!)";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label4.ForeColor = global::System.Drawing.Color.Gray;
			this.label4.Location = new global::System.Drawing.Point(541, 248);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(99, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Toplam karakter";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label6.ForeColor = global::System.Drawing.Color.Gray;
			this.label6.Location = new global::System.Drawing.Point(541, 271);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(77, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "Toplam para";
			this.label6.Click += new global::System.EventHandler(this.label6_Click);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label7.ForeColor = global::System.Drawing.Color.Gray;
			this.label7.Location = new global::System.Drawing.Point(367, 248);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(108, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "Bugün giriş yapan";
			this.label7.Click += new global::System.EventHandler(this.label7_Click);
			this.timer3.Enabled = true;
			this.timer3.Interval = 30000;
			this.timer3.Tick += new global::System.EventHandler(this.timer3_Tick);
			this.minimize.BackColor = global::System.Drawing.Color.Transparent;
			this.minimize.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("minimize.BackgroundImage");
			this.minimize.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("minimize.ErrorImage");
			this.minimize.Location = new global::System.Drawing.Point(753, 24);
			this.minimize.Name = "minimize";
			this.minimize.Size = new global::System.Drawing.Size(32, 32);
			this.minimize.TabIndex = 26;
			this.minimize.TabStop = false;
			this.minimize.Click += new global::System.EventHandler(this.pictureBox5_Click_1);
			this.notifyIcon1.BalloonTipText = "Rina Roleplay";
			this.notifyIcon1.BalloonTipTitle = "Rina Roleplay";
			this.notifyIcon1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("notifyIcon1.Icon");
			this.notifyIcon1.Text = "Rina Roleplay";
			this.notifyIcon1.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			this.timer4.Interval = 350;
			this.timer4.Tick += new global::System.EventHandler(this.timer4_Tick);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label5.ForeColor = global::System.Drawing.Color.Gray;
			this.label5.Location = new global::System.Drawing.Point(367, 271);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(108, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "Bugün giriş yapan";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(871, 444);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.minimize);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.pictureBox7);
			base.Controls.Add(this.pictureBox6);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.settings);
			base.Controls.Add(this.istatistik3);
			base.Controls.Add(this.istatistik2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.Durum);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Client";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rina Roleplay";
			base.Load += new global::System.EventHandler(this.Client_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.settings).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.minimize).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001D RID: 29
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label Durum;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label istatistik2;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label istatistik3;

		// Token: 0x04000025 RID: 37
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.PictureBox settings;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.PictureBox pictureBox6;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.PictureBox pictureBox7;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Timer timer3;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.PictureBox minimize;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Timer timer4;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label5;
	}
}
