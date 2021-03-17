function jsonTable(arr) {
    let table = '<table>\n';

    for (let line of arr) {
        let employee = JSON.parse(line);
        employee.salary = Number(employee.salary);
        let keys = Object.keys(employee);
        table += '\t<tr>\n';

        for (let key of keys) {
            table += `\t\t<td>${htmlEscape(employee[key])}</td>\n`;
        }

        table += '\t</tr>\n';
    }
    table += '</table>';
    console.log(table);

    function htmlEscape(text) {
        text = '' + text;
        return text.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
}

jsonTable([
    '{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}',
    '{"name":"Georgi","position":"Lecturer","salary":1000}'
]);

// function jsonTable(input) {
//     let editItem = str => str
//         .replace(/&/g, '&amp;')
//         .replace(/</g, '&lt;')
//         .replace(/>/g, '&gt;')
//         .replace(/"/g, '&quot;')
//         .replace(/'/g, '&#39;');

//     let result = "";

//     result += "<table>\n";

//     for (const item of input) {
//         let json = JSON.parse(item);

//         result += "\t<tr>\n";
//         result += `\t\t<td>${editItem(json.name)}</td>\n`;
//         result += `\t\t<td>${editItem(json.position)}</td>\n`;
//         result += `\t\t<td>${json.salary}</td>\n`;
//         result += "\t</tr>\n";
//     }

//     result += "</table>";

//     console.log(result);
// }