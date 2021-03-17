function diagonalSumMatrix(matrix) {
    let leftDiagonal = 0;
    let rightDiagonal = 0;

    for (let i = 0; i < matrix.length; i++) {
        leftDiagonal += matrix[i][i];
        rightDiagonal += matrix[i][matrix.length - 1 - i];
    }

    console.log(leftDiagonal + " " + rightDiagonal);
}

diagonalSumMatrix([
    [20, 40],
    [10, 60]
]);

diagonalSumMatrix([
    [3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]
]);

// function diagonalSumMatrix(matrix) {
//     let firstDiagonal = 0;
//     let col = 0;

//     for (let row = 0; row < matrix.length; row++) {     
//         let number = Number(matrix[row][col]);
//         firstDiagonal += number; 
//         col++;      
//     }

//     let secondDiagonal = 0;
//     let row = 0;

//     for (let col = matrix.length - 1; col >= 0; col--) {
//         let number = Number(matrix[row][col]);
//         secondDiagonal += number;
//         row++;      
//     }

//     console.log(`${firstDiagonal} ${secondDiagonal}`);
// }

// diagonalSumMatrix([[3, 5, 17],
//     [-1, 7, 14],
//     [1, -8, 89]]);