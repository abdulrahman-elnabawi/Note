using WinFormsApp1.Contextt;
using WinFormsApp1.entities;

namespace WinFormsApp1
{
	public static class Program
	{
		public static Form cur=null, next=null;
		public static Context context = new Context();
		public static User curentUser;
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			cur= new Login();
			while(cur!=null)
			{
				Application.Run(cur);
				cur=next;
				next=null;
			}
		}
	}
}