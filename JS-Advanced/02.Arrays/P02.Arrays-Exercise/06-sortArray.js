function sortArray(arr) {
    arr.sort((a, b) => { 
        return a.length - b.length || a.localeCompare(b); 
    }).forEach(x => console.log(x));
}

sortArray(['alpha',
    'beta',
    'gamma'
]);

sortArray(['Isacc',
    'Theodor',
    'Jack',
    'Harrison',
    'George'
]);

sortArray(['test',
    'Deny',
    'omen',
    'Default'
]);

// // The letter "a" is before "c" yielding a negative value
// 'a'.localeCompare('c'); // -2 or -1 (or some other negative value)

// // Alphabetically the word "check" comes after "against" yielding a positive value
// 'check'.localeCompare('against'); // 2 or 1 (or some other positive value)

// // "a" and "a" are equivalent yielding a neutral value of zero
// 'a'.localeCompare('a'); // 0