class Hex {
    constructor(value) {
        this.value = value;
    }

    valueOf() {
        return this.value;
    }

    toString() {
        return `0x${this.value.toString(16).toUpperCase()}`;
    }

    plus(number) {
        if (number instanceof Hex) {
            return new Hex(this.value + number);
        }
    }

    minus(number) {
        if (number instanceof Hex) {
            return new Hex(this.value - number);
        }
    }

    parse(string) {
        return parseInt(string, 10);
    }
}

let FF = new Hex(255);
console.log(FF.toString());
console.log(FF.parse(0xFF));
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString() === '0xF');

// By default, JavaScript displays numbers as base 10 decimals.
// But you can use the toString() method to output numbers from base 2 to base 36.
// Hexadecimal is base 16. Decimal is base 10. Octal is base 8. Binary is base 2.