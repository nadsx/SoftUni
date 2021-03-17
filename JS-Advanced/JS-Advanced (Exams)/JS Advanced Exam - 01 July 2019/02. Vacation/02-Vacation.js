class Vacation {
    constructor(organizer, destination, budget) {
        this.organizer = organizer;
        this.destination = destination;
        this.budget = Number(budget);
        this.kids = {};
    }

    get numberOfChildren() {
        let countOfAllKids = 0;

        for (const grade in this.kids) {
            if (this.kids.hasOwnProperty(grade)) {
                const currentGradeKids = this.kids[grade].length;
                countOfAllKids += currentGradeKids;
            }
        }

        return countOfAllKids;
    }

    registerChild(name, grade, budget) {
        if (this.budget > budget) {
            return `${name}'s money is not enough to go on vacation to ${this.destination}.`;
        }

        if (!this.kids.hasOwnProperty(grade)) {
            this.kids[grade] = [];
        }

        if (this.kids[grade].find(x => x === `${name}-${budget}`)) {
            return `${name} is already in the list for this ${this.destination} vacation.`;
        }

        this.kids[grade].push(`${name}-${budget}`);

        return this.kids[grade];
    }

    removeChild(name, grade) {
        if (!this.kids.hasOwnProperty(grade)) {
            return `We couldn't find ${name} in ${grade} grade.`;
        }

        if (!this.kids[grade].find(x => x.startsWith(name))) {
            return `We couldn't find ${name} in ${grade} grade.`;
        }

        const index = this.kids[grade].findIndex(x => x.startsWith(name));
        this.kids[grade].splice(index, 1);

        return this.kids[grade];
    }

    toString() {
        if (this.numberOfChildren === 0) {
            return `No children are enrolled for the trip and the organization of ${this.organizer} falls out...`;
        }

        let result = `${this.organizer} will take ${this.numberOfChildren} children on trip to ${this.destination}\n`;

        for (const grade in this.kids) {
            if (this.kids.hasOwnProperty(grade)) {
                const kids = this.kids[grade];
                result += `Grade: ${grade}\n`;

                let count = 1;

                for (const kid of kids) {
                    result += `${count++}. ${kid}\n`;
                }
            }
        }

        return result.trim();
    }
}

let vacation = new Vacation('Miss Elizabeth', 'Dubai', 2000);

vacation.registerChild('Gosho', 5, 3000);
vacation.registerChild('Lilly', 6, 1500);
vacation.registerChild('Pesho', 7, 4000);
vacation.registerChild('Tanya', 5, 5000);
vacation.registerChild('Mitko', 10, 5500);

console.log(vacation.toString());

//-----------------------------

// let vacation = new Vacation('Mr Pesho', 'San diego', 2000);

// console.log(vacation.registerChild('Gosho', 5, 2000));
// console.log(vacation.registerChild('Lilly', 6, 2100));
// console.log(vacation.registerChild('Pesho', 6, 2400));
// console.log(vacation.registerChild('Gosho', 5, 2000));
// console.log(vacation.registerChild('Tanya', 5, 6000));
// console.log(vacation.registerChild('Mitko', 10, 1590));

//-----------------------------

// let vacation = new Vacation('Mr Pesho', 'San diego', 2000);
// vacation.registerChild('Gosho', 5, 2000);
// vacation.registerChild('Lilly', 6, 2100);

// console.log(vacation.removeChild('Gosho', 9));

// vacation.registerChild('Pesho', 6, 2400);
// vacation.registerChild('Gosho', 5, 2000);

// console.log(vacation.removeChild('Lilly', 6));
// console.log(vacation.registerChild('Tanya', 5, 6000));