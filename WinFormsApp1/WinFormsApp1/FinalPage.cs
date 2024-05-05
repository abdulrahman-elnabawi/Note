using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class FinalPage : Form
	{

		public FinalPage()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			//label1.AutoScrollOffset = new Point(0, 0);
		}

		private void button1_Click(object sender, EventArgs e)
		{

			//Program.next = new MainForm();
			//this.Close();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			var fontDialog = new FontDialog();
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Font = fontDialog.Font;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			richTextBox1.RightToLeft = RightToLeft.No;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			richTextBox1.RightToLeft = RightToLeft.Yes;

		}

		private void button5_Click(object sender, EventArgs e)
		{
			var colorDialog = new ColorDialog();	
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.ForeColor = colorDialog.Color;
			}
		}
	}
}
