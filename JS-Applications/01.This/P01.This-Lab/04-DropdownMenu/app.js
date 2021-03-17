function solve() {
    const dropDownMenu = document.getElementById("dropdown-ul");
    const button = document.getElementById("dropdown");
    const elements = document.querySelectorAll("#dropdown-ul > li");
    const box = document.getElementById("box");

    button.addEventListener("click", function (e) {
        e.preventDefault();

        if (dropDownMenu.style.display === "none" || dropDownMenu.style.display === "") {
            dropDownMenu.style.display = "block";

            for (const element of elements) {
                element.addEventListener("click", function (e) {
                    e.preventDefault();

                    const text = element.textContent;
                    box.style.backgroundColor = text;
                    box.style.color = "black";
                });
            }
        } else {
            dropDownMenu.style.display = "none";
            box.style.backgroundColor = "black";
            box.style.color = "white";
        }
    });
}

//preventDefault();
//For example, when dealing with links (anchor elements), 
//the default behaviour would be to redirect to the URL, 
//but with preventDefault() we are able to prevent this from happening.