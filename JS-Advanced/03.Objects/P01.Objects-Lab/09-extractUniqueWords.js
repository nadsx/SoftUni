function scoreToHTML(text) {
    let result = new Set(
        text
        .join("")
        .toLowerCase()
        .match(/\w+/gm)
    );

    console.log([...result].join(", "));
}

//-------------------------
//let myArray = ['value1', 'value2', 'value3']

// Use the regular Set constructor to transform an Array into a Set
//let mySet = new Set(myArray)

//mySet.has('value1') // returns true

// Use the spread operator to transform a set into an Array.
//console.log([...mySet]) // Will show you exactly the same Array as myArray
//-------------------------

scoreToHTML(['Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 'Pellentesque quis hendrerit dui.',
    'Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.',
    'Vestibulum dolor diam, dignissim quis varius non, fermentum non felis.',
    'Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut.',
    'Morbi in ipsum varius, pharetra diam vel, mattis arcu.',
    'Integer ac turpis commodo, varius nulla sed, elementum lectus.',
    'Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.'
]);

scoreToHTML(['Interdum et malesuada fames ac ante ipsum primis in faucibus.',
    'Vestibulum volutpat lacinia blandit.',
    'Pellentesque dignissim odio in hendrerit lacinia.',
    'Vivamus placerat porttitor purus nec hendrerit.',
    'Aliquam erat volutpat. Donec ac augue ligula.',
    'Praesent venenatis sapien vitae libero ornare, nec pulvinar velit finibus.',
    'Proin dui neque, rutrum vel dolor ut, placerat blandit sapien.',
    'Pellentesque at est arcu.',
    'Nullam eget orci laoreet, feugiat nisi vitae, egestas libero.',
    'Pellentesque pulvinar aliquet felis.',
    'Interdum et malesuada fames ac ante ipsum primis in faucibus.',
    'Etiam sit amet nisl ex.',
    'Sed lacinia pretium metus quis fermentum.',
    'Praesent a ante suscipit, efficitur risus cursus, scelerisque risus.'
]);

//---------------------------------
// function extractUniqueWords(arr) {
//     let uniqueWords = new Set();

//     for (let line of arr) {
//         let words = line.match(/\w+/gm);
//         words.forEach(word => uniqueWords.add(word.toLowerCase()));
//     }

//     console.log([...uniqueWords].join(', '));
//     // console.log(Array.from(uniqueWords).join(', '));
// }

//The Set object lets you store unique values of any type, 
//whether primitive values or object references.

//-------------------------------//

// function extractUniqueWords(arrayOfStr) {
//     let uniqueWords = [];
//     const regex = /[\s+,\.\']/gm;

//     for(let sequence of arrayOfStr) {
//         let words = sequence.split(regex).filter(el => el !== "");

//         for(let word of words) {
//             let wordToLower = word.toLowerCase();

//             if(!uniqueWords.includes(wordToLower)){
//                 uniqueWords.push(wordToLower);
//             }
//         }
//     }

//     console.log(uniqueWords.join(", "));
// }