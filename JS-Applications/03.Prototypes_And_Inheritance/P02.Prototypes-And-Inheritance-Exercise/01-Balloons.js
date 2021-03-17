function createBalloonClasses() {
    class Balloon {
        constructor(color, gasWeight) {
            this.color = color;
            this.gasWeight = gasWeight;
        }
    }

    class PartyBalloon extends Balloon {
        constructor(color, gasWeight, ribbonColor, ribbonLength) {
            super(color, gasWeight);
            this._ribbon = {
                color: ribbonColor,
                length: ribbonLength
            };
        }

        get ribbon() {
            return this._ribbon;
        }
    }

    class BirthdayBalloon extends PartyBalloon {
        constructor(color, gasWeight, ribbonColor, ribbonLength, text) {
            super(color, gasWeight, ribbonColor, ribbonLength);
            this._text = text;
        }

        get text() {
            return this._text;
        }
    }

    return {
        Balloon,
        PartyBalloon,
        BirthdayBalloon
    };
}

let create = createBalloonClasses();

let Ballon = create.Balloon;
let PartyBalloon = create.PartyBalloon;
let BirthdayBalloon = create.BirthdayBalloon;

let ballon = new Ballon('red', 2.45);
console.log(ballon);
console.log(`---------------------`);

let partyBalloon = new PartyBalloon('blue', 88.6, 'white', 0.7);
console.log(partyBalloon);
partyBalloon.ribbon = ''; // Can't change from object to String, Number...
console.log(partyBalloon.ribbon);
console.log(`---------------------`);

let birthdayBalloon = new BirthdayBalloon('black', 999.99, 'yellow', 1.5, 'Happy B-day JavaScript');
console.log(birthdayBalloon);
console.log(birthdayBalloon.text);