function extractUserData() {
    const users = JSON.parse(document.getElementById('arr').value);
    let result = document.getElementById('result');

    const extractName = (userData) => {
        const pattern = /^[A-Z][a-z]* [A-Z][a-z]*/;
        const match = userData.match(pattern);

        return match && match[0];
    };

    const extractPhoneNumber = (userData) => {
        const pattern = /(\+359 \d \d{3} \d{3})|(\+359-\d-\d{3}-\d{3})/;
        const match = userData.match(pattern);

        return match && match[0];
    };

    const extractEmail = (userData) => {
        const pattern = / [a-z0-9]+@[a-z]+\.[a-z]{2,3}$/;
        const match = userData.match(pattern);

        return match && match[0];
    };

    users.forEach(userData => {
        const name = extractName(userData);
        const phoneNumber = extractPhoneNumber(userData);
        const email = extractEmail(userData);

        if (!name || !phoneNumber || !email) {
            let p1 = document.createElement('p');
            p1.textContent = 'Invalid data';
            result.appendChild(p1);

            let p2 = document.createElement('p');
            p2.textContent = '- - -';
            result.appendChild(p2);

            return;
        }

        let pName = document.createElement('p');
        pName.textContent = 'Name: ' + name;
        result.appendChild(pName);

        let pPhone = document.createElement('p');
        pPhone.textContent = 'Phone Number: ' + phoneNumber;
        result.appendChild(pPhone);

        let pEmail = document.createElement('p');
        pEmail.textContent = 'Email:' + email;
        result.appendChild(pEmail);

        let p = document.createElement('p');
        p.textContent = '- - -';
        result.appendChild(p);
    });
}