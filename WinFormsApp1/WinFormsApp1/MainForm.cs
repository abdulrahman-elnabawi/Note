using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
	public partial class MainForm : Form
	{
		// Initialize the nextId variable to 1

		public MainForm()
		{
			InitializeComponent();
		}

		public class TextBoxes
		{
			private int nextId = 0;

			public int Id { get; set; }
			public string Text { get; set; }

			public TextBoxes()
			{

				Id = nextId++; // Assign the nextId value and increment it
				Text = " ";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Program.next = new FinalPage();
			this.Close();
		}





		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			panel1.AutoScroll = true;
			panel1.VerticalScroll.Enabled = true;
			panel1.VerticalScroll.Visible = true;
			panel1.VerticalScroll.Maximum = 0;

			//panel1.AutoScrollOffset = new Point(0, 0);

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

			Program.next = new ToDoPage();
			this.Close();
		}

		public void panel2_Paint(object sender, EventArgs e)
		{
			Panel panel2 = new Panel();
			panel2.AutoScroll = true;
			panel2.VerticalScroll.Enabled = true;
			panel2.VerticalScroll.Visible = true;
			panel2.VerticalScroll.Maximum = 0;
		}
		public void  AddLabel(string s)
		{
			var bll=new Label();
			bll.Text = s;
			this.panel2.Controls.Add(bll);
		}
		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
