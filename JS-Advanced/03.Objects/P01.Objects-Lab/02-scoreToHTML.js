function scoreToHTML(json) {
    let table = "<table>\n";
    table += "  <tr><th>name</th><th>score</th></tr>\n";
    let text = JSON.parse(json);

    for (let index in text) {
        let name = text[index].name
            .replace(/&/gim, '&amp;')
            .replace(/</gim, '&lt;')
            .replace(/>/gim, '&gt;')
            .replace(/"/gim, '&quot;')
            .replace(/'/gim, '&#39;');

        let score = Number(text[index].score);

        table += `  <tr><td>${name}</td><td>${score}</td></tr>\n`;
    }

    table += "</table>";

    return table;
}

console.log(scoreToHTML(['[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]']));
console.log(scoreToHTML(['[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]']));