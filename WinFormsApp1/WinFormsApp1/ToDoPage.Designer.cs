﻿namespace WinFormsApp1
{
	partial class ToDoPage
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
			label1 = new Label();
			textBox1 = new TextBox();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(302, 50);
			label1.Name = "label1";
			label1.Size = new Size(198, 37);
			label1.TabIndex = 0;
			label1.Text = "Add Task To Do";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(277, 114);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(258, 59);
			textBox1.TabIndex = 1;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button2.Location = new Point(357, 215);
			button2.Name = "button2";
			button2.Size = new Size(107, 59);
			button2.TabIndex = 3;
			button2.Text = "Save";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// ToDoPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "ToDoPage";
			Text = "ToDoPage";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button button2;
	}
}