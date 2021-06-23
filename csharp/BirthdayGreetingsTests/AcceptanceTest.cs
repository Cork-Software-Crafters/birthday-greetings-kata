using NUnit.Framework;
using System;
using BirthdayGreetings;
using netDumbster.smtp;

namespace BirthdayGreetingsTests
{
	[TestFixture]
	public class AcceptanceTest
	{
		private BirthdayService service;
		private string FILE_NAME = "../../../BirthdayGreetings/employee_data.txt";
		private SimpleSmtpServer smtpServer;

		[SetUp]
		public void setUp() 
		{
			service = new BirthdayService ();
			smtpServer = SimpleSmtpServer.Start ();
		}

		[TearDown]
		public void TearDown()
		{
			smtpServer.Stop();
		}

		[Test]
		public void willSendGreetings_whenItsSomebodysBirthday() 
		{
			service.SendGreetings(FILE_NAME, new XDate("2008/10/08"), "localhost", smtpServer.Port);

			Assert.AreEqual(1, smtpServer.ReceivedEmailCount, "message not sent?");
			var message = smtpServer.ReceivedEmail [0];
			Assert.AreEqual ("Happy Birthday, dear John!", message.MessageParts[0].BodyData);
			Assert.AreEqual ("Happy Birthday!", message.Headers.Get("subject"));
			Assert.AreEqual (1, message.ToAddresses.Length);
			Assert.AreEqual ("john.doe@foobar.com", message.ToAddresses[0].ToString());
		}

		[Test]
		public void willNotSendEmailsWhenNobodysBirthday() 
		{
			service.SendGreetings(FILE_NAME, new XDate("2008/01/01"), "localhost", smtpServer.Port);
			Assert.AreEqual(0, smtpServer.ReceivedEmailCount, "what? messages?");
		}

	}
}

