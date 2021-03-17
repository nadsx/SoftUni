function addItem() {
    const ul = document.getElementById("items");
    const input = document.getElementById("newText").value;

    const li = document.createElement("li");
    li.textContent = input;

    //Create a link:
    //<a href="#">[Delete]</a>
    const deleteLink = document.createElement("a");
    deleteLink.textContent = "[Delete]";
    deleteLink.href = "#";

    deleteLink.addEventListener("click", function (e) {
        e.preventDefault();

        this.parentNode.parentNode.removeChild(this.parentNode);
    });

    li.appendChild(deleteLink);
    ul.appendChild(li);

    document.getElementById("newText").value = "";
}