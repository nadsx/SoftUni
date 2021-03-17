function validate() {
    let inputField = document.getElementById("email");
    // event occurs when the value of an element has been changed
    inputField.addEventListener("change", performValidation);
    let pattern = /^[a-z]+@[a-z]+\.[a-z]+$/;

    function performValidation() {
        let email = this.value;

        if (pattern.test(email)) {
            this.classList.remove("error");
        } else {
            this.classList.add("error");
        }
    }
}