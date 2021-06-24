const BirthdayService = require("./lib/birthday_service");
const EmailSmtpTransport = require("./lib/email_smtp_transport");

let emailSmtpTransport = new EmailSmtpTransport("localhost", 25);
let birthdayService = new BirthdayService(emailSmtpTransport);

birthdayService.sendGreetings('employee_data.csv', new Date(2021, 9, 8));
