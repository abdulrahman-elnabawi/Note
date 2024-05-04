using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Context
{
	public class Context :DbContext
	{
		override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ToDoApp;Integrated Security=True");
		}
		public DbSet<ToDoPage> ToDos { get; set; }
		public DbSet<FinalPage> Notes { get; set; }
		public DbSet<MainForm> MainForms { get; set; }
		public DbSet<Login> Logins { get; set; }
		public DbSet<Registration> Registrations { get; set; }



	}
}
