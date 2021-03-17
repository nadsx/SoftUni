namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int Initial_Comfort = 5;
        private const decimal Initial_Price = 10;

        public Plant() 
            : base(Initial_Comfort, Initial_Price)
        {
        }
    }
}