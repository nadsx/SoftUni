function solve(array) {

    let number = +array.shift();

	// Parentheses are optional when there's 
	//only one parameter name: (singleParam) => { statements }
	
    let operations = {
        chop: (x) => {  
            return (x / 2);
        },
        dice: (x) => {
            return (Math.sqrt(x));
        },
        spice: (x) => {
            return ++x;
        },
        bake: x => {
            return x *= 3;
        },
        fillet: x => {
            return x *= 0.8;
        }
    };

    for (let index = 0; index < array.length; index++) {
        number = operations[array[index]](number);
        console.log(number);
    }
}

solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);
solve(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);