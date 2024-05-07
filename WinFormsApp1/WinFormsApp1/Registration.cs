using WinFormsApp1.Contextt;
using WinFormsApp1.entities;

namespace WinFormsApp1
{
	public partial class Registration : Form
	{
		public Context context;

		public Registration()
		{
			InitializeComponent();
			context = new Context();
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1 == null)
			{
				MessageBox.Show("Please fill all fields");
				return;
			}
		
				
				
			

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			User user = new User();
			user.Name = textBox1.Text;
			user.Email = textBox2.Text;
			user.Password = textBox3.Text;
			try
			{
				context.Users.Add(user);

				context.SaveChanges();
				Program.next = new Login();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			

			
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Program.next = new Login();
			this.Close();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if(textBox2 == null)
			{

				MessageBox.Show("Please fill all fields");
				return;

			}
			else
			{
				
			}
		}
	}
}
