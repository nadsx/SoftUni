namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private const int Initial_Size = 5;

        public SaltwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
        }

        public override void Eat()
        {
            this.Size += Initial_Size;
        }
    }
}