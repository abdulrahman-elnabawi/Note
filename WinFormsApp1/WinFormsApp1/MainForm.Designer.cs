namespace WinFormsApp1
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			button1 = new Button();
			panel1 = new Panel();
			label1 = new Label();
			panel2 = new Panel();
			button2 = new Button();
			label2 = new Label();
			label3 = new Label();
			button3 = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Right;
			button1.Location = new Point(20, 28);
			button1.Name = "button1";
			button1.Size = new Size(120, 50);
			button1.TabIndex = 0;
			button1.Text = "Add New Note ->";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(button1);
			panel1.Location = new Point(0, 57);
			panel1.Name = "panel1";
			panel1.Size = new Size(799, 104);
			panel1.TabIndex = 1;
			panel1.Paint += panel1_Paint;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(303, 183);
			label1.Name = "label1";
			label1.Size = new Size(218, 84);
			label1.TabIndex = 2;
			label1.Text = "TO DO";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Controls.Add(button2);
			panel2.Location = new Point(0, 270);
			panel2.Name = "panel2";
			panel2.Size = new Size(799, 104);
			panel2.TabIndex = 2;
			panel2.Paint += panel2_Paint;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Right;
			button2.Location = new Point(20, 33);
			button2.Name = "button2";
			button2.Size = new Size(120, 50);
			button2.TabIndex = 0;
			button2.Text = "Add New To Do ->";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(221, 168);
			label2.Name = "label2";
			label2.Size = new Size(382, 15);
			label2.TabIndex = 3;
			label2.Text = "___________________________________________________________________________";
			// 
			// label3
			// 
			label3.Location = new Point(258, 245);
			label3.Name = "label3";
			label3.Size = new Size(302, 22);
			label3.TabIndex = 4;
			label3.Text = "___________________________________________________________________________";
			label3.Click += label3_Click;
			// 
			// button3
			// 
			button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
			button3.BackgroundImageLayout = ImageLayout.Zoom;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Location = new Point(704, 12);
			button3.Name = "button3";
			button3.Size = new Size(75, 39);
			button3.TabIndex = 5;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gray;
			ClientSize = new Size(800, 450);
			Controls.Add(button3);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(panel2);
			Controls.Add(label1);
			Controls.Add(panel1);
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private Button button2;
		private Label label2;
		private Label label3;
		private Button button3;
	}
}