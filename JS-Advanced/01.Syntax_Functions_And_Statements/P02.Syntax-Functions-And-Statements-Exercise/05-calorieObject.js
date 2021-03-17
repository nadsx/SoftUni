function solve(array) {

    let obj = {};

    for (let index = 0; index < array.length; index += 2) {
        let element = array[index];
        let value = Number(array[index + 1]); // +array.. cast to number or Number(array..)

        obj[element] = value;
    }

    console.log(obj);
}

solve(['Yoghurt', 48, 'Rise', 138, 'Apple', 52]);
solve(['Potato', 93, 'Skyr', 63, 'Cucumber', 18, 'Milk', 42]);