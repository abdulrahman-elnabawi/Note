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
	public partial class ToDoPage : Form
	{
		public ToDoPage()
		{
			InitializeComponent();

			CreateCard();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CreateCard();

			//Program.next = new MainForm();	
			this.Close();


		}
		
		public void CreateCard()
		{
			Panel panel2 = new Panel();

			button2.Anchor = AnchorStyles.Left;
			Label label = new Label();
			label.BackColor = Color.Red;
			label.Anchor = AnchorStyles.Left;


			int num = panel2.Controls.Count;
			if (num >= 7)
				label.Location = new Point(50 + num * 110, 5);
			else
				label.Location = new Point(50 + num * 110, 15);

			label.Size = new Size(100, 80);

			label.Text = $"{textBox1.Text}"; // here we put the main title of note

			// Add the label to the panel's Controls collection
			panel2.Controls.Add(label);
		}

		public void textBox1_TextChanged(object sender, EventArgs e)
		{
			string text = textBox1.Text;
		}
	}
}
