function solve() {
    document.querySelector("#exercise > button:nth-child(3)").addEventListener("click", generate);
    document.querySelector("#exercise > button:nth-child(6)").addEventListener("click", buy);
    let tableBody = document.querySelector("#exercise > div > div > div > div > table > tbody");

    function generate() {
        let inputJSON = document.querySelector("#exercise > textarea").value;
        let parsedInput = JSON.parse(inputJSON);

        for (const obj of parsedInput) {
            let tr = document.createElement("tr");
            let td1 = document.createElement("td");
            let img = document.createElement("img");
            img.src = obj.img;
            td1.appendChild(img);

            let td2 = document.createElement("td");
            let p2 = document.createElement("p");
            p2.textContent = obj.name;
            td2.appendChild(p2);

            let td3 = document.createElement("td");
            let p3 = document.createElement("p");
            p3.textContent = obj.price;
            td3.appendChild(p3);

            let td4 = document.createElement("td");
            let p4 = document.createElement("p");
            p4.textContent = obj.decFactor;
            td4.appendChild(p4);

            let td5 = document.createElement("td");
            let input = document.createElement("input");
            input.type = "checkbox";
            td5.appendChild(input);

            tr.appendChild(td1);
            tr.appendChild(td2);
            tr.appendChild(td3);
            tr.appendChild(td4);
            tr.appendChild(td5);

            tableBody.appendChild(tr);
        }
    }

    function buy() {
        let allInputs = document.getElementsByTagName("input");
        let buyOutput = document.querySelector("#exercise > textarea:nth-child(5)");
        // .querySelector(#exercise..) ONLY HIS CHILDREN! With tag textarea!// NOT THE CHILDREN OF THE CHILDREN!

        let bought = [];

        for (let i = 1; i < allInputs.length; i++) {
            if (allInputs[i].checked === true) {
                bought.push(tableBody.children[i]);
            }
        }

        let names = [];
        let totalPrice = 0;
        let decFactors = [];

        for (const item of bought) {
            names.push(item.children[1].textContent);
            totalPrice += Number(item.children[2].textContent);
            decFactors.push(Number(item.children[3].textContent));
        }

        buyOutput.value += `Bought furniture: ${names.join(", ")}\n`;
        buyOutput.value += `Total price: ${totalPrice.toFixed(2)}\n`;
        buyOutput.value += `Average decoration factor: ${calculateAvg(decFactors)}`;
    }

    function calculateAvg(arr) {
        var sum = 0;

        for (var i = 0; i < arr.length; i++) {
            sum += arr[i];
        }

        var avg = sum / arr.length;
        return avg;
    }
}

//DEMO: (:nth-child) The :nth-child(n) selector selects all elements that are the nth child, regardless of type, of their parent.
/* <div>
  <ul>
    <li>John</li>
    <li>Karl</li>
    <li>Brandon</li>
  </ul>
</div>

<script>
$( "ul li:nth-child(2)" ).append( "<span> - 2nd!</span>" );
</script>

John
Karl - 2nd!
Brandon */