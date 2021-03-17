function convertBinary() {
	let input = document.getElementById('input').value;
	let result = document.getElementById('resultOutput');

	let sum = getSum(input);

	function getSum(input) {
		let sum = 0;
		let result = input;

		while (result.length > 1) {
			for (let num of result) {
				sum += +num;
			}

			result = sum.toString();
			sum = 0;
		}

		return +result;

	}

	let slicedText = input.slice(sum, input.length - sum);

	function convertToChar(binary) {
		let decimal = parseInt(binary, 2);
		let char = String.fromCharCode(decimal);

		return char;
	}

	let output = slicedText
		.split(/([\d]{8})/g)
		.map(el => convertToChar(el))
		.filter(el => /[A-Za-z ]+/g.test(el))
		.join('');

	result.textContent = output;
}