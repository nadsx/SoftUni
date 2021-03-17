function solve() {
   const rows = Array.from(document.querySelectorAll("tbody > tr"));

   rows.map(tr => tr.addEventListener("click", function () {
      if (this.hasAttribute("style")) {
         this.removeAttribute("style");
      } else {
         rows.map(tr => tr.removeAttribute("style"));
         this.style.backgroundColor = "#413f5e";
      }
   }));
}