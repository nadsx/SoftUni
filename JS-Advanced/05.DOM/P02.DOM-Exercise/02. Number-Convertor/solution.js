function solve() {
    const button = document.querySelector("button");
    const selectMenuTo = document.getElementById("selectMenuTo");
    const numberForm = document.getElementById("input");
    const outputForm = document.getElementById("result");

    let binary = document.createElement("option");
    binary.textContent = "Binary";
    binary.value = "binary";
    selectMenuTo.add(binary);

    let hexadecimal = document.createElement("option");
    hexadecimal.textContent = "Hexadecimal";
    hexadecimal.value = "hexadecimal";
    selectMenuTo.add(hexadecimal);

    button.addEventListener("click", () => {
        let convertTo = selectMenuTo.value;
        let number = numberForm.value;

        if (convertTo === "binary") {
            outputForm.value = Number(number).toString(2);
        } else if (convertTo === "hexadecimal") {
            outputForm.value = Number(number).toString(16).toUpperCase();
        }
    });
}