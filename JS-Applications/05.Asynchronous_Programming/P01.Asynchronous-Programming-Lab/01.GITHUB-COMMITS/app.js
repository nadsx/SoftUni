async function loadCommits() {
    const username = document.getElementById('username').value;
    const repository = document.getElementById('repo').value;
    const commits = document.getElementById('commits');
    commits.innerHTML = '';

    const url = `https://api.github.com/repos/${username}/${repository}/commits`;

    try {
        await fetch(url)
            .then(response => {
                if (!response.ok) {
                    throw new Error(JSON.stringify({
                        status: response.status,
                        statusText: response.statusText
                    }));
                }

                return response.json();
            })
            .then(data => {
                Object.entries(data)
                    .forEach(([_, data]) => {
                        const authorName = data.commit.author.name;
                        const message = data.commit.message;

                        const li = document.createElement('li');
                        li.textContent = `${authorName}: ${message}`;

                        commits.appendChild(li);
                    });
            });
    } catch (errorData) {
        const error = JSON.parse(errorData.message);
        const li = document.createElement('li');

        li.textContent = `Error: ${error.status} (${error.statusText})`;
        commits.appendChild(li);
    }
}