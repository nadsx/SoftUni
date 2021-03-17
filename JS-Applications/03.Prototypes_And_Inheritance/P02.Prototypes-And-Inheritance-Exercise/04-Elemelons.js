function generateMelonClasses() {
    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new Error('Melon class cannot be instantiated.');
            }

            this.weight = weight;
            this.melonSort = melonSort;
            this.element = '';
        }

        get elementIndex() {
            return this.weight * this.melonSort.length;
        }

        toString() {
            let output = `Element: ${this.element}\n`;
            output += `Sort: ${this.melonSort}\n`;
            output += `Element Index: ${this.elementIndex}`;

            return output;
        }
    }

    class Watermelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Water';
        }
    }

    class Firemelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Fire';
        }
    }

    class Earthmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Earth';
        }
    }

    class Airmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this.element = 'Air';
        }
    }

    class Melolemonmelon extends Watermelon {
        constructor(weight, melonSort) {
            super(weight, melonSort);
            this._elements = ['Water', 'Fire', 'Earth', 'Air'];
            this.morph();
        }

        morph() {
            let current = this._elements.shift();
            this.element = current;
            this._elements.push(current);
        }
    }

    return {
        Melon,
        Watermelon,
        Firemelon,
        Earthmelon,
        Airmelon,
        Melolemonmelon
    };
}

let create = generateMelonClasses();
let water = new create.Watermelon(869.75, 'NFMelon');
console.log(water.toString());
console.log(`---------------------`);

let melolemon = new create.Melolemonmelon(12.5, "KingMelon");
console.log(melolemon.toString());
console.log(`---------------------`);

melolemon.morph();
console.log(melolemon.toString());