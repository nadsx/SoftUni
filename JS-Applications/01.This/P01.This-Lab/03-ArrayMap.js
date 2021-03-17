function arrayMap(array, func) {
    return array.reduce((acc, curr) => [...acc, func(curr)], []);
}

let nums = [1, 2, 3, 4, 5];
console.log(arrayMap(nums, (item) => item * 2));

// let letters = ["a","b","c"];
// console.log(arrayMap(letters,(l) => l.toLocaleUpperCase())); // [ 'A', 'B', 'C' ]

//-------------------------

// function arrayMap(array, func) {
//     return array.reduce((a, b) => a.concat(func(b)), []);
// }