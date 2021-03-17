function focus() {
    const inputElements = document.getElementsByTagName("input");

    Array.from(inputElements).forEach(currentInputField => {
        //event occurs when an element gets focus.
        currentInputField.addEventListener("focus", highlight);
        //event occurs when an object loses focus.
        currentInputField.addEventListener("blur", unlit);
    });

    function highlight() {
        this.parentNode.className = "focused";
    }

    function unlit() {
        this.parentNode.removeAttribute("class");
    }
}