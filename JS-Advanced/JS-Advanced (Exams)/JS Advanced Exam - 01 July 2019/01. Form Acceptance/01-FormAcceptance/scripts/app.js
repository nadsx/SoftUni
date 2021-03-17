function acceptance() {
    const button = document.getElementById('acceptance');
    const warehouse = document.getElementById('warehouse');
    const inputFields = document.getElementsByTagName('input');

    button.addEventListener('click', function (e) {
        e.preventDefault();

        const company = document.getElementsByTagName('input')[0].value;
        const product = document.getElementsByTagName('input')[1].value;
        const quantity = Number(document.getElementsByTagName('input')[2].value);
        const scrape = Number(document.getElementsByTagName('input')[3].value);

        if (company !== '' && product !== '' && quantity !== NaN && scrape !== NaN && quantity - scrape > 0) {
            const div = document.createElement('div');
            const p = document.createElement('p');
            const removeButton = document.createElement('button');
            removeButton.type = 'button';

            p.textContent = `[${company}] ${product} - ${quantity - scrape} pieces`;
            removeButton.textContent = 'Out of stock';

            div.appendChild(p);
            div.appendChild(removeButton);
            warehouse.appendChild(div);

            removeButton.addEventListener('click', function (e) {
                e.preventDefault();

                warehouse.removeChild(div);
            });
        }

        for (const input of inputFields) {
            input.value = '';
        }
    });
}