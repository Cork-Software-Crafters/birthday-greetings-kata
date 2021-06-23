using System;

namespace BirthdayGreetings
{
	public class Employee
	{
		private XDate birthDate;
		private String lastName;
		private String firstName;
		private String email;

		public Employee (String firstName, String lastName, String birthDate, String email) 
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.birthDate = new XDate(birthDate);
			this.email = email;
		}

		public bool isBirthday(XDate today) {
			return today.isSameDay(birthDate);
		}

		public String getEmail() {
			return email;
		}

		public String getFirstName() {
			return firstName;
		}

		public override bool Equals (object obj)
		{
			Employee other = obj as Employee;
			if (other == null)
				return false;
			return this.birthDate.Equals (other.birthDate)
				&& this.firstName == other.firstName
				&& this.email == other.email
				&& this.birthDate.Equals(other.birthDate);
		}

		public override int GetHashCode ()
		{
			return email.GetHashCode ();
		}

		public override string ToString ()
		{
			return string.Format ("[Employee {0} {1} {2} {3}]", firstName, lastName, email, birthDate);
		}
	}
}

