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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{

			Program.next = new MainForm();
			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Program.next = new Registration();
		}
	}
}
