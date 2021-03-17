function solve(arr) {

    let [x1, y1, x2, y2] = arr;
    let isValidFirstPoint = false;
    let isValidSecondPoint = false;
    let isValidTwoPoint = false;

    let distanceFirstPointToOrigin = Math.sqrt(Math.pow(x1, 2) + Math.pow(y1, 2));
    let distanceSecondPointToOrigin = Math.sqrt(Math.pow(x2, 2) + Math.pow(y2, 2));
    let distancePoints = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));

    if (distanceFirstPointToOrigin % 1 === 0) { // A distance between two points is considered valid, if it is an integer value. 
        isValidFirstPoint = true;
    }
	
    if (distanceSecondPointToOrigin % 1 === 0) {
        isValidSecondPoint = true;
    }
	
    if (distancePoints % 1 === 0) {
        isValidTwoPoint = true;
    }

    console.log(`{${x1}, ${y1}} to {0, 0} is ${isValidFirstPoint ? "valid" : "invalid"}`);
    console.log(`{${x2}, ${y2}} to {0, 0} is ${isValidSecondPoint ? "valid" : "invalid"}`);
    console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${isValidTwoPoint ? "valid" : "invalid"}`);
}

solve([3, 0, 0, 4]);
solve([2, 1, 1, 1]);