namespace PlayersAndMonsters.Models.Players
{
    using PlayersAndMonsters.Repositories.Contracts;

    public class Advanced : Player
    {
        private const int Default_Health = 250;

        public Advanced(ICardRepository cardRepository, string username) 
            : base(cardRepository, username, Default_Health)
        {
        }
    }
}