namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int Initial_Comfort = 1;
        private const decimal Initial_Price = 5;

        public Ornament() 
            : base(Initial_Comfort, Initial_Price)
        {
        }
    }
}