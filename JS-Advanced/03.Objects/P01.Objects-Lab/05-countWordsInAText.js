function countWordsInAText(arr) {
    let words = arr[0].match(/\w+/gim);
    let obj = {};

    for (let word of words) {

        if (!obj.hasOwnProperty(word)) {
            obj[word] = 0;
        }

        obj[word]++;
    }

    return JSON.stringify(obj);
}

console.log(countWordsInAText(["Far too slow, you're far too slow."]));
console.log(countWordsInAText(["JS devs use Node.js for server-side JS.-- JS for devs"]));

//---------------------------------

// function countWordsInText([arr]) {
//     let words = arr.split(/\W+/g).filter(x => x != "");
//     let countWords = {};

//     for (let word of words) {
//         countWords[word] ? countWords[word]++ : countWords[word] = 1;
//     }

//     console.log(JSON.stringify(countWords));
// }