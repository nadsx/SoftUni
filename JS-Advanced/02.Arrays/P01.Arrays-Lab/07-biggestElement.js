function biggestElement(matrix) {
    let maxNum = Number.MIN_SAFE_INTEGER;

    for (const arr of matrix) {
        let currentMaxNum = arr.reduce(function (acc, curr) {
            return Math.max(acc, curr);
        });

        if (currentMaxNum > maxNum) {
            maxNum = currentMaxNum;
        }
    }

    console.log(maxNum);
}

biggestElement([
    [20, 50, 10],
    [8, 33, 145]
]);

biggestElement([
    [3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]
]);