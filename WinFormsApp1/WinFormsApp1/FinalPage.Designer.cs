namespace WinFormsApp1
{
	partial class FinalPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalPage));
			button1 = new Button();
			panel2 = new Panel();
			label1 = new Label();
			textBox1 = new TextBox();
			button7 = new Button();
			button6 = new Button();
			button5 = new Button();
			button2 = new Button();
			richTextBox1 = new RichTextBox();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.BackgroundImageLayout = ImageLayout.Zoom;
			button1.Location = new Point(726, 3);
			button1.Name = "button1";
			button1.Size = new Size(62, 50);
			button1.TabIndex = 4;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkGray;
			panel2.Controls.Add(label1);
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(button7);
			panel2.Controls.Add(button6);
			panel2.Controls.Add(button5);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(button1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(800, 56);
			panel2.TabIndex = 5;
			panel2.Paint += panel2_Paint;
			// 
			// label1
			// 
			label1.Location = new Point(355, 3);
			label1.Name = "label1";
			label1.Size = new Size(105, 23);
			label1.TabIndex = 12;
			label1.Text = "Main Title";
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.InactiveBorder;
			textBox1.Location = new Point(301, 26);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(172, 27);
			textBox1.TabIndex = 11;
			// 
			// button7
			// 
			button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
			button7.BackgroundImageLayout = ImageLayout.Zoom;
			button7.Location = new Point(545, 3);
			button7.Name = "button7";
			button7.Size = new Size(60, 50);
			button7.TabIndex = 10;
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button6
			// 
			button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
			button6.BackgroundImageLayout = ImageLayout.Zoom;
			button6.Location = new Point(479, 3);
			button6.Name = "button6";
			button6.Size = new Size(60, 50);
			button6.TabIndex = 9;
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// button5
			// 
			button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
			button5.BackgroundImageLayout = ImageLayout.Zoom;
			button5.Location = new Point(235, 3);
			button5.Name = "button5";
			button5.Size = new Size(60, 50);
			button5.TabIndex = 8;
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button2
			// 
			button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
			button2.BackgroundImageLayout = ImageLayout.Zoom;
			button2.Location = new Point(169, 3);
			button2.Name = "button2";
			button2.Size = new Size(60, 50);
			button2.TabIndex = 5;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.BackColor = Color.FromArgb(224, 224, 224);
			richTextBox1.Dock = DockStyle.Fill;
			richTextBox1.Location = new Point(0, 56);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(800, 461);
			richTextBox1.TabIndex = 6;
			richTextBox1.Text = "";
			// 
			// FinalPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(800, 517);
			Controls.Add(richTextBox1);
			Controls.Add(panel2);
			Name = "FinalPage";
			Text = "FinalPage";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Button button1;
		private Panel panel2;
		private Button button5;
		private Button button2;
		private Button button7;
		private Button button6;
		private RichTextBox richTextBox1;
		private TextBox textBox1;
		private Label label1;
	}
}