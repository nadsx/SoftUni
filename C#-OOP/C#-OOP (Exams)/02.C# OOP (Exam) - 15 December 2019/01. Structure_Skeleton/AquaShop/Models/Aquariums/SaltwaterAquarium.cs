namespace AquaShop.Models.Aquariums
{
    public class SaltwaterAquarium : Aquarium
    {
        private const int Initial_Capacity = 25;

        public SaltwaterAquarium(string name)
            : base(name, Initial_Capacity)
        {
        }
    }
}