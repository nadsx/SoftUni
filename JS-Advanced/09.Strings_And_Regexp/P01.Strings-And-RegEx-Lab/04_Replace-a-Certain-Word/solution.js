function replaceACertainWord() {
    const word = document.getElementById('word').value;
    let text = JSON.parse(document.getElementById('text').value);
    let result = document.getElementById('result');

    const wordToReplacePattern = new RegExp(text[0].split(' ')[2], 'gi');
    text = text.map(w => w.replace(wordToReplacePattern, word));

    for (const sentence of text) {
        const p = document.createElement('p');
        p.innerHTML = sentence;
        result.appendChild(p);
    }
}