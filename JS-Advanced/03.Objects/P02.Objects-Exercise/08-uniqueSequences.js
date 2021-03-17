function uniqueSequences(arrays) {
    let uniqueSeqs = new Map();

    for (let line of arrays) {
        let seq = JSON.parse(line).map(Number).sort((a, b) => b - a);
        let seqLength = seq.length;

        if (!uniqueSeqs.has(seqLength)) {
            uniqueSeqs.set(seqLength, new Set());
        }

        uniqueSeqs.get(seqLength).add(`[${seq.join(', ')}]`);
    }

    let lengthKeys = [...uniqueSeqs.keys()].sort((a, b) => a - b);

    for (let currentLength of lengthKeys) {

        for (let seq of uniqueSeqs.get(currentLength)) {
            console.log(seq);
        }
    }
}

uniqueSequences([
    "[-3, -2, -1, 0, 1, 2, 3, 4]",
    "[10, 1, -17, 0, 2, 13]",
    "[4, -3, 3, -2, 2, -1, 1, 0]"
]);

uniqueSequences([
    "[7.14, 7.180, 7.339, 80.099]",
    "[7.339, 80.0990, 7.140000, 7.18]",
    "[7.339, 7.180, 7.14, 80.099]"
]);

// function uniqueSequences(arrays) {
//     let uniqueSeqs = new Set();

//     for (let line of arrays) {
//         let seq = JSON.parse(line).map(Number)
//                 .sort((a, b) => b - a)  
//                 .join(', ');
//         uniqueSeqs.add(seq);
//     }

//     [...uniqueSeqs].sort(function (a, b) {
//             let lenA = a.split(', ').length;
//             let lenB = b.split(', ').length;
//             if (lenA != lenB) return lenA - lenB;
//         })
//         .forEach(seq => console.log(`[${seq}]`));
// }