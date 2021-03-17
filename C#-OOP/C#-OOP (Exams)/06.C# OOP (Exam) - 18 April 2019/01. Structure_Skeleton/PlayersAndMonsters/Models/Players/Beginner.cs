namespace PlayersAndMonsters.Models.Players
{
    using PlayersAndMonsters.Repositories.Contracts;

    public class Beginner : Player
    {
        private const int Default_Health = 50;

        public Beginner(ICardRepository cardRepository, string username) 
            : base(cardRepository, username, Default_Health)
        {
        }
    }
}