namespace MXGP.Models.Riders
{
    using System;

    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Utilities.Messages;

    public class Rider : IRider
    {
        private string name;

        public Rider(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }

                this.name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate { get; private set; }

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            if(motorcycle == null)
            {
                throw new ArgumentNullException(ExceptionMessages.MotorcycleInvalid);
            }

            this.Motorcycle = motorcycle;
            this.CanParticipate = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
    }
}