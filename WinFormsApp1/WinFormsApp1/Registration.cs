namespace WinFormsApp1
{
	public partial class Registration : Form
	{

       




        public Registration()
		{
			InitializeComponent();
		}
		

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void textBox1_TextChanged(object sender, EventArgs e)
		{
				

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Program.next = new Login();
			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Program.next = new Login();
			this.Close();
		}
	}
}
