function spiralMatrix(rows, cols) {
    printMatrix(getMatrix(rows, cols));

    function getMatrix(rows, cols) {
        let [count, maxCount, minRow, minCol, maxRow, maxCol] = [0, rows * cols, 0, 0, rows - 1, cols - 1];
        let matrix = [];

        for (let row = 0; row < rows; row++) {
            matrix[row] = [];
        }

        while (count < maxCount) {

            for (let col = minCol; col <= maxCol && count < maxCount; col++) {
                matrix[minRow][col] = ++count;
            }

            minRow++;

            for (let row = minRow; row <= maxRow && count < maxCount; row++) {
                matrix[row][maxCol] = ++count;
            }

            maxCol--;

            for (let col = maxCol; col >= minCol && count < maxCount; col--) {
                matrix[maxRow][col] = ++count;
            }

            maxRow--;

            for (let row = maxRow; row >= minRow && count < maxCount; row--) {
                matrix[row][minCol] = ++count;
            }

            minCol++;
        }

        return matrix;
    }

    function printMatrix(matrix) {
        matrix.forEach(row => console.log(row.join(" ")));
        // console.log(matrix.map(row => row.join(" ")).join("\n"));
    }
}

spiralMatrix(5, 5);
spiralMatrix(3, 3);

// function matrix(n, m) {
//     let result = new Array(n).fill("").map(() => new Array(m).fill(""));
//     let counter = 1;
//     let startCol = 0;
//     let endCol = n - 1;
//     let startRow = 0;
//     let endRow = n - 1;
//     while (startCol <= endCol && startRow <= endRow) {
//         for (let i = startCol; i <= endCol; i++) {
//             result[startRow][i] = counter;
//             counter++;
//         }
//         startRow++;
//         for (let j = startRow; j <= endRow; j++) {
//             result[j][endCol] = counter;
//             counter++;
//         }

//         endCol--;

//         for (let i = endCol; i >= startCol; i--) {
//             result[endRow][i] = counter;
//             counter++;
//         }

//         endRow--;
//         for (let i = endRow; i >= startRow; i--) {
//             result[i][startCol] = counter;
//             counter++;
//         }
//         startCol++;
//     }

//     for (let i = 0; i < result.length; i++) {
//         console.log(result[i].join(" "));
//     }
// }

// matrix(5, 5);
// matrix(3, 3);