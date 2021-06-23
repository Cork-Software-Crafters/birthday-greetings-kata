using NUnit.Framework;
using System;
using BirthdayGreetings;

namespace BirthdayGreetingsTests
{
	[TestFixture]
	public class XDateTest
	{
		[Test]
		public void getters() {
			XDate date = new XDate("1789/01/24");
			Assert.AreEqual (24, date.getDay());
			Assert.AreEqual (1, date.getMonth());
		}

		[Test]
		public void isSameDate() {
			XDate date = new XDate("1789/01/24");
			XDate sameDay = new XDate("2001/01/24");
			XDate notSameDay = new XDate("1789/01/25");
			XDate notSameMonth = new XDate("1789/02/25");

			Assert.IsTrue (date.isSameDay(sameDay), "same");
			Assert.IsFalse (date.isSameDay(notSameDay), "not same day");
			Assert.IsFalse (date.isSameDay(notSameMonth), "not same month");
		}

		[Test]
		public void equalityTest() {
			XDate date = new XDate("2000/01/02");
			XDate same = new XDate("2000/01/02");
			XDate different = new XDate("2000/01/04");

			Assert.IsFalse (date.Equals(null));
			Assert.IsFalse (date.Equals(""));
			Assert.IsTrue (date.Equals(date));
			Assert.IsTrue (date.Equals(same));
			Assert.IsFalse (date.Equals(different));
		}

		[Test]
		public void todaysDate() {
			XDate date = new XDate();
			Assert.AreEqual (DateTime.Today.Day, date.getDay ());
			Assert.AreEqual (DateTime.Today.Month, date.getMonth ());
		}
	}
}

