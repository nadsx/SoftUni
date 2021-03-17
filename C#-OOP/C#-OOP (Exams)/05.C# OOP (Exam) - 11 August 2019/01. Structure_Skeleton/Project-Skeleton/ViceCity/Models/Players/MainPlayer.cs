namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const string Initial_Name = "Tommy Vercetti";
        private const int Initial_HP = 100;

        public MainPlayer() 
            : base(Initial_Name, Initial_HP)
        {
        }
    }
}