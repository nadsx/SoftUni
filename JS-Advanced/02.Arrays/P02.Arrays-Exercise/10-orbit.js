function buildOrbits(array) {
    let rows = Number(array[0]);
    let cols = Number(array[1]);
    let rowIndex = Number(array[2]);
    let colIndex = Number(array[3]);

    let matrix = [];

    for (let row = 0; row < rows; row++) {
        matrix[row] = [];

        for (let col = 0; col < cols; col++) {
            matrix[row][col] = Math.max(Math.abs(row - rowIndex), Math.abs(col - colIndex)) + 1;
        }
    }
    console.log(matrix.map(x => x.join(" ")).join("\n"));
}

buildOrbits([4, 4, 0, 0]);
buildOrbits([5, 5, 2, 2]);
buildOrbits([3, 3, 2, 2]);