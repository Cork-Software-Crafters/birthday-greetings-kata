class Employee {
    firstName;
    lastName;
    birthDate;
    email;

    constructor(firstName, lastName, birthDate, email) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
        this.email = email;
    }

    isBirthday(today) {
        return today.getMonth() === this.birthDate.getMonth() &&
            today.getDate() === this.birthDate.getDate();
    }
}

module.exports = Employee;
