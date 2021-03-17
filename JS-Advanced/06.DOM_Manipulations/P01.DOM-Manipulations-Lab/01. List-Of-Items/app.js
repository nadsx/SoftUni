function addItem() {
    const ul = document.getElementById("items");
    const input = document.getElementById("newItemText").value;

    const li = document.createElement("li");
    li.textContent = input;
    ul.appendChild(li);

    document.getElementById("newItemText").value = "";
}