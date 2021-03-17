namespace AquaShop.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AquaShop.Core.Contracts;
    using AquaShop.Models.Aquariums;
    using AquaShop.Models.Aquariums.Contracts;
    using AquaShop.Models.Decorations;
    using AquaShop.Models.Decorations.Contracts;
    using AquaShop.Models.Fish;
    using AquaShop.Models.Fish.Contracts;
    using AquaShop.Repositories;

    public class Controller : IController
    {
        private DecorationRepository decorationRepository;
        private List<IAquarium> aquariums;

        public Controller()
        {
            this.decorationRepository = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType != "FreshwaterAquarium" && aquariumType != "SaltwaterAquarium")
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            IAquarium aquarium = null;

            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }

            this.aquariums.Add(aquarium);

            return $"Successfully added {aquarium.GetType().Name}.";
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType != "Ornament" && decorationType != "Plant")
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }

            IDecoration decoration = null; 

            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
            }

            this.decorationRepository.Add(decoration);

            return $"Successfully added {decoration.GetType().Name}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if (fishType != "FreshwaterFish" && fishType != "SaltwaterFish")
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            IAquarium aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            string aquariumToFish = string.Empty;

            IFish fish = null;

            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price); 
                aquariumToFish = "Freshwater";
            }
            else if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price); 
                aquariumToFish = "Saltwater";
            }

            if (!aquarium.GetType().Name.Contains(aquariumToFish))
            {
                return "Water not suitable.";          
            }

            aquarium.AddFish(fish);

            return $"Successfully added {fish.GetType().Name} to {aquarium.Name}.";
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal fishPrices = aquarium.Fish.Sum(x => x.Price);
            decimal decorationsPrices = aquarium.Decorations.Sum(x => x.Price);

            decimal totalSum = fishPrices + decorationsPrices;

            return $"The value of Aquarium {aquarium.Name} is {totalSum:F2}.";
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            int fishFed = 0;

            foreach (var fish in aquarium.Fish)
            {
                fish.Eat();
                fishFed++;
            }

            //aquarium.Feed();
            //return $"Fish fed: {aquarium.Fish.Count}";

            return $"Fish fed: {fishFed}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration decoration = this.decorationRepository.FindByType(decorationType);

            if (decoration == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            aquarium.AddDecoration(decoration);
            this.decorationRepository.Remove(decoration);

            return $"Successfully added {decoration.GetType().Name} to {aquarium.Name}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}