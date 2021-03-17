function attachEvents() {
    const phonebookData = document.getElementById('phonebook');
    const createButton = document.getElementById('btnCreate');
    const loadButton = document.getElementById('btnLoad');

    createButton.addEventListener('click', createPhone);
    loadButton.addEventListener('click', loadPhonebook);

    const url = "https://phonebook-nakov.firebaseio.com/phonebook.json";

    function createPhone() {
        const person = document.getElementById('person').value;
        const phone = document.getElementById('phone').value;
        const headers = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                person,
                phone
            })
        };

        fetch(url, headers)
            .then(() => {
                document.getElementById('person').value = '';
                document.getElementById('phone').value = '';

                loadPhonebook();
            })
            .catch(() => console.log('Error'));
    }

    function loadPhonebook() {
        fetch(url)
            .then(resources => resources.json())
            .then(data => {
                phonebookData.innerHTML = '';

                Object.entries(data).forEach(([elementId, phonebook]) => {
                    const {
                        person,
                        phone
                    } = phonebook;

                    const li = document.createElement('li');
                    li.textContent = `${person}: ${phone}`;

                    const deleteButton = document.createElement('button');
                    deleteButton.textContent = 'Delete';
                    deleteButton.id = elementId;
                    deleteButton.addEventListener('click', deletePhone);
                    li.appendChild(deleteButton);
                    phonebookData.appendChild(li);
                });
            })
            .catch(() => console.log('Error'));
    }

    function deletePhone() {
        const id = this.getAttribute('id');

        fetch(`https://phonebook-nakov.firebaseio.com/phonebook/${id}.json`, {
                method: 'DELETE'
            })
            .then(() => {
                loadPhonebook();
            })
            .catch(() => console.log('Error'));
    }
}

attachEvents();