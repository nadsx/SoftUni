namespace SpaceStation.Models.Mission
{
    using System.Collections.Generic;
    using System.Linq;

    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Models.Planets;

    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            while (true)
            {
                IAstronaut astronaut = astronauts.FirstOrDefault(a => a.CanBreath == true);

                if (astronaut == null)
                {
                    break;
                }

                string item = planet.Items.FirstOrDefault(); 

                if(item == null)
                {
                    break;
                }

                astronaut.Breath();

                if (astronaut.CanBreath == false)
                {
                    continue;
                }

                astronaut.Bag.Items.Add(item);
                planet.Items.Remove(item);
            }
        }
    }
}