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

			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var todo = new entities.TODO();
			todo.Title = textBox1.Text;

			todo.Date = DateTime.Now;
			todo.UserEmail = Program.curentUser.Email;



			Program.context.TODOs.Add(todo);
			Program.context.SaveChanges();
			MessageBox.Show("Note added successfully");
			Program.next = new MainForm();	
			this.Close();


		}
		
	
		public void textBox1_TextChanged(object sender, EventArgs e)
		{
			string text = textBox1.Text;
		}
	}
}
