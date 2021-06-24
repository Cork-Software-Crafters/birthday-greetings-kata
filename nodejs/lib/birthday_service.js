const fs = require("fs");
const Employee = require("./employee");
const Message = require('./message');

class BirthdayService {
    constructor(emailSmtpTransport) {
        this.emailSmtpTransport = emailSmtpTransport;
    }

    sendGreetings(fileName, date) {
        let fileContents = fs.readFileSync(fileName, 'utf8');
        let lines = fileContents.split(/\r?\n/).slice(1) // read lines skipping header;

        lines.forEach(line => {
            let employeeData = line.split(",").map(s => s.trim());

            let employee = new Employee(employeeData[1], employeeData[0], this.parseDate(employeeData[2]), employeeData[3]);

            if (employee.isBirthday(date)) {
                const message = new Message("Happy Birthday!", `Happy Birthday, dear ${employee.firstName}!`, employee.email);
                this.emailSmtpTransport.send(message)
            }
        })
    }

    parseDate(date) {
        let fields = date.split('/');
        return new Date(fields[0], fields[1] - 1, fields[2])
    }
}

module.exports = BirthdayService;
