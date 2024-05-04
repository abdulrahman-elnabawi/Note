namespace WinFormsApp1
{
	partial class Registration
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button5 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			label5 = new Label();
			linkLabel1 = new LinkLabel();
			SuspendLayout();
			// 
			// button5
			// 
			button5.Location = new Point(560, 178);
			button5.Name = "button5";
			button5.Size = new Size(184, 55);
			button5.TabIndex = 4;
			button5.Text = "Submet";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// label1
			// 
			label1.Location = new Point(75, 87);
			label1.Name = "label1";
			label1.Size = new Size(119, 23);
			label1.TabIndex = 5;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.Location = new Point(75, 171);
			label2.Name = "label2";
			label2.Size = new Size(119, 23);
			label2.TabIndex = 6;
			label2.Text = "Email";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.Location = new Point(75, 256);
			label3.Name = "label3";
			label3.Size = new Size(119, 23);
			label3.TabIndex = 7;
			label3.Text = "Password";
			// 
			// label4
			// 
			label4.Location = new Point(75, 345);
			label4.Name = "label4";
			label4.Size = new Size(119, 23);
			label4.TabIndex = 8;
			label4.Text = "Confirm Passwor";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(249, 84);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(213, 23);
			textBox1.TabIndex = 9;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(249, 168);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(213, 23);
			textBox2.TabIndex = 10;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(249, 253);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(213, 23);
			textBox3.TabIndex = 11;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(249, 345);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(213, 23);
			textBox4.TabIndex = 12;
			// 
			// label5
			// 
			label5.Location = new Point(560, 281);
			label5.Name = "label5";
			label5.Size = new Size(119, 23);
			label5.TabIndex = 13;
			label5.Text = "Have an Account?";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(660, 281);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(37, 15);
			linkLabel1.TabIndex = 14;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Login";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// Registration
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(linkLabel1);
			Controls.Add(label5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button5);
			Name = "Registration";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button5;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Label label5;
		private LinkLabel linkLabel1;
	}
}
