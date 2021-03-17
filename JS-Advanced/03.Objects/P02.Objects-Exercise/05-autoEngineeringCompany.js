function autoEngineeringCompany(arr) {
    const carRegisterObj = {};

    for (let line of arr) {
        let [brand, model, producedCars] = line.split(" | ");
        producedCars = Number(producedCars);

        if (!carRegisterObj.hasOwnProperty(brand)) {
            carRegisterObj[brand] = {};
        }

        if (!carRegisterObj[brand].hasOwnProperty(model)) {
            carRegisterObj[brand][model] = 0;
        }

        carRegisterObj[brand][model] += producedCars;
    }

    for (let brand in carRegisterObj) {
        console.log(brand);
        const model = Object.keys(carRegisterObj[brand]);

        for (let item in model) {
            console.log(`###${model[item]} -> ${carRegisterObj[brand][model[item]]}`);
        }
    }
}

autoEngineeringCompany([
    'Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
]);