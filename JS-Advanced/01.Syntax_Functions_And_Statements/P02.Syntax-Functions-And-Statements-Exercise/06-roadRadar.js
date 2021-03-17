function solve(inputArr) {

    function checkLimit(area) {
        switch (area) {
            case 'motorway':
                return 130;
            case 'interstate':
                return 90;
            case 'city':
                return 50;
            case 'residential':
                return 20;
        }
    }

    let result = '';
    let [speed, area] = inputArr;

    let speedLimit = checkLimit(area);
    let overLimit = speed - speedLimit;

    if (overLimit > 0) {
        if (overLimit <= 20) {
            result = 'speeding';
        } else if (overLimit <= 40) {
            result = 'excessive speeding';
        } else {
            result = 'reckless driving';
        }
    }

    console.log(result);
}

solve([40, 'city']);
solve([21, 'residential']);
solve([120, 'interstate']);
solve([200, 'motorway']);