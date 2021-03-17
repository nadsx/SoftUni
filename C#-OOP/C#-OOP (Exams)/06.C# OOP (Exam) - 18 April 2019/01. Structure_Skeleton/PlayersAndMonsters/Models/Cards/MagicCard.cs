namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private const int Default_Damage_Points = 5;
        private const int Default_Health_Points = 80;

        public MagicCard(string name) 
            : base(name, Default_Damage_Points, Default_Health_Points)
        {
        }
    }
}