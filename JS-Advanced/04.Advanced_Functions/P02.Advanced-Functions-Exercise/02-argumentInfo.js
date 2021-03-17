function argumentInfo() {
    let data = new Map();

    for (const arg of arguments) {
        let argumentType = typeof(arg);

        console.log(`${argumentType}: ${arg}`);

        if (!data.get(argumentType)) {
            data.set(argumentType, 0);
        }

        data.set(argumentType, data.get(argumentType) + 1);
    }

    [...data]
    .sort((a, b) => b[1] - a[1])
    .forEach(param => { console.log(`${param[0]} = ${param[1]}`); });
}

// Map.prototype.get(key)
// Returns the value associated to the key, or undefined if there is none.

// Map.prototype.set(key, value)
// Sets the value for the key in the Map object. Returns the Map object.

argumentInfo('cat', 42, function () {
    console.log('Hello world!');
});