namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        protected Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public virtual void Drive(double kilometers)
        {
            double leftFuel = this.Fuel - this.FuelConsumption * kilometers;

            if (leftFuel >= 0)
            {
                this.Fuel -= this.FuelConsumption * kilometers;
            }
        }
    }
}
