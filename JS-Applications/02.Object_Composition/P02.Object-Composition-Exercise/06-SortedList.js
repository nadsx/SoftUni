function myList() {
    return {
        elements: [],
        size: 0,
        add: function (element) {
            this.elements.push(element);
            this.elements.sort((a, b) => a - b);
            this.size++;
        },
        remove: function (index) {
            if (index < 0 || index >= this.elements.length) {
                throw new Error("Invalid index!");
            }

            this.elements.splice(index, 1);
            this.size--;
        },
        get: function (index) {
            if (index < 0 || index >= this.elements.length) {
                throw new Error("Invalid index!");
            }

            return this.elements[index];
        }
    };
}

let collection = myList();
collection.add(15);
collection.add(30);
collection.add(45);
collection.add(60);
collection.add(75);
collection.add(90);
console.log(collection.elements);

collection.remove(2);
console.log(collection.elements);

console.log(collection.get(2));
console.log(collection.size);