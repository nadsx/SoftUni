function findAsciiEquivalent() {
  let input = document.getElementById('text').value;
  let result = document.getElementById('result');

  let elements = input.split(' ').filter(x => x !== '');
  let output = '';

  for (let element of elements) {
    if (Number(element)) {
      output += (String.fromCharCode(element));
    } else {
      let charToNum = [];

      for (let i = 0; i < element.length; i++) {
        charToNum.push(element.charCodeAt(i));
      }

      let p = document.createElement('p');
      p.innerHTML = charToNum.join(' ');
      result.appendChild(p);
    }
  }

  let p = document.createElement('p');
  p.innerHTML = output;
  result.appendChild(p);
}