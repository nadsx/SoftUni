namespace MXGP.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MXGP.Core.Contracts;
    using MXGP.Models.Motorcycles;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Races;
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories;

    public class ChampionshipController : IChampionshipController
    {
        private readonly MotorcycleRepository motorcycleRepository;
        private readonly RaceRepository raceRepository;
        private readonly RiderRepository riderRepository;

        public ChampionshipController()
        {
            this.motorcycleRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
            this.riderRepository = new RiderRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            IRider rider = this.riderRepository.GetByName(riderName);

            if(rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            IMotorcycle motorcycle = this.motorcycleRepository.GetByName(motorcycleModel);

            if(motorcycle == null)
            {
                throw new InvalidOperationException($"Motorcycle {motorcycleModel} could not be found.");
            }

            rider.AddMotorcycle(motorcycle);

            return $"Rider {rider.Name} received motorcycle {motorcycle.Model}.";
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            IRace race = this.raceRepository.GetByName(raceName);

            if(race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            IRider rider = this.riderRepository.GetByName(riderName);

            if(rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            race.AddRider(rider);

            return $"Rider {rider.Name} added in {race.Name} race.";
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            if(this.motorcycleRepository.GetByName(model) != null)
            {
                throw new ArgumentException($"Motorcycle {model} is already created.");
            }

            IMotorcycle motorcycle = null;

            if(type == "Speed")
            {
                motorcycle = new SpeedMotorcycle(model, horsePower);
            }
            else if(type == "Power")
            {
                motorcycle = new PowerMotorcycle(model, horsePower);
            }

            this.motorcycleRepository.Add(motorcycle);

            return $"{motorcycle.GetType().Name} {motorcycle.Model} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            if(this.raceRepository.GetByName(name) != null)
            {
                throw new InvalidOperationException($"Race {name} is already created.");
            }

            IRace race = new Race(name, laps);

            this.raceRepository.Add(race);

            return $"Race {race.Name} is created.";
        }

        public string CreateRider(string riderName)
        {
            if(this.riderRepository.GetByName(riderName) != null)
            {
                throw new ArgumentException($"Rider {riderName} is already created.");
            }

            IRider rider = new Rider(riderName);

            this.riderRepository.Add(rider);

            return $"Rider {rider.Name} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace race = this.raceRepository.GetByName(raceName);
            
            if(race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            List<IRider> topRiders = race.Riders
                .OrderByDescending(r => r.Motorcycle.CalculateRacePoints(race.Laps))
                .ToList();

            if(topRiders.Count < 3) 
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rider {topRiders[0].Name} wins {race.Name} race.");
            sb.AppendLine($"Rider {topRiders[1].Name} is second in {race.Name} race.");
            sb.AppendLine($"Rider {topRiders[2].Name} is third in {race.Name} race.");

            this.raceRepository.Remove(race);

            return sb.ToString().TrimEnd();
        }
    }
}