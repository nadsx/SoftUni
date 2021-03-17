namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int Default_Damage_Points = 120;
        private const int Default_Health_Points = 5;

        public TrapCard(string name) 
            : base(name, Default_Damage_Points, Default_Health_Points)
        {
        }
    }
}