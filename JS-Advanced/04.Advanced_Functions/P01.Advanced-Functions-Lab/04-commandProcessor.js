function commandProcessor() {
    return function () {
        let result = "";

        return {
            append: (str) => result += str,
            removeStart: (n) => result = result.slice(n),
            removeEnd: (n) => result = result.slice(0, result.length - n),
            print: () => console.log(result)
        };

    }();
}

// array.slice() and string.slice() are DIFFERENT!!
// The variable add is assigned the return value of a self-invoking function.
// The self-invoking function only runs once. It sets the counter to zero (0), 
// and returns a function expression.

let firstZeroTest = commandProcessor();

firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();

let secondZeroTest = commandProcessor();

secondZeroTest.append('123');
secondZeroTest.append('45');
secondZeroTest.removeStart(2);
secondZeroTest.removeEnd(1);
secondZeroTest.print();