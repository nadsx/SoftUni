function solve() {
    const correctAnswers = ["onclick", "JSON.stringify()", "A programming API for HTML and XML documents"];
    let count = 0;
    let index = 0

    Array.from(document.querySelectorAll(".answer-text"))
        .map((answer) => answer.addEventListener("click", function (currentAnswer) {
            if (correctAnswers.includes(currentAnswer.target.textContent)) {
                count++;
            }

            let currentSection = document.querySelectorAll("section")[index];
            currentSection.style.display = "none";

            if (document.querySelectorAll("section")[index + 1] !== undefined) {
                let nextSection = document.querySelectorAll("section")[index + 1];
                nextSection.style.display = "block";
                index++;
            } else {
                document.getElementById("results").style.display = "block";
                const result = document.getElementsByClassName("results-inner")[0].children[0];

                if (count != 3) {
                    result.textContent = `You have ${count} right answers`;
                } else {
                    result.textContent = `You are recognized as top JavaScript fan!`;

                }
            }
        }));
}