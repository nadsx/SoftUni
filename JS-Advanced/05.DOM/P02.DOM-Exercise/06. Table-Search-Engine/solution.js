function solve() {
   let searchField = document.getElementById("searchField");
   let searchButton = document.getElementById("searchBtn");
   let tableElements = document.getElementsByTagName("tbody").item(0).getElementsByTagName("tr");

   searchButton.addEventListener("click", onClick);

   function onClick() {
      let textInput = searchField.value.toLowerCase();

      for (let row of tableElements) {
         if (row.textContent.toLowerCase().includes(textInput)) {
            row.className = "select";
         }
      }

      document.getElementById("searchField").value = "";
   }
}