function solve() {
   const playerOne = document.getElementById("player1Div");
   const playerTwo = document.getElementById("player2Div");
   const result = document.getElementById("result").children;
   const history = document.getElementById("history");

   let playerOneCard = "";
   let playerTwoCard = "";

   [playerOne, playerTwo].map(player => player.addEventListener("click", function (card) {
      if (card.target.name === undefined) {
         return "";
      }

      player === playerOne ?
         playerOneCard = showCard(playerOneCard, result[0], card) :
         playerTwoCard = showCard(playerTwoCard, result[2], card);

      if (result[0].textContent !== "" && result[2].textContent !== "") {
         Number(playerOneCard.name) > Number(playerTwoCard.name) ?
            createBorder(playerOneCard, playerTwoCard) :
            createBorder(playerTwoCard, playerOneCard);

         saveHistory();
         defaultValues();
      }
   }));

   function showCard(player, span, card) {
      card.target.src = "images/whiteCard.jpg";
      span.textContent = card.target.name;
      player = card.target;
      return player;
   }

   function createBorder(card1, card2) {
      card1.style.border = "2px solid green";
      card2.style.border = "2px solid red";
   }

   function saveHistory() {
      history.textContent += `[${playerOneCard.name} vs ${playerTwoCard.name}] `;
   }

   function defaultValues() {
      result[0].textContent = "";
      result[2].textContent = "";
      playerOneCard = "";
      playerTwoCard = "";
   }
}