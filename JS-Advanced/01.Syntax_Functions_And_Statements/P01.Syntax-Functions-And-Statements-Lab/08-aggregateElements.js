function aggregateElements(array) {
    let sumArray = array.reduce((a, b) => a + b, 0);
    let sumInverseArray = array.reduce((result, num) => result + 1 / num, 0);
    let stringFormArray = array.join('');

    console.log(sumArray);
    console.log(sumInverseArray);
    console.log(stringFormArray);
}

aggregateElements([1, 2, 3]);
aggregateElements([2, 4, 8, 16]);