using Microsoft.EntityFrameworkCore.Infrastructure;
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
using WinFormsApp1.Contextt;
using WinFormsApp1.entities;

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
			//	button1.Anchor = AnchorStyles.Left;
			//	CreateCard("dsd");
			//Program.next = new FinalPage();

			FinalPage finalPage = new FinalPage();
			Program.next = finalPage;
			this.Close();
		}

		public void CreateCard(string title)
		{
			Label label = new Label();
			label.BackColor = Color.Red;
			label.Anchor = AnchorStyles.Left;


			int num = panel1.Controls.Count;
			if (num >= 7)
				label.Location = new Point(50 + num * 110, 5);
			else
				label.Location = new Point(50 + num * 110, 15);

			label.Size = new Size(100, 80);

			label.Text = title; // here we put the main title of note


			panel1.Controls.Add(label);

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
		public void AddLabel(string s)
		{
			var bll = new Label();
			bll.Text = s;
			this.panel2.Controls.Add(bll);
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			var notes = Program.context.Notes.Where(e=>e.User.Email==Program.curentUser.Email).ToList();
			foreach (var note in notes)
			{
				CreateCard(note.Title);
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Program.next = new Profile();
			this.Close();

		}

		
	}
}
