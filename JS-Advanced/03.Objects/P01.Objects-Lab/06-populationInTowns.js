function populationInTowns(input) {
    let townsObj = {};

    for (let line of input) {
        let elements = line.split(" <-> ");
        let town = elements[0];
        let population = Number(elements[1]);

        if (!townsObj.hasOwnProperty(town)) {
            townsObj[town] = 0;
        }

        townsObj[town] += population;
    }

    for (let item in townsObj) {
        console.log(`${item} : ${townsObj[item]}`);
    }
}

populationInTowns([
    'Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000'
]);

populationInTowns([
    'Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000'
]);


// ---------------------------------

// function populationInTowns(arr) {
//     let populationByTown = new Map();

//     arr.forEach(line => {
//         let [town, population] = line.split(/\s+<->\s+/);
//         population = Number(population);

//         if (!populationByTown.has(town)){
//             populationByTown.set(town, population);
//         } else{
//             //If you receive the same town twice, you should add the given population to the current one.
//             populationByTown.set(town, populationByTown.get(town) + population);    
//         }
//     });

//     for (let [town, population] of populationByTown){
//         console.log(`${town} : ${population}`);
//     }
// }