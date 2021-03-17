function scoreToHTML(input) {
    let townsObj = {};

    for (const line of input) {
        let [town, product, salesData] = line.split(" -> ");
        let [sales, unitPrice] = salesData.split(" : ").map(x => Number(x));

        if (!townsObj.hasOwnProperty(town)) {
            townsObj[town] = {};
        }

        if (!townsObj[town].hasOwnProperty(product)) {
            townsObj[town][product] = 0;
        }

        townsObj[town][product] += sales * unitPrice;
    }

    let result = "";

    for (const townName in townsObj) {
        const productTotalIncome = townsObj[townName];

        result += `Town - ${townName}\n`;

        for (const item in productTotalIncome) {
            result += `$$$${item} : ${productTotalIncome[item]}\n`;
        }
    }

    console.log(result);
}

// The Object class represents one of JavaScript's data types. 
// It is used to store various keyed collections and more complex entities. 
// Objects can be created using the Object() constructor or the object initializer / literal syntax.

scoreToHTML(['Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3'
]);

//---------------------------------

// function cityMarkets(input) {
//     let townSales = new Map(); 

//     for (let line of input) {
//         let [town, product, salesData] = line.split(/\s+->\s+/);
//         let [sales, unitPrice] = salesData.split(/\s+:\s+/).map(Number);

//         if (!townSales.has(town)){
//             townSales.set(town, new Map());
//         }

//         let productRevenue = sales * unitPrice;

//         // if (townSales.get(town).has(product)){
//         //     productRevenue += townSales.get(town).get(product);
//         // }

//         townSales.get(town).set(product, productRevenue);
//     }

//     for (let [town, townProducts] of townSales) {
//         console.log(`Town - ${town}`);

//         for (let [product, productRevenue] of townProducts){
//             console.log(`$$$${product} : ${productRevenue}`);
//         }
//     }
// }