using System;

namespace BirthdayGreetings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var service = new BirthdayService ();
			service.SendGreetings("../../employee_data.txt", new XDate(), "localhost", 25);
		}
	}
}
