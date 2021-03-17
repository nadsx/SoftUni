class List {
    constructor() {
        this.collection = [];
        this.size = 0;
    }

    add(element) {
        this.collection.push(element);
        this.size++;
        this.collection.sort((a, b) => a - b);
    }

    remove(index) {
        if (this.isValid(index)) {
            this.collection.splice(index, 1);
            this.size--;
        }
    }

    get(index) {
        if (this.isValid(index)) {
            return this.collection[index];
        }
    }

    isValid(index) {
        return 0 <= index && index < this.collection.length;
    }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));