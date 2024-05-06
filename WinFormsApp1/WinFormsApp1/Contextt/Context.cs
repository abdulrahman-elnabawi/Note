using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Contextt
{
	public class Context :DbContext
	{
		override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=3bdo;Initial Catalog=ToDoApp;Integrated Security=True;TrustServerCertificate=True");
		}
		public DbSet<entities.User> Users { get; set; }
		public DbSet<entities.Note> Notes { get; set; }



	}
}
