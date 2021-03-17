namespace PlayersAndMonsters.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            Type playerType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == type);

            if(playerType == null)
            {
                throw new ArgumentException("Player of this type does not exists!");
            }

            CardRepository repository = new CardRepository();

            IPlayer player = (IPlayer)Activator.CreateInstance(playerType, repository, username);

            return player;
        }
    }
}