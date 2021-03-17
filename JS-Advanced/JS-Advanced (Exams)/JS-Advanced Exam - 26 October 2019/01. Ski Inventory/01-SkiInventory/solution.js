function solve() {
    let totalPrice = 0;

    const html = {
        availableProductsList: () => document.querySelector('#products > ul'),
        myProductsList: () => document.querySelector('#myProducts > ul'),
        addButton: () => document.querySelector('#add-new button'),
        filterButton: () => document.querySelector('#products > div > button'),
        buyButton: () => document.querySelector('#myProducts > button'),
        productFilterInput: () => document.getElementsByTagName('input')[0],
        productNameInput: () => document.querySelectorAll('#add-new input')[0],
        productQuantityInput: () => document.querySelectorAll('#add-new input')[1],
        productPriceInput: () => document.querySelectorAll('#add-new input')[2],
        totalPriceField: () => document.querySelectorAll('h1')[1]
    };

    html.addButton().addEventListener('click', addProductToList);
    html.buyButton().addEventListener('click', buyProducts);
    html.filterButton().addEventListener('click', filterProducts);

    function addProductToList(e) {
        e.preventDefault();

        const name = html.productNameInput().value;
        const quantity = Number(html.productQuantityInput().value);
        const price = Number(html.productPriceInput().value);

        const li = createDomElement('li', null, null, null);
        const spanName = createDomElement('span', name, null, null);
        const strongQuantity = createDomElement('strong', `Available: ${quantity}`, null, null);
        const divInfo = createDomElement('div', null, null, null);
        const strongPrice = createDomElement('strong', price.toFixed(2), null, null);
        const buttonAdd = createDomElement('button', "Add to Client's List");

        buttonAdd.addEventListener('click', addProductToBuy);

        divInfo.appendChild(strongPrice);
        divInfo.appendChild(buttonAdd);
        li.appendChild(spanName);
        li.appendChild(strongQuantity);
        li.appendChild(divInfo);
        html.availableProductsList().appendChild(li);

        html.productNameInput().value = '';
        html.productQuantityInput().value = '';
        html.productPriceInput().value = '';
    }

    function addProductToBuy(e) {
        e.preventDefault();

        const availableQuantity = parseInt(this.parentNode.parentNode.children[1].textContent.split(' ')[1]);

        if (availableQuantity === 1) {
            this.parentNode.parentNode.parentNode.removeChild(this.parentNode.parentNode);
            createBuyProduct(this);
        } else {
            this.parentNode.parentNode.children[1].textContent = `Available: ${availableQuantity - 1}`;
            createBuyProduct(this);
        }
    }

    function createBuyProduct(button) {
        const li = createDomElement('li', button.parentNode.parentNode.children[0].textContent, null, null);
        const strongPrice = createDomElement('strong', Number(button.parentNode.children[0].textContent).toFixed(2), null, null);

        totalPrice += Number(strongPrice.textContent);
        html.totalPriceField().textContent = `Total Price: ${totalPrice.toFixed(2)}`;
        li.appendChild(strongPrice);
        html.myProductsList().appendChild(li);
    }

    function buyProducts(e) {
        e.preventDefault();

        totalPrice = 0;
        html.totalPriceField().textContent = `Total Price: ${totalPrice.toFixed(2)}`;
        html.myProductsList().textContent = '';
    }

    function filterProducts(e) {
        e.preventDefault();

        const filterValue = html.productFilterInput().value;
        const allAvailableProducts = document.querySelectorAll('#products ul li span');

        for (let i = 0; i < allAvailableProducts.length; i++) {
            const product = allAvailableProducts[i];

            if (!product.textContent.toLowerCase().includes(filterValue.toLowerCase())) {
                product.parentNode.style.display = 'none';
            } else {
                product.parentNode.style.display = 'block';
            }
        }

        html.productFilterInput().value = '';
    }

    /**
     * @param {string} type Type of the DOM element
     * @param {string} text Text of the DOM element
     * @param {Array} classes Array of all DOM classes
     * @param {Number} id Od of the DOM element
     */
    function createDomElement(type, text, classes, id) {
        let element = document.createElement(type);

        if (text) {
            element.textContent = text;
        }

        if (classes) {
            element.classList.add(...classes);
        }

        if (id) {
            element.id = id;
        }

        return element;
    }
}