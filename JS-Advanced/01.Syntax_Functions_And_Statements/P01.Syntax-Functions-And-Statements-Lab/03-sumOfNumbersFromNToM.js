function sumOfNumbers(n, m) {
    let sum = 0;
    let start = Number(n);
    let end = Number(m);

    for (let i = start; i <= end; i++) {
        sum += i;
    }

    console.log(sum);
}

sumOfNumbers('1', '5');
sumOfNumbers('-8', '20');