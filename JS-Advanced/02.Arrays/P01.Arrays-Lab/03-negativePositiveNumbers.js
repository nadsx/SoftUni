function produceNewArray(array) {
    let newArray = [];

    for (let number of array) {

        if (number < 0) {
            newArray.unshift(number);
        } else {
            newArray.push(number);
        }
    }

    console.log(newArray.join("\n"));
}

produceNewArray([7, -2, 8, 9]);
produceNewArray([3, -2, 0, -1]);