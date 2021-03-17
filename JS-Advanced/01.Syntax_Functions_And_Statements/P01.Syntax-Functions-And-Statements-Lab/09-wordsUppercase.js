function convertToUpperCase(input) {
    //let words = text.toUpperCase().split(/\W+/).filter(w => w != "");
    //console.log(words.join(", "));
    input = input.replace(/(,|\?|!|\ )/gm, ' '); // gm => Do a global, multiline search;
    let words = input.split(/\W+/);

    words = words.filter(w => w != '').join(', ');
    let result = words.toUpperCase();

    return result;
}

console.log(convertToUpperCase('Hi, how are you?'));
console.log(convertToUpperCase('hello'));