class Message {
    subject;
    body;
    recipient;

    constructor(subject, body, recipient) {
        this.subject = subject;
        this.body = body;
        this.recipient = recipient;
    }
}

module.exports = Message
