function loadRepos() {
	const repositories = document.getElementById("repos");
	const username = document.getElementById("username").value;
	
	repositories.innerHTML = "";
	const link = `https://api.github.com/users/${username}/repos`;

	fetch(link)
		.then((resources) => resources.json())
		.then((data) => {
			data.forEach(item => {
				const li = document.createElement("li");
				const link = document.createElement("a");

				link.href = item.html_url;
				link.textContent = item.full_name;
				li.appendChild(link);
				repositories.appendChild(li);
			});
		})
		.catch();
}