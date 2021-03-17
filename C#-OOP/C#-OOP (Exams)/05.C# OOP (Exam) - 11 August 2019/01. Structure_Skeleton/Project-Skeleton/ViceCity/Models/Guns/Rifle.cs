namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int Initial_Bullets = 50;
        private const int Initial_Total_Bullets = 500;

        public Rifle(string name) 
            : base(name, Initial_Bullets, Initial_Total_Bullets)
        {
        }

        public override int Fire()
        {
            if(this.BulletsPerBarrel - 5 == 0 && this.TotalBullets > 0)
            {
                this.TotalBullets -= Initial_Bullets;
                this.BulletsPerBarrel = Initial_Bullets;

                return 5;
            }

            if(this.CanFire == true)
            {
                this.BulletsPerBarrel -= 5;

                return 5;
            }

            return 0;
        }
    }
}