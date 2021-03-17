const baseUrl = `https://fisher-game.firebaseio.com/`;

export function fetchData() {
    return {
        loadData: () => fetch(`${baseUrl}catches.json`).then(response => response.json()),
        addCatch: (init) => fetch(`${baseUrl}catches.json`, init),
        updateCatch: (id, init) => fetch(`${baseUrl}catches/${id}.json`, init),
        deleteCatchesElement: (id, init) => fetch(`${baseUrl}catches/${id}.json`, init)
    };
}