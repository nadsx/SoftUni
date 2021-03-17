function solve() {
    let inputElements = document.querySelectorAll("tbody td input");
    let quickCheckButton = document.getElementsByTagName("button")[0];
    let clearButton = document.getElementsByTagName("button")[1];
    let tableElement = document.getElementsByTagName("table")[0];
    let checkElement = document.querySelector("#check p");

    quickCheckButton.addEventListener("click", checker);
    clearButton.addEventListener("click", clear);

    function checker() {
        let keyNumber = Math.sqrt(inputElements.length);

        for (let row = 0; row < inputElements.length; row += keyNumber) {
            let uniqueRowNumbers = new Set();

            for (let col = 0; col < keyNumber; col++) {
                uniqueRowNumbers.add(inputElements[row + col].value);
            }

            //uniqueRowNumbers.delete("");
            rowAndColChecker(uniqueRowNumbers);
        }

        for (let firstRow = 0; firstRow < keyNumber; firstRow++) {
            let uniqueColNumbers = new Set();

            for (let col = 0; col < inputElements.length; col += keyNumber) {
                uniqueColNumbers.add(inputElements[firstRow + col].value);
            }

            //uniqueColNumbers.delete("");
            rowAndColChecker(uniqueColNumbers);
        }

        function rowAndColChecker(uniqueNumbers) {
            if (uniqueNumbers.size !== keyNumber) {
                tableElement.style.border = "2px solid red";
                checkElement.style.color = "red";
                checkElement.textContent = "NOP! You are not done yet...";
            }
        }

        if (!checkElement.textContent) {
            tableElement.style.border = "2px solid green";
            checkElement.style.color = "green";
            checkElement.textContent = "You solve it! Congratulations!";
        }
    }

    function clear() {
        for (let el = 0; el < inputElements.length; el++) {
            inputElements[el].value = "";
        }

        tableElement.style.border = "";
        checkElement.style.color = "";
        checkElement.textContent = "";
    }
}