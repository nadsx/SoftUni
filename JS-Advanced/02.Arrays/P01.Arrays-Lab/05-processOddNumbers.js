function processOddNumbers(array) {
    let transformedArray = array
        .filter((x, i) => {
            return i % 2 === 1;
        })
        .map((x) => {
            return x * 2;
        })
        .reverse()
        .join(" ");

    console.log(transformedArray);
}

processOddNumbers([10, 15, 20, 25]);
processOddNumbers([3, 0, 10, 4, 7, 3]);