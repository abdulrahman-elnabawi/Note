using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.entities
{
	public class User
	{
		[Required]
		public string Name { get; set; }
		[Key,EmailAddress]
		public string Email { get; set; }
		[Required,PasswordPropertyText]
		public string Password { get; set; }
		public virtual List<Note> Notes { get; set; }

	}
}
