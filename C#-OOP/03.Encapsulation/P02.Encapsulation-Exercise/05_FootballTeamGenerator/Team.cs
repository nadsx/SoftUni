namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;
        
        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public IReadOnlyCollection<Player> Players => this.players.AsReadOnly();

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.players.All(x => x.Name != playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.RemoveAll(x => x.Name == playerName);
        }
    }
}

