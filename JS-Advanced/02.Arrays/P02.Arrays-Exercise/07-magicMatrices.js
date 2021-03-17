function magicMatrix(matrix) {
    let arr = [];
    let isMagic = true;

    for (let i in matrix) {
        const rowSum = matrix[i].reduce((acc, curr) => acc + curr, 0);
        const colSum = matrix.reduce((acc, curr) => {
            acc += curr[i];
            return acc;
        }, 0);

        if (rowSum !== colSum || (arr.length > 0 && (rowSum !== arr[0] || colSum !== arr[1]))) {
            isMagic = false;
            return isMagic;
        } else if (i === '0') {
            arr.push(rowSum, colSum);
        }
    }

    return isMagic;
}

console.log(magicMatrix([
    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]
]));

console.log(magicMatrix([
    [11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]   
]));

console.log(magicMatrix([
    [1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]  
]));

// function solve(matrix) {
//     let magicNumber = matrix[0].reduce((acc, curr) => acc + curr);
//     let isMagic = true;

//     for (let i = 1; i < matrix.length; i++) {
//         let currentNumber = matrix[i].reduce((acc, curr) => acc + curr);

//         if (currentNumber !== magicNumber) {
//             isMagic = false;
//             console.log(isMagic);

//             return;
//         }
//     }

//     for (let i = 0; i < matrix.length; i++) {
//         let currentColNumber = 0;

//         for (let j = 0; j < matrix.length; j++) {
//             currentColNumber += matrix[j][i];
//         }

//         if (currentColNumber !== magicNumber) {
//             isMagic = false;
//             console.log(isMagic);

//             return;
//         }
//     }
//     console.log(isMagic);
// }

// solve([[4, 5, 6],
//     [6, 5, 4],
//     [5, 5, 5]]
//    );