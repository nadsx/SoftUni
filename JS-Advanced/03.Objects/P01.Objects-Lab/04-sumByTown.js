function sumByTown(arr) {
    let townIncomesObj = {};

    for (let i = 0; i < arr.length; i += 2) {
        let [town, income] = [arr[i], Number(arr[i + 1])];

        if (!townIncomesObj[town]) {
            townIncomesObj[town] = 0;
        }

        townIncomesObj[town] += income;
    }

    console.log(JSON.stringify(townIncomesObj));
}

sumByTown(['Sofia', '20',
    'Varna', '3',
    'Sofia', '5',
    'Varna', '4'
]);

sumByTown(['Sofia', '20',
    'Varna', '3',
    'sofia', '5',
    'varna', '4'
]);