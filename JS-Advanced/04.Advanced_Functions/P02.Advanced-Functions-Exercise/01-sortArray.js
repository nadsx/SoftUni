function sortArray(array, sortCriteria) {
    return array
        .sort((a, b) => sortCriteria == "asc" ? a - b : b - a);
}

console.log(sortArray([14, 7, 17, 6, 8], 'asc'));
console.log(sortArray([14, 7, 17, 6, 8], 'desc'));

// function sortArray(arr, sortMethod) {
//     let sortingStrategies = {
//         asc: (a, b) => a - b,
//         desc: (a,b) => b -a
//     };
//
//     return arr.sort(sortingStrategies[sortMethod]);
// }