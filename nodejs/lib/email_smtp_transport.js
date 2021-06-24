// Fake implementation of a 3rd party library to send emails over SMTP, in real life we would use something like nodemailer.
class EmailSmtpTransport {
    smtpHost;
    smtpPort;

    constructor(smtpHost, smtpPort) {
        this.smtpHost = smtpHost;
        this.smtpPort = smtpPort;
    }

    send(message) {
        console.debug("Sending message to " + message.recipient);
        // Construct and send an e-mail over SMTP calling the network ...
    }
}

module.exports = EmailSmtpTransport;
