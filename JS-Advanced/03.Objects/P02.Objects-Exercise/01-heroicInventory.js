function heroicInventory(input) {
    let heroData = [];

    for (let key of input) {
        let items = key.split(" / ");
        let heroName = items[0];
        let heroLevel = Number(items[1]);
        let heroItems = [];

        if (items.length > 2) {
            heroItems = items[2].split(", ");
        }

        let hero = {
            name: heroName,
            level: heroLevel,
            items: heroItems
        };

        heroData.push(hero);
    }

    console.log(JSON.stringify(heroData));
}

heroicInventory([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]);

heroicInventory([
    'Jake / 1000 / Gauss, HolidayGrenade'
]);