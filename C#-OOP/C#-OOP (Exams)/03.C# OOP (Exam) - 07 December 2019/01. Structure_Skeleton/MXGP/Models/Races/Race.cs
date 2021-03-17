namespace MXGP.Models.Races
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Utilities.Messages;

    public class Race : IRace
    {
        private string name;
        private int laps;
        private List<IRider> riders;

        public Race(string name, int laps)
        {
            this.Name = name;
            this.Laps = laps;
            this.riders = new List<IRider>();
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

        public int Laps
        {
            get => this.laps;
            private set
            {
                if(value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfLaps);
                }

                this.laps = value;
            }
        }

        public IReadOnlyCollection<IRider> Riders => this.riders.AsReadOnly();

        public void AddRider(IRider rider)
        {
            if(rider == null)
            {
                throw new ArgumentNullException(ExceptionMessages.RiderInvalid);
            }

            if(rider.CanParticipate == false)
            {
                throw new ArgumentException(ExceptionMessages.RiderNotParticipate);
            }

            if(this.riders.Any(r => r.Name == rider.Name))
            {
                throw new ArgumentNullException(ExceptionMessages.RiderAlreadyAdded);
            }

            this.riders.Add(rider);
        }
    }
}