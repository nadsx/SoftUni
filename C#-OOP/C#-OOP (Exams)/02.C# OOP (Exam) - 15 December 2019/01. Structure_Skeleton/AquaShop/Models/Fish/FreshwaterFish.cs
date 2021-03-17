namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private const int Initial_Size = 3;

        public FreshwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {
        }

        public override void Eat()
        {
            this.Size += Initial_Size;
        }
    }
}