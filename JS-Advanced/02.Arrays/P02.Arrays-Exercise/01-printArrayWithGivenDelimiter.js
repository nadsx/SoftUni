function printWithDelimiter(array) {
    //console.log(array.filter((x, i) => i !== array.length - 1).join(array[array.length - 1]));

    let delimiter = array.pop();
    let result = array.join(delimiter);

    console.log(result);
}

printWithDelimiter([
    'One', 'Two', 'Three', 'Four', 'Five', '-'
]);

printWithDelimiter([
    ['How about no?',
        'I',
        'will',
        'not',
        'do',
        'it!',
        '_'
    ]
]);