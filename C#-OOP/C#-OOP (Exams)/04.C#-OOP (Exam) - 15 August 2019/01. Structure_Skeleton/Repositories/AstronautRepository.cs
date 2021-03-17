namespace SpaceStation.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Repositories.Contracts;

    public class AstronautRepository : IRepository<IAstronaut>
    {
        private readonly List<IAstronaut> astronauts;

        public AstronautRepository()
        {
            this.astronauts = new List<IAstronaut>();
        }

        public IReadOnlyCollection<IAstronaut> Models => this.astronauts.AsReadOnly();

        public void Add(IAstronaut model)
        {
            this.astronauts.Add(model);
        }

        public IAstronaut FindByName(string name)
        {
            return this.astronauts.First(a => a.Name == name); 
        }

        public bool Remove(IAstronaut model)
        {
            return this.astronauts.Remove(model);
        }
    }
}