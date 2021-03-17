namespace MXGP.Models.Motorcycles
{
    using System;

    using MXGP.Utilities.Messages;

    public class SpeedMotorcycle : Motorcycle
    {
        private const double Initial_Cubic = 125;
        private const int Min_HorsePower = 50;
        private const int Max_HorsePower = 69;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, Initial_Cubic)
        {
        }

        public override int HorsePower
        {
            get => base.HorsePower;
            protected set
            {
                if (value < Min_HorsePower || value > Max_HorsePower)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidHorsePower);
                }

                base.HorsePower = value;
            }
        }
    }
}