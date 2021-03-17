function attachGradientEvents() {
    let resultPercentage = document.getElementById("result");
    let gradientBox = document.getElementById("gradient");

    gradientBox.addEventListener("mousemove", attachPosition);
    gradientBox.addEventListener("mouseout", clearPercentage);

    function attachPosition(event) {
        let currentMouseX = event.offsetX;
        let percentage = Math.trunc(currentMouseX / event.target.clientWidth * 100);
        resultPercentage.textContent = percentage + "%";
    }

    function clearPercentage() {
        resultPercentage.textContent = "";
    }
}

//-------------------------------
//JavaScript Events:
//Often, when events happen, you may want to do something.
//JavaScript  execute code when events are detected.

//offsetX:
//Return Value:	A Number, representing 
//the horizontal coordinate of the mouse pointer, in pixels
//The offsetX property returns the x-coordinate of the mouse pointer, 
//relative to the target element.

//Element.clientWidth:
//it's the inner width of an element in pixels.

//Event.target:
//The target property of the Event interface is a reference to the object 
//onto which the event was dispatched.
//-------------------------------