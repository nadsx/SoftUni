function stopwatch() {
    let startButton = document.getElementById("startBtn");
    startButton.addEventListener("click", start);

    let stopButton = document.getElementById("stopBtn");
    stopButton.addEventListener("click", stop);

    let timeBox = document.getElementById("time");

    //Return Value:	A Number, representing the ID value of the timer that is set. 
    //Use this value with the clearTimeout() method to cancel the timer
    let timer = null;

    function stop() {
        startButton.disabled = false;
        stopButton.disabled = true;

        //Will be able to stop the execution by calling the clearInterval() method.
        clearInterval(timer);
    }

    function start() {
        startButton.disabled = true;
        stopButton.disabled = false;

        timeBox.textContent = "00:00";

        //Display the current time (the setInterval() method will execute the 
        //function once every 1 second, just like a digital watch)
        //setInterval(function, milliseconds, param1, param2, ...)
        //1000 ms = 1 second.
        let seconds = 0;
        timer = setInterval(tick, 1000);

        function tick() {
            seconds++;

            let currentMinutes = ("0" + Math.floor(seconds / 60)).slice(-2);
            let currentSeconds = ("0" + seconds % 60).slice(-2);

            timeBox.textContent = `${currentMinutes}:${currentSeconds}`;
        }
    }
}