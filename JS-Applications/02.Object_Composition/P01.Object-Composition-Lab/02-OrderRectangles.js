function orderRectangles(data) {
    const template = {
        width: 0,
        height: 0,
        area: function () {
            return this.width * this.height;
        },
        compareTo: function (other) {
            if (this.area() < other.area()) {
                return -1;
            } else if (this.area() === other.area()) {
                return 0;
            } else {
                return 1;
            }
        }
    };

    return data.map(([width, height]) =>
            Object.assign(Object.create(template), {
                width,
                height
            }))
        .sort((a, b) => b.compareTo(a) === 0 ? b.width - a.width : b.compareTo(a));
}

console.log(orderRectangles([
    [10, 5],
    [5, 12]
]));

console.log(orderRectangles([
    [10, 5],
    [3, 20],
    [5, 12]
]));