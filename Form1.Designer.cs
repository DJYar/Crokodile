namespace Поле
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.RedPlayer = new System.Windows.Forms.PictureBox();
			this.YellowPlayer = new System.Windows.Forms.PictureBox();
			this.GetWords = new System.Windows.Forms.Button();
			this.BluePlayer = new System.Windows.Forms.PictureBox();
			this.GreenPlayer = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.RedPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YellowPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BluePlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// RedPlayer
			// 
			this.RedPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RedPlayer.BackgroundImage")));
			this.RedPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RedPlayer.Location = new System.Drawing.Point(12, 12);
			this.RedPlayer.Name = "RedPlayer";
			this.RedPlayer.Size = new System.Drawing.Size(48, 47);
			this.RedPlayer.TabIndex = 1;
			this.RedPlayer.TabStop = false;
			// 
			// YellowPlayer
			// 
			this.YellowPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YellowPlayer.BackgroundImage")));
			this.YellowPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.YellowPlayer.Location = new System.Drawing.Point(12, 58);
			this.YellowPlayer.Name = "YellowPlayer";
			this.YellowPlayer.Size = new System.Drawing.Size(48, 47);
			this.YellowPlayer.TabIndex = 2;
			this.YellowPlayer.TabStop = false;
			// 
			// GetWords
			// 
			this.GetWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.GetWords.Location = new System.Drawing.Point(376, 482);
			this.GetWords.Name = "GetWords";
			this.GetWords.Size = new System.Drawing.Size(75, 23);
			this.GetWords.TabIndex = 3;
			this.GetWords.Text = "Слова";
			this.GetWords.UseVisualStyleBackColor = true;
			this.GetWords.Click += new System.EventHandler(this.GetWords_Click);
			// 
			// BluePlayer
			// 
			this.BluePlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BluePlayer.BackgroundImage")));
			this.BluePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BluePlayer.Location = new System.Drawing.Point(12, 104);
			this.BluePlayer.Name = "BluePlayer";
			this.BluePlayer.Size = new System.Drawing.Size(48, 47);
			this.BluePlayer.TabIndex = 4;
			this.BluePlayer.TabStop = false;
			// 
			// GreenPlayer
			// 
			this.GreenPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GreenPlayer.BackgroundImage")));
			this.GreenPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.GreenPlayer.Location = new System.Drawing.Point(12, 150);
			this.GreenPlayer.Name = "GreenPlayer";
			this.GreenPlayer.Size = new System.Drawing.Size(48, 47);
			this.GreenPlayer.TabIndex = 5;
			this.GreenPlayer.TabStop = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(376, 453);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Стоп!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(376, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Время: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(417, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(456, 517);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.GreenPlayer);
			this.Controls.Add(this.BluePlayer);
			this.Controls.Add(this.GetWords);
			this.Controls.Add(this.YellowPlayer);
			this.Controls.Add(this.RedPlayer);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.RedPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YellowPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BluePlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox RedPlayer;
		private System.Windows.Forms.PictureBox YellowPlayer;
		private System.Windows.Forms.Button GetWords;
		private System.Windows.Forms.PictureBox BluePlayer;
		private System.Windows.Forms.PictureBox GreenPlayer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

