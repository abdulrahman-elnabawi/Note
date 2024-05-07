using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations.Schema;

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
		public virtual ICollection<Note> Notes { get; set; }
		public virtual ICollection<TODO> TODOs { get; set; }

		[NotMapped]
		public Image ProfilePicture { get; set; }
	

	}
}
