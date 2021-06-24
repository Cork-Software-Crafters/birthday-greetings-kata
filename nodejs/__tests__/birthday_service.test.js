const BirthdayService = require('../lib/birthday_service');
const Message = require('../lib/message');

class InMemoryEmailSmtpTransport {
    sentMessages = []

    send(message) {
        this.sentMessages.push(message);
    }
}

describe('BirthdayService', () => {

    let emailSmtpTransport;
    let service;

    beforeEach(() => {
        emailSmtpTransport = new InMemoryEmailSmtpTransport();
        service = new BirthdayService(emailSmtpTransport);
    });

    test('should send greetings when it is somebodies birthday', () => {
        service.sendGreetings('employee_data.csv', new Date("1982-10-08"));

        expect(emailSmtpTransport.sentMessages).toEqual([
            new Message("Happy Birthday!", "Happy Birthday, dear John!", "john.doe@foobar.com")])
    });

    test('should not send greetings when nobodies birthday', () => {
        service.sendGreetings('employee_data.csv', new Date("2020-11-24"));

        expect(emailSmtpTransport.sentMessages).toHaveLength(0);
    });

});
