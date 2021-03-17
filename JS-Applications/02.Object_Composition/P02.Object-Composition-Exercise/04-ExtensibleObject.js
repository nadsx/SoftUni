function extensibleObject() {
    let obj = {
        extend: function (template) {
            Object.keys(template)
                .forEach(prop => {
                    typeof (template[prop]) == "function" ?
                    Object.getPrototypeOf(obj)[prop] = template[prop] : // obj.__proto__[key] = template[key];
                        obj[prop] = template[prop];
                });
        }
    };
    
    return obj;
}

let myObj = extensibleObject();

myObj.extend({
    fullName: function () {
        return `${this.firstName} ${this.lastName}`;
    },
    firstName: 'Logan',
    lastName: 'Paul',
});

console.log(myObj);