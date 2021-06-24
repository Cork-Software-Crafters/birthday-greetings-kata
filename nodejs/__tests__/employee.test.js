const Employee = require('../lib/employee');

describe('Employee', () => {

    test('should know when date is his birthday', () => {
        let employee = new Employee("John", "Doe", new Date(1985, 3, 25), "john.doe@foobar.com")

        expect(employee.isBirthday(new Date(2021, 3, 25))).toBe(true);
    });

    test('should know when date is not his birthday', () => {
        let employee = new Employee("John", "Doe", new Date(1985, 3, 25), "john.doe@foobar.com")

        expect(employee.isBirthday(new Date(2021, 3, 24))).toBe(false);
        expect(employee.isBirthday(new Date(2021, 4, 25))).toBe(false);
    });

});
