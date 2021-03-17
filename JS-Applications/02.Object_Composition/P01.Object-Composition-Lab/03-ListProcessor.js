function listProcessor(data) {
    const actions = {
        add: (arr, str) => [...arr, str],
        remove: (arr, str) => arr.filter(x => x !== str),
        print: (arr, ) => {
            console.log(arr.join(","));
            return arr;
        }
    };

    let arr = [];

    return data
        .map(x => x.split(" "))
        .forEach(([command, str]) =>
            arr = actions[command](arr, str)
        );
}

listProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print']);
listProcessor(['add pesho', 'add george', 'add peter', 'remove peter', 'print']);

// var arr1 = [0, 1, 2];
// var arr2 = [3, 4, 5];
// arr1 = [...arr1, ...arr2]; // arr1 => [0, 1, 2, 3, 4, 5]