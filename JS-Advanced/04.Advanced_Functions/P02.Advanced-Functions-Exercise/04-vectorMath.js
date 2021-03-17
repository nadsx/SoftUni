vectorMath = (function () {
    return { // in arrow func => there is return!
        add: (vec1, vec2) => [vec1[0] + vec2[0], vec1[1] + vec2[1]],
        multiply: (vec1, num) => [vec1[0] * num, vec1[1] * num],
        length: (vec1) => Math.sqrt(vec1[0] * vec1[0] + vec1[1] * vec1[1]),
        dot: (vec1, vec2) => vec1[0] * vec2[0] + vec1[1] * vec2[1],
        cross: (vec1, vec2) => vec1[0] * vec2[1] - vec1[1] * vec2[0]
    };
})();

var vectorMath; //!! <= For JUDGE SYSTEM, variable declaration is here!
console.log(vectorMath.add([1, 1], [1, 0]));
console.log(vectorMath.multiply([3.5, -2], 2));
console.log(vectorMath.length([3, -4]));
console.log(vectorMath.dot([1, 0], [0, -1]));
console.log(vectorMath.cross([3, 7], [1, 0]));