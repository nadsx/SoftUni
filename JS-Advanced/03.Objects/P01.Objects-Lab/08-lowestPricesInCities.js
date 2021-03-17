function lowestPricesInCities(arr) {
    let productPrices = new Map();

    for (let line of arr) {
        let [town, product, price] = line.split(/\s+\|\s+/);

        if (!productPrices.has(product)) {
            productPrices.set(product, new Map());
        }

        productPrices.get(product).set(town, Number(price));
    }

    for (let [product, townPrices] of productPrices) {
        let minPrice = Number.MAX_VALUE;
        let minPriceTown = "";

        for (let [town, price] of townPrices) {

            if (price < minPrice) {
                minPrice = price;
                minPriceTown = town;
            }
        }

        console.log(`${product} -> ${minPrice} (${minPriceTown})`);
    }
}

// Map => The Map object holds key-value pairs 
//and remembers the original insertion order of the keys. 
//Any value (both objects and primitive values) may be used as either a key or a value.

lowestPricesInCities(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10'
]);