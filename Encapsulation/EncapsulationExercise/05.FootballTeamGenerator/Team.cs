using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;
        public decimal Rating
        {
            get
            {
                {
                    if (players.Count > 0)
                    {
                        return this.players.Average(x => x.SkillLevel);
                    }
                    return 0;
                }
            }
        }
        public string Name
        {
            get => this.name;
            private set
            {
                {
                    if (!string.IsNullOrWhiteSpace(value) && value != "")
                    {
                        this.name = value;
                    }
                    else
                    {
                        Console.WriteLine("A name should not be empty.");
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            if (players.Contains(player))
            {
                players.Remove(player);
            }
            else
            {
                Console.WriteLine($"Player {player.Name} is not in {this.Name} team.");
            }
        }

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }
        public string PrintRating()
        {
            return $"{this.Name} - {Math.Round(this.Rating)}";
        }
    }
}
