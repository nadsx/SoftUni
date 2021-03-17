const baseUrl = `https://judgetests.firebaseio.com/`;

export function fetchRequest() {
    return {
        locationInfo: () => fetch(`${baseUrl}locations.json`).then(response => response.json()),
        currentDay: (code) => fetch(`${baseUrl}forecast/today/${code}.json`).then(response => response.json()),
        upcomingDay: (code) => fetch(`${baseUrl}forecast/upcoming/${code}.json`).then(response => response.json())
    };
}