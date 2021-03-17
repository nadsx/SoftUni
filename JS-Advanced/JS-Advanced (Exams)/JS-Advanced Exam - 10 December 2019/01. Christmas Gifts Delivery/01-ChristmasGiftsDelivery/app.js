function solution() {
    const addGiftButton = document.getElementsByTagName('button')[0];
    const listOfGifts = document.getElementsByClassName('card')[1];
    const listOfSendGifts = document.getElementsByClassName('card')[2];
    const listOfDiscardedGifts = document.getElementsByClassName('card')[3];

    addGiftButton.addEventListener('click', function (e) {
        e.preventDefault();

        const gift = document.getElementsByTagName('input')[0].value;
        const newGift = createGift(gift, true);
        let isAdded = false;

        for (let i = 0; i < listOfGifts.children[1].childElementCount; i++) {
            const currentGift = listOfGifts.children[1].getElementsByTagName('li')[i];

            if (newGift.textContent.localeCompare(currentGift.textContent) === -1) {
                listOfGifts.children[1].insertBefore(newGift, currentGift);
                isAdded = true;
                break;
            }
        }

        if (!isAdded) {
            listOfGifts.children[1].appendChild(newGift);
        }

        document.getElementsByTagName('input')[0].value = '';
    });

    function createGift(gift, hasButtons) {
        const li = document.createElement('li');
        li.classList.add('gift');
        li.textContent = gift;

        if (hasButtons) {
            const sendButton = document.createElement('button');
            sendButton.textContent = 'Send';
            sendButton.id = 'sendButton';

            sendButton.addEventListener('click', function (e) {
                e.preventDefault();

                this.parentNode.parentNode.removeChild(this.parentNode);
                const li = createGift(gift, false);
                listOfSendGifts.children[1].appendChild(li);
            });

            const discardButton = document.createElement('button');
            discardButton.textContent = 'Discard';
            discardButton.id = 'discardButton';

            discardButton.addEventListener('click', function (e) {
                e.preventDefault();

                this.parentNode.parentNode.removeChild(this.parentNode);
                const li = createGift(gift, false);
                listOfDiscardedGifts.children[1].appendChild(li);
            });

            li.appendChild(sendButton);
            li.appendChild(discardButton);
        }

        return li;
    }
}