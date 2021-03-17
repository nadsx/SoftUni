function extractIncreasingElements(array) {
    let result = [];
    let prevElement = array[0];
    result.push(prevElement);

    for (let i = 1; i < array.length; i++) {
        const element = array[i];

        if (prevElement <= element) {
            prevElement = element;
            result.push(element);
        }
    }

    console.log(result.join("\n"));
}

extractIncreasingElements([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24
]);

extractIncreasingElements([1,
    2,
    3,
    4
]);

extractIncreasingElements([20,
    3,
    2,
    15,
    6,
    1
]);