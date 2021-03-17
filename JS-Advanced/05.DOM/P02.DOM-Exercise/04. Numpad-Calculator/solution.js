function solve() {
  const expressionOperators = ['+', '-', '*', '/'];

  const buttons = document.getElementsByClassName("keys")[0].children;
  const expressionOutput = document.getElementById("expressionOutput");
  const resultOutput = document.getElementById("resultOutput");
  const clearButton = document.getElementsByClassName("clear")[0];

  Array.from(buttons).map(button => button.addEventListener("click", (currentButton) => {
    const value = currentButton.target.value;

    let separator = "";

    if (expressionOperators.some(el => el === value)) {
      separator = " ";
    }

    if (value === '=') {
      const resultExpression = calculateExpression();
      resultOutput.textContent = resultExpression;
    } else {
      expressionOutput.textContent += `${separator}${value}${separator}`;
    }
  }));

  function calculateExpression() {
    const items = expressionOutput.textContent.split(" ").filter(x => x !== "");
    const firstNumber = +items[0];
    const operator = items[1];
    const secondNumber = +items[2];

    const expressObj = {
      '+': firstNumber + secondNumber,
      '-': firstNumber - secondNumber,
      '*': firstNumber * secondNumber,
      '/': firstNumber / secondNumber
    };

    let result = expressObj[operator];
    return result;
  }

  clearButton.addEventListener("click", () => {
    expressionOutput.textContent = "";
    resultOutput.textContent = "";
  });
}