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

			button1.Anchor = AnchorStyles.Left;
			Label label = new Label();
			label.BackColor = Color.Red;
			label.Anchor = AnchorStyles.Left;


			////int num = panel1.Controls.Count;
			//if (num >= 7)
			//	label.Location = new Point(50 + num * 110, 5);
			//else
			//	label.Location = new Point(50 + num * 110, 15);

			//label.Size = new Size(100, 80);

			//label.Text = "Label " + 1; // here we put the main title of note

			// Add the label to the panel's Controls collection
			//panel1.Controls.Add(label);


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
