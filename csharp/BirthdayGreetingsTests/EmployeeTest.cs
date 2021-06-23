using NUnit.Framework;
using System;
using BirthdayGreetings;

namespace BirthdayGreetingsTests
{
	[TestFixture ()]
	public class EmployeeTest
	{
		[Test ()]
		public void testBirthday() 
		{
			Employee employee = new Employee("foo", "bar", "1990/01/31", "a@b.c");
			Assert.IsFalse(employee.isBirthday(new XDate("2008/01/30")), "not his birthday");
			Assert.IsTrue(employee.isBirthday(new XDate("2008/01/31")), "his birthday");
		}

		[Test ()]
		public void equality() 
		{
			Employee employee = new Employee("First", "Last", "1999/09/01", "first@last.com");
			Employee same = new Employee("First", "Last", "1999/09/01", "first@last.com");
			Employee differentEmail = new Employee("First", "Last", "1999/09/01", "boom@boom.com");

			Assert.AreNotEqual (employee, null);
			Assert.AreNotEqual (employee, "a string");
			Assert.AreEqual (employee, employee);
			Assert.AreEqual (employee, same);
			Assert.AreNotEqual (employee, differentEmail);
		}


	}
}

