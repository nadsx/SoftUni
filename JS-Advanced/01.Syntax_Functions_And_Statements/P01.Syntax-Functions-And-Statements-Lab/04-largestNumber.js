function getLargestNumber(num1, num2, num3) {
    let maxNum = Math.max(+num1, +num2, +num3); 

    console.log(`The largest number is ${maxNum}.`);
}

getLargestNumber(5, -3, 16);
getLargestNumber(-3, -5, -22.5);