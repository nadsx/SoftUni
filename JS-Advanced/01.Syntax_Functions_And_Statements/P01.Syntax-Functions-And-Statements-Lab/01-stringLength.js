function calculateStringsLength(firstArgument, secondArgument, thirdArgument) {
    let totalLength = firstArgument.length + secondArgument.length + thirdArgument.length;

    let averageLength = Math.floor(totalLength / 3);

    console.log(totalLength);
    console.log(averageLength);
}

calculateStringsLength('chocolate', 'ice cream', 'cake');
calculateStringsLength('pasta', '5', '22.3');