class ChristmasDinner {
    constructor(budget) {
        this.budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }

    get budget() {
        return this._budget;
    }
    set budget(budget) {
        if (budget < 0) {
            throw new Error('The budget cannot be a negative number');
        }

        this._budget = budget;
    }

    shopping([...product]) {
        const name = product[0];
        const price = Number(product[1]);

        if (price > this.budget) {
            throw new Error('Not enough money to buy this product');
        }

        this.budget -= price;
        this.products.push(name);

        return `You have successfully bought ${name}!`;
    }

    recipes(recipe) {
        const recipeName = recipe['recipeName'];
        const productsList = recipe['productsList'];

        let productsExists = productsList.every(value => this.products.includes(value));

        if (!productsExists) {
            throw new Error('We do not have this product');
        }

        const dish = {
            recipeName,
            productsList
        };

        this.dishes.push(dish);

        return `${recipeName} has been successfully cooked!`;
    }

    inviteGuests(name, dish) {
        const targetDish = this.dishes.find(d => d.recipeName === dish);

        if (!targetDish) {
            throw new Error('We do not have this dish');
        }

        if (this.guests[name]) {
            throw new Error('This guest has already been invited');
        }

        this.guests[`${name}`] = dish;

        return `You have successfully invited ${name}!`;
    }

    showAttendance() {
        let result = '';

        for (const name in this.guests) {
            const targetDish = this.dishes.find(d => d.recipeName === this.guests[name]);
            result += `${name} will eat ${this.guests[name]}, which consists of ${targetDish.productsList.join(', ')}\n`;
        }

        return result.trim();
    }
}

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());