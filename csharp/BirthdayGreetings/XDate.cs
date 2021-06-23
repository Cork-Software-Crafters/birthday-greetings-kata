using System;


namespace BirthdayGreetings
{
	public class XDate
	{
		int day;
		int month;

		public XDate()
		{
			var today = DateTime.Today;
			day = today.Day;
			month = today.Month;
		}
			
		public XDate(String yyyyMMdd) 
		{
			day = int.Parse(yyyyMMdd.Substring (8));
			month = int.Parse (yyyyMMdd.Substring (5, 2));
		}

		public int getDay() 
		{
			return day;
		}

		public int getMonth() 
		{
			return month;
		}

		public bool isSameDay(XDate anotherDate) 
		{
			return anotherDate.getDay() == this.getDay() && anotherDate.getMonth() == this.getMonth();
		}

		public override int GetHashCode ()
		{
			return day;
		}

		public override bool Equals(Object obj)
		{
			XDate other = obj as XDate;
			if (other == null)
				return false;

			return this.day == other.day && this.month == other.month;
		}

		public override string ToString ()
		{
			return string.Format ("{0}/{1}", day, month);
		}
	}
}

