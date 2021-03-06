function solve() {
    const button = document.querySelector("button");
    const list = document.querySelectorAll("li");

    button.addEventListener("click", () => {
        const username = document.querySelector("input").value;
        const firstLetter = username[0].toUpperCase();
        const index = firstLetter.charCodeAt() - 65;
        const name = `${firstLetter}${username.substring(1).toLowerCase()}`;

        if (list[index].textContent === "") {
            list[index].textContent = name;
        } else {
            list[index].textContent += `, ${name}`;
        }

        document.getElementsByTagName("input")[0].value = "";
    });
}