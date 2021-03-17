function sumElements(array) {
    //let firstElement = Number(arr[0]);
    //let lastElement = Number(arr[arr.length -1]);

    let firstElement = Number(array.shift());
    let lastElement = Number(array.pop());

    if (!lastElement) {
        lastElement = firstElement;
    }

    let sum = firstElement + lastElement;

    return sum;
}

console.log(sumElements(['20', '30', '40']));
console.log(sumElements(['5', '10']));