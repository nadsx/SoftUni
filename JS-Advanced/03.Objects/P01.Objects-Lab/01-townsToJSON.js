function townsToJSON(arr) {
    let pattern = /\s*\|\s*/;
    let keys = arr[0].split(pattern).filter(x => x != "");
    let townsArr = [];

    for (let line of arr.slice(1)) {
        let [empty, townName, latitude, longitude] = line.split(pattern);

        let townObj = {
            [keys[0]]: townName,
            [keys[1]]: Number(Number(latitude).toFixed(2)),
            [keys[2]]: Number(Number(longitude).toFixed(2))
        };

        townsArr.push(townObj);
    }

    console.log(JSON.stringify(townsArr));
}

townsToJSON(
    ['| Town | Latitude | Longitude |',
        '| Sofia | 42.696552 | 23.32601 |',
        '| Beijing | 39.913818 | 116.363625 |'
    ]
);

townsToJSON(
    ['| Town | Latitude | Longitude |',
        '| Veliko Turnovo | 43.0757 | 25.6172 |',
        '| Monatevideo | 34.50 | 56.11 |'
    ]
);