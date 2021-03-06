(function arrayExtension() {
    Array.prototype.last = function () {
        return this[this.length - 1];
    };

    Array.prototype.skip = function (n) {
        return this.slice(n);
    };

    Array.prototype.take = function (n) {
        return this.slice(0, n);
    };

    Array.prototype.sum = function () {
        return this
            .map(Number)
            .reduce((acc, curr) => {
                return acc + curr;
            }, 0);
    };

    Array.prototype.average = function () {
        return this.sum() / this.length;
    };
}());

let myArr = [15, 30, 45, 60, 75, 90];

console.log(myArr.skip(2));
console.log(myArr.take(2));
console.log(myArr.last());
console.log(myArr.sum());
console.log(myArr.average());
console.log(myArr);