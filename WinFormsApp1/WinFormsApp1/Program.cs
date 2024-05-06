namespace WinFormsApp1
{
	public static class Program
	{
		public static Form cur=null, next=null;
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			cur= new FinalPage();
			while(cur!=null)
			{
				Application.Run(cur);
				cur=next;
				next=null;
			}
		}
	}
}