function usernames(arr) {
    let usernames = new Set();

    arr.forEach(username => usernames.add(username));

    [...usernames].sort(sortUsernames)
        .forEach(username => console.log(username));

    function sortUsernames(a, b) {
        if (a.length != b.length) {
            return a.length - b.length;
        }

        return a.localeCompare(b);
    }
}

usernames([
    'Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston'
]);

usernames([
    'Denise',
    'Ignatius',
    'Iris',
    'Isacc',
    'Indie',
    'Dean',
    'Donatello',
    'Enfuego',
    'Benjamin',
    'Biser',
    'Bounty',
    'Renard',
    'Rot'
]);