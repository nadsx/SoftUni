function attachEvents() {
    const messagesData = document.getElementById('messages');
    const sendButton = document.getElementById('submit');
    const refreshButton = document.getElementById('refresh');

    const url = "https://rest-messanger.firebaseio.com/messanger.json";

    sendButton.addEventListener('click', submitMessage);
    refreshButton.addEventListener('click', refreshMessages);

    function refreshMessages() {
        fetch(url)
            .then(resources => resources.json())
            .then(data => {
                messagesData.textContent = '';

                Object.entries(data)
                    .forEach(([_, message]) => {
                        const {
                            author,
                            content
                        } = message;

                        messagesData.textContent += `${author}: ${content}\n`;
                    });
            })
            .catch(() => console.log('Error!!!'));
    }

    function submitMessage() {
        const author = document.getElementById('author').value;
        const content = document.getElementById('content').value;
        const headers = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                author,
                content
            })
        };

        fetch(url, headers)
            .then(() => {
                document.getElementById('author').value = '';
                document.getElementById('content').value = '';

                refreshMessages();
            })
            .catch(() => console.log('Error!!!'));
    }
}

attachEvents();