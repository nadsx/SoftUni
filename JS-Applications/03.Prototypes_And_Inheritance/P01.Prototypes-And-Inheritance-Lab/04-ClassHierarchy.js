function classHierarchy() {
    class Figure {
        constructor() {
            this.unit = 'cm';
            this.units = {
                m: 0.01,
                cm: 1,
                mm: 10
            };
        }

        changeUnits(x) {
            this.unit = x;
        }

        toString() {
            return `Figures units: ${this.unit} Area: ${this.area} -`;
        }
    }

    class Circle extends Figure {
        constructor(r) {
            super();
            this.radius = r;
        }

        get area() {
            const r = this.radius * this.units[this.unit];
            return Math.PI * r * r;
        }

        toString() {
            const r = this.radius * this.units[this.unit];
            return `${super.toString()} radius: ${r}`;
        }
    }

    class Rectangle extends Figure {
        constructor(w, h, unit) {
            super();
            this.width = w;
            this.height = h;
            this.unit = unit;
        }

        get area() {
            const w = this.width * this.units[this.unit];
            const h = this.height * this.units[this.unit];
            return w * h;
        }

        toString() {
            const w = this.width * this.units[this.unit];
            const h = this.height * this.units[this.unit];
            return `${super.toString()} width: ${w}, height: ${h}`;
        }
    }

    return {
        Figure,
        Circle,
        Rectangle
    };
}

let create = classHierarchy();

let Figure = create.Figure;
let Rectangle = create.Rectangle;
let Circle = create.Circle;

let c = new Circle(5);
console.log(c.area); // 78.53981633974483
console.log(c.toString()); // Figures units: cm Area: 78.53981633974483 - radius: 5

let r = new Rectangle(3, 4, 'mm');
console.log(r.area); // 1200 
console.log(r.toString()); //Figures units: mm Area: 1200 - width: 30, height: 40

r.changeUnits('cm');
console.log(r.area); // 12
console.log(r.toString()); // Figures units: cm Area: 12 - width: 3, height: 4

c.changeUnits('mm');
console.log(c.area); // 7853.981633974483
console.log(c.toString()); // Figures units: mm Area: 7853.981633974483 - radius: 50