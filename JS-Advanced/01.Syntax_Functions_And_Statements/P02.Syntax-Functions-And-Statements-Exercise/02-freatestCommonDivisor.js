function solve(a, b) {

    while (b) {
        let temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}

console.log(solve(15, 5));
console.log(solve(2154, 458));

//84/18 = 4 и остатък 12
//18/12 = 1 и остатък 6
//12/6 = 2 без остатък
//=> НОД(18,84) = 6