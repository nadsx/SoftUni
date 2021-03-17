function modificationToArray(arrayOfStr) {
    let finalArray = [];

    for (let i = 0; i < arrayOfStr.length; i++) {
        let command = arrayOfStr[i];

        if (command === "add") {
            finalArray.push(i + 1);
        } else {
            finalArray.pop();
        }
    }

    if (finalArray.length > 0) {
        console.log(finalArray.join('\n'));

    } else {
        console.log("Empty");
    }
}

modificationToArray(['add',
    'add',
    'add',
    'add'
]);

modificationToArray(['add',
    'add',
    'remove',
    'add',
    'add'
]);

modificationToArray(['remove',
    'remove',
    'remove'
]);