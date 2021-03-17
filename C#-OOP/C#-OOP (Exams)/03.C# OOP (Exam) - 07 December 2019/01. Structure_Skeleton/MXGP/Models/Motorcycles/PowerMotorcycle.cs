namespace MXGP.Models.Motorcycles
{
    using System;

    using MXGP.Utilities.Messages;

    public class PowerMotorcycle : Motorcycle
    {
        private const double Initial_Cubic = 450;
        private const int Min_HorsePower = 70;
        private const int Max_HorsePower = 100;

        public PowerMotorcycle(string model, int horsePower)
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