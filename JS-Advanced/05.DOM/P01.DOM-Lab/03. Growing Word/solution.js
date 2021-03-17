function growingWord() {
  let paragraph = document.getElementsByTagName("p")[2];

  let currentSize = Number(paragraph.style.fontSize.slice(0, -2)) === 0 ? 1 : paragraph.style.fontSize.slice(0, -2);
  paragraph.style.fontSize = `${currentSize * 2}px`;

  let colors = ["blue", "green", "red"];
  let counter = colors.indexOf(paragraph.style.color);

  paragraph.style.color = colors[++counter % 3];
}