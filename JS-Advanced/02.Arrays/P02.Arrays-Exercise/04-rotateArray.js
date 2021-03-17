function rotateArray(array) {
    let countRotations = Number(array.pop()) % array.length;

    for (let i = 0; i < countRotations; i++) {
        let lastElement = array.pop();
        array.unshift(lastElement);
    }

    console.log(array.join(" "));
}

rotateArray([
    '1', '2', '3', '4', '2'
]);

rotateArray(['Banana',
    'Orange',
    'Coconut',
    'Apple',
    '15'
]);