function solve() {
    const addButtons = document.querySelectorAll(".add-product");
    const productsTitles = document.querySelectorAll(".product-title");
    const productsPrice = document.querySelectorAll(".product-line-price");
    const textArea = document.getElementsByTagName("textarea")[0];
    const checkoutButton = document.querySelector(".checkout");

    const shoppingCart = [];
    let totalPrice = 0;
    let message = "";

    Array.from(addButtons).map(button => button.addEventListener("click", () => {
        const indexButton = Array.from(addButtons).indexOf(button);
        const nameProduct = productsTitles[indexButton].textContent;
        const price = +productsPrice[indexButton].textContent;

        if (!shoppingCart.includes(nameProduct)) {
            shoppingCart.push(nameProduct);
        }

        totalPrice += price;
        message = `Added ${nameProduct} for ${price.toFixed(2)} to the cart.\n`;
        textArea.textContent += message;
    }));

    checkoutButton.addEventListener("click", () => {
        textArea.textContent += `You bought ${shoppingCart.join(", ")} for ${totalPrice.toFixed(2)}.`;

        Array.from(addButtons).map(button => {
            button.disabled = true;
        });

        checkoutButton.disabled = true;
    });
}

//--------------------------
// function solve() {
//    const productAddButtons = Array.from(document.getElementsByClassName('add-product'));
//    const checkoutButton = document.getElementsByClassName('checkout')[0];
//    const resultArea = document.getElementsByTagName('textarea')[0];

//    let shoppingCart = new Set();
//    let totalPrice = 0;

//    for (const addButton of productAddButtons) {
//       addButton.addEventListener('click', onclick)
//    }
//    checkoutButton.addEventListener('click', checkout)


//    function onclick(){
//       let productName = this.parentElement.parentElement.getElementsByClassName('product-title')[0].textContent;
//       let productPrice = this.parentElement.parentElement.getElementsByClassName('product-line-price')[0].textContent;

//       shoppingCart.add(productName);
//       totalPrice +=+productPrice;

//       resultArea.textContent += `Added ${productName} for ${productPrice} to the cart.\n`;
//    }

//    function checkout(){
//       resultArea.textContent +=`You bought ${Array.from(shoppingCart.values()).join(', ')} for ${totalPrice.toFixed(2)}.`;
//       for (const addButton of productAddButtons) {
//          addButton.disabled = true;
//       }
//       checkoutButton.disabled = true;
//    }
// }