function composeObjects(input) {
    return JSON.parse(input)
        .reduce((acc, curr) => Object.assign(acc, curr), {});
}

console.log(composeObjects(`[{"canMove": true},{"canMove":true, "doors": 4},{"capacity": 5}]`));
console.log(composeObjects(`[{"canFly": true},{"canMove":true, "doors": 4},{"capacity": 255},{"canFly":true, "canLand": true}]`));