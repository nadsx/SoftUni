function formatText() {
    const input = document.getElementById("input").textContent;
    const output = document.getElementById("output");

    let sentences = input.split(".").filter(s => s != "");

    if (sentences.length <= 3) {
        const p = document.createElement("p");

        for (let i = 0; i < sentences.length; i++) {
            p.textContent += sentences[i] + ".";
        }

        output.appendChild(p);
    } else {
        let p = document.createElement("p");

        for (let i = 0; i < sentences.length; i++) {
            if (i % 3 == 0) {
                p = document.createElement("p");
            }

            p.textContent += sentences[i] + ".";
            output.appendChild(p);
        }
    }
}