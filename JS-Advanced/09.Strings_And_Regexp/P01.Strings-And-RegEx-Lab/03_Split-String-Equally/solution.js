function splitStringEqually() {
    let text = document.getElementById('text').value;
    let partSize = +document.getElementById('number').value;

    if (text.length % partSize > 0) {
        let remainder = text.length % partSize;
        let charsToFill = partSize - remainder;

        text = text + text.substr(0, charsToFill);
    }

    let result = [];

    for (let i = 0; i < text.length; i += partSize) {
        result.push(text.substr(i, partSize));
    }

    document.getElementById('result').innerHTML = result.join(' ');
}