namespace ViceCity.Models.Neghbourhoods
{
    using System.Collections.Generic;
    using System.Linq;

    using ViceCity.Models.Guns.Contracts;
    using ViceCity.Models.Neghbourhoods.Contracts;
    using ViceCity.Models.Players.Contracts;

    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (true)
            {
                IPlayer currentCivilPlayer = civilPlayers.FirstOrDefault(p => p.IsAlive == true);

                if(currentCivilPlayer == null)
                {
                    break;
                }

                IGun gun = mainPlayer.GunRepository.Models.FirstOrDefault(g => g.CanFire == true);

                if(gun == null)
                {
                    break;
                }


                currentCivilPlayer.TakeLifePoints(gun.Fire());
            }

            while (true)
            {
                IPlayer currentCivilPlayer = civilPlayers.FirstOrDefault(p => p.IsAlive == true);

                if(currentCivilPlayer == null)
                {
                    break;
                }

                IGun gun = currentCivilPlayer.GunRepository.Models.FirstOrDefault(g => g.CanFire == true);

                if(gun == null) 
                {
                    break;
                }

                mainPlayer.TakeLifePoints(gun.Fire());

                if(mainPlayer.IsAlive == false)
                {
                    break;
                }
            }
        }
    }
}