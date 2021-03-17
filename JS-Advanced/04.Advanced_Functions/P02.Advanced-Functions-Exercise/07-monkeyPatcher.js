forum = (function () {
    let commands = {
        upvote: (post) => post.upvotes += 1,
        downvote: (post) => post.downvotes += 1,
        score: (post) => {
            let upvotes = post.upvotes;
            let downvotes = post.downvotes;
            let obfuscationNumber = 0;
            let maxVotes;

            if ((upvotes + downvotes) > 50) {
                maxVotes = Math.max(upvotes, downvotes);
                obfuscationNumber = Math.ceil(maxVotes * 0.25);
            }

            let rating = (upvotes, downvotes) => {
                let totalVotes = upvotes + downvotes;
                let balance = upvotes - downvotes;

                if (totalVotes < 10) {
                    return "new";
                }

                if ((upvotes / totalVotes) > 0.66) {
                    return "hot";
                }
                // If there is no majority from both upvotes and downvotes
                if ((downvotes / totalVotes <= 0.66) && balance >= 0 && (upvotes > 100 || downvotes > 100)) {
                    return "controversial";
                }

                if (balance < 0 && totalVotes >= 10) {
                    return "unpopular";
                }

                return "new";
            };

            let resultRating = rating(upvotes, downvotes);
            // score – report positive and negative votes, balance and rating, in an array; obfuscation rules apply
            return [upvotes + obfuscationNumber, downvotes + obfuscationNumber, upvotes - downvotes, resultRating];
        }
    };

    return {
        call: (post, action) => {
            return commands[action](post);
        }
    };
})();

let post = {
    id: '3',
    author: 'emil',
    content: 'wazaaaaa',
    upvotes: 100,
    downvotes: 100
};

var forum; //!! <= For JUDGE SYSTEM, variable declaration is here!
const solution = forum;
solution.call(post, 'upvote');
solution.call(post, 'downvote');
let score = solution.call(post, 'score');
console.log(score);

solution.call(post, 'downvote');
score = solution.call(post, 'score');
console.log(score);