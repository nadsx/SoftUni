namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int Initial_Bullets = 10;
        private const int Initial_Total_Bullets = 100;

        public Pistol(string name)
            : base(name, Initial_Bullets, Initial_Total_Bullets)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel - 1 == 0 && this.TotalBullets > 0)
            {
                this.TotalBullets -= Initial_Bullets;
                this.BulletsPerBarrel = Initial_Bullets;

                return 1; 
            }

            if(this.CanFire == true)
            {
                this.BulletsPerBarrel--; 

                return 1;
            }

            return 0;
        }
    }
}