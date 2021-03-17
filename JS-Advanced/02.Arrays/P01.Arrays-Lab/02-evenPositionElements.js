function getItemsFromEvenIndexes(array) {
    let items = [];

    for (let i = 0; i < array.length; i++) {

        if (i % 2 === 0) {
            items.push(array[i]);
        }
    }

    return items.join(" ");
}

console.log(getItemsFromEvenIndexes(['20', '30', '40']));
console.log(getItemsFromEvenIndexes(['5', '10']));