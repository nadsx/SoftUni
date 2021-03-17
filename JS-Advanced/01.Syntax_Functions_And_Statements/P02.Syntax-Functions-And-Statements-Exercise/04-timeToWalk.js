function solve(arg1, arg2, arg3) {

    let stepsNumber = Number(arg1);
    let stepsMetersHr = Number(arg2);
    let studentSpeed = Number(arg3);
	
    let distanceMeters = stepsNumber * stepsMetersHr; // km/h -> m/s ( /3.6 ); m/s -> km/h ( x3.6 );
    let speedMetersSec = studentSpeed / 3.6; // (1 hour = 3600 seconds, 1km = 1000m) km/h => m/s => 1000/3600(1 x 1000/3600) = 1/3.6! m/s
    let time = distanceMeters / speedMetersSec; // distance = speed x time => time = distance/speed
    let rest = Math.floor(distanceMeters / 500);

    let timeMin = Math.floor(time / 60);
    let timeSec = Math.round(time - (timeMin * 60));
    let timeHr = Math.floor(time / 3600);

    console.log((timeHr < 10 ? "0" : "") + timeHr + ":" + (timeMin + rest < 10 ? "0" : "") + (timeMin + rest) + ":" + (timeSec < 10 ? "0" : "") + timeSec);
}

solve(4000, 0.60, 5);
solve(2564, 0.70, 5.5);