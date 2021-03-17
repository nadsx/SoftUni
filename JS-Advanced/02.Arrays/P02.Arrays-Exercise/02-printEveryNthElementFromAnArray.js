function NElementFromAnArray(array) {
    let lastStep = Number(array.pop());

    for (let i = 0; i < array.length; i += lastStep) {
        console.log(array[i]);
    }
}

NElementFromAnArray(['5',
    '20',
    '31',
    '4',
    '20',
    '2'
]);

NElementFromAnArray(['dsa',
    'asd',
    'test',
    'tset',
    '2'
]);

NElementFromAnArray(['1',
    '2',
    '3',
    '4',
    '5',
    '6'
]);