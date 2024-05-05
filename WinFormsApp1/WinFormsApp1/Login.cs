using Microsoft.VisualBasic.ApplicationServices;
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
			if (textBox2.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("Please fill all fields");
				return;
			}
			using (Contextt.Context context = new Contextt.Context())
			{
				var user = context.Users.Where(u => u.Email == textBox2.Text && u.Password == textBox3.Text).FirstOrDefault();
				if (user == null)
				{
					MessageBox.Show("Invalid username or password");
					return;
				}
				
			}
			Program.next = new Registration();

			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Program.next = new Registration();
			this.Close();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
