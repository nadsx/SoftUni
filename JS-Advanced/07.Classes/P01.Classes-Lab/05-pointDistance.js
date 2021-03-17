class Point {
    constructor(x, y){
        this.x = x;
        this.y = y;
    }

    static distance(firstPoint, secondPoint){
        //return Math.sqrt((p1.x - p2.x) ** 2 + (p1.y - p2.y) ** 2);
        const a = Math.pow(firstPoint.x - secondPoint.x, 2);
        const b = Math.pow(firstPoint.y - secondPoint.y, 2);
        const distance = Math.sqrt(a + b);

        return distance;
    }
}

let p1 = new Point(5, 5);
let p2 = new Point(9, 8);
console.log(Point.distance(p1, p2));