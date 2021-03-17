namespace AquaShop.Models.Aquariums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AquaShop.Models.Aquariums.Contracts;
    using AquaShop.Models.Decorations.Contracts;
    using AquaShop.Models.Fish.Contracts;

    public abstract class Aquarium : IAquarium
    {
        private string name;
        private List<IFish> fishes;
        private List<IDecoration> decorations;

        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.fishes = new List<IFish>();
            this.decorations = new List<IDecoration>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort => this.decorations.Sum(c => c.Comfort);

        public ICollection<IDecoration> Decorations => this.decorations;

        public ICollection<IFish> Fish => this.fishes;

        public void AddDecoration(IDecoration decoration)
        {
            this.decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if(this.Capacity <= this.fishes.Count) 
            {
                throw new InvalidOperationException("Not enough capacity.");
            }

            this.fishes.Add(fish);
        }

        public void Feed()
        {
            foreach(var fish in this.fishes)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            string areThereAnyFish = fishes.Count != 0 ?
                string.Join(", ", fishes.Select(x => x.Name)) : "none";

            sb.AppendLine($"{this.Name} ({this.GetType().Name}):");
            sb.AppendLine($"Fish: {areThereAnyFish}");
            sb.AppendLine($"Decorations: {this.decorations.Count}");
            sb.AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
            return this.fishes.Remove(fish);
        }
    }
}