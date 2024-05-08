namespace WinFormsApp1
{
	partial class Login
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
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			button5 = new Button();
			linkLabel1 = new LinkLabel();
			label5 = new Label();
			SuspendLayout();
			// 
			// textBox3
			// 
			textBox3.Location = new Point(330, 201);
			textBox3.Name = "textBox3";
			textBox3.PasswordChar = '*';
			textBox3.Size = new Size(213, 23);
			textBox3.TabIndex = 15;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(330, 116);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(213, 23);
			textBox2.TabIndex = 14;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// label3
			// 
			label3.Location = new Point(156, 204);
			label3.Name = "label3";
			label3.Size = new Size(119, 23);
			label3.TabIndex = 13;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.Location = new Point(156, 119);
			label2.Name = "label2";
			label2.Size = new Size(119, 23);
			label2.TabIndex = 12;
			label2.Text = "Email";
			// 
			// button5
			// 
			button5.Location = new Point(342, 275);
			button5.Name = "button5";
			button5.Size = new Size(184, 55);
			button5.TabIndex = 16;
			button5.Text = "Submit";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(472, 365);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(44, 15);
			linkLabel1.TabIndex = 18;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Signup";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// label5
			// 
			label5.Location = new Point(372, 365);
			label5.Name = "label5";
			label5.Size = new Size(119, 23);
			label5.TabIndex = 17;
			label5.Text = "Create an Account";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveBorder;
			ClientSize = new Size(800, 450);
			Controls.Add(linkLabel1);
			Controls.Add(label5);
			Controls.Add(button5);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label3);
			Controls.Add(label2);
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox3;
		private TextBox textBox2;
		private Label label3;
		private Label label2;
		private Button button5;
		private LinkLabel linkLabel1;
		private Label label5;
	}
}