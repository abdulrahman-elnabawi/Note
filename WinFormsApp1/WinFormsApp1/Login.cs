﻿using System.Data;
using WinFormsApp1.Contextt;

namespace WinFormsApp1
{
	public partial class Login : Form
	{
		Context context;
		public Login()
		{
			InitializeComponent();
			context = new Context();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var email = textBox2.Text;
			var password = textBox3.Text;

			try
			{
				var user = context.Users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
				if (user == null)
				{
					MessageBox.Show("ما تسجل يا ابن المتناكة"); return;

				}
				Program.curentUser = user;
				Program.next = new MainForm();
				this.Close();
			}

			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				return;
			}



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

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
