functionalSum = (function () {
    let sum = 0;

    return function add(num) {
        sum += num;

        add.toString = function () {
            return sum;
        };

        return add;
    };
})();

var functionalSum; //!! <= For JUDGE SYSTEM, variable declaration is here!
//console.log(functionalSum(1).toString());
console.log(functionalSum(1)(6)(-3).toString());