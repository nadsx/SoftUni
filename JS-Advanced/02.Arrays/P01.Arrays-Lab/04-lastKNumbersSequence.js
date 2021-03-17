function lastKNumbersSequence(n, k) {
    let result = [1];

    for (let i = 1; i < n; i++) {
        let firstIndex = result.length >= k ? result.length - k : 0;
        let sum = result.slice(firstIndex, result.length).reduce(function (acc, curr) {
            return acc + curr;
        }, 0);

        result[i] = sum;

    }

    console.log(result.join(" "));
}

lastKNumbersSequence(6, 3);
lastKNumbersSequence(8, 2);