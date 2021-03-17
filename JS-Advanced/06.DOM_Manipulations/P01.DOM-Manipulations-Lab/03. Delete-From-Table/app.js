function deleteByEmail() {
    let searchedEmail = document.getElementsByName("email")[0].value;
    let tds = document.querySelectorAll("table tr td:nth-child(2)");
    let isFound = false;

    for (let td of tds) {
        if (td.textContent === searchedEmail) {
            td.parentNode.parentNode.removeChild(td.parentNode);
            isFound = true;
        }
    }

    document.getElementById("result").textContent = isFound ? "Deleted." : "Not found.";
    document.getElementsByName("email")[0].value = "";
}