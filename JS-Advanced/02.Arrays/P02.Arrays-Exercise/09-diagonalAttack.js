function diagonalAttack(matrix) {
    let firstDiagonal = 0;
    let secondDiagonal = 0;

    for (let i = 0; i < matrix.length; i++) {
        firstDiagonal += +matrix[i].split(" ")[i];
        secondDiagonal += +matrix[i].split(" ")[matrix.length - 1 - i];
    }

    if (firstDiagonal === secondDiagonal) {
        let sum = firstDiagonal;

        for (let row = 0; row < matrix.length; row++) {
            let elementsArr = matrix[row].split(" ");

            for (let col = 0; col < elementsArr.length; col++) {

                if (col !== row && col !== matrix.length - 1 - row) {
                    elementsArr[col] = sum;
                }
            }

            matrix[row] = elementsArr.join(" ");
        }

        console.log(matrix.join("\n"));
    }
}

diagonalAttack(
    ['5 3 12 3 1',
        '11 4 23 2 5',
        '101 12 3 21 10',
        '1 4 5 2 2',
        '5 22 33 11 1'
    ]
);

diagonalAttack(
    ['1 1 1',
        '1 1 1',
        '1 1 0'
    ]
);