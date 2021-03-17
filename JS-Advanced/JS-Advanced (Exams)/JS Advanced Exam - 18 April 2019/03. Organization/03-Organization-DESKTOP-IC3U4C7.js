class Organization {
    constructor(name, budget) {
        this.name = name;
        this.budget = budget;
        this.employees = [];
        this.departments = {
            marketing: this.budget * 0.4,
            finance: this.budget * 0.25,
            production: this.budget * 0.35
        };
    }

    get departmentsBudget() {
        return {
            marketing: this.departments['marketing'],
            finance: this.departments['finance'],
            production: this.departments['production']
        };
    }

    add(employeeName, department, salary) {
        if (this.departmentsBudget[department] >= salary) {
            const employee = {
                employeeName,
                department,
                salary
            };

            this.employees.push(employee);
            this.departments[department] -= salary;

            return `Welcome to the ${department} team Mr./Mrs. ${employeeName}.`;
        }

        return `The salary that ${department} department can offer to you Mr./Mrs. ${employeeName} is $${this.departmentsBudget[department]}.`;
    }

    employeeExists(employeeName) {
        let employeeIndex = this.employees.findIndex(e => e.employeeName === employeeName);

        if (employeeIndex === -1) {
            return `Mr./Mrs. ${employeeName} is not working in ${this.name}.`;
        }

        return `Mr./Mrs. ${employeeName} is part of the ${this.employees[employeeIndex].department} department.`;
    }

    leaveOrganization(employeeName) {
        let employeeIndex = this.employees.findIndex(e => e.employeeName === employeeName);

        if (employeeIndex === -1) {
            return `Mr./Mrs. ${employeeName} is not working in ${this.name}.`;
        }

        this.departments[this.employees[employeeIndex].department] += this.employees[employeeIndex].salary;
        this.employees.splice(employeeIndex, 1);

        return `It was pleasure for ${this.name} to work with Mr./Mrs. ${employeeName}.`;
    }

    status() {
        let result = `${this.name.toUpperCase()} DEPARTMENTS:`;
        result += `\n${output('marketing', this.employees, this.departments)}`;
        result += `\n${output('finance', this.employees, this.departments)}`;
        result += `\n${output('production', this.employees, this.departments)}`;

        return result;

        function output(department, employees, departments) {
            return `${department.charAt(0).toUpperCase() + department.slice(1)} | Employees: ${employees
                .filter(e => e.department === `${department}`).length}: ${employees
                    .filter(e => e.department === `${department}`)
                    .sort((a, b) => b.salary - a.salary)
                    .map(e => e.employeeName)
                    .join(', ')} | Remaining Budget: ${departments[`${department}`]}`;
        }
    }
}

// ============================================

let organization = new Organization('SoftUni', 20000);

console.log(organization.add('Peter', 'marketing', 1200));
console.log(organization.add('Robert', 'production', 2000));
console.log(organization.leaveOrganization('Peter'));

console.log(organization.status());

// Welcome to the marketing team Mr./Mrs. Peter.
// Welcome to the production team Mr./Mrs. Robert.
// It was pleasure for SoftUni to work with Mr./Mrs. Peter.

// SOFTUNI DEPARTMENTS:
// Marketing | Employees: 0:  | Remaining Budget: 8000
// Finance | Employees: 0:  | Remaining Budget: 5000
// Production | Employees: 1: Robert | Remaining Budget: 5000
// ============================================

// let organization = new Organization('SBTech', 1000);

// console.log(organization.add('Peter', 'marketing', 800));
// console.log(organization.add('Robert', 'production', 2000));
// console.log(organization.add('Peter', 'production', 2000));

// The salary that marketing department can offer to you Mr./Mrs. Peter is $400.
// The salary that production department can offer to you Mr./Mrs. Robert is $350.
// The salary that production department can offer to you Mr./Mrs. Peter is $350.

// ============================================ !!!!!!!!!!!
// * There are some important differences between dot and bracket notation:
// Dot notation:
// Property identifies can only be alphanumeric (and _ and $)
// Property identifiers cannot start with a number.
// Property identifiers cannot contain variables.
// OK — obj.prop_1, obj.prop$
// Not OK — obj.1prop, obj.prop name
// Bracket notation:
// Property identifiers have to be a String or a variable that references a String.
// It is okay to use variables, spaces, and Strings that start with numbers
// OK — obj["1prop"], obj["prop name"]