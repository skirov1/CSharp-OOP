using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var teams = new List<Team>();
            var players = new List<Player>();
            while (true)
            {
                var cmd = Console.ReadLine().Split(";");
                if (cmd[0] == "END")
                {
                    break;
                }
                if (cmd[0] == "Team")
                {
                    var teamName = cmd[1];
                    var team = new Team(teamName);
                    teams.Add(team);
                }
                else if (cmd[0] == "Add")
                {
                    var teamName = cmd[1];
                    var playerName = cmd[2];
                    var playerEndurance = decimal.Parse(cmd[3]);
                    var playerSprint = decimal.Parse(cmd[4]);
                    var playerDribble = decimal.Parse(cmd[5]);
                    var playerPassing = decimal.Parse(cmd[6]);
                    var playerShooting = decimal.Parse(cmd[7]);
                    var player = new Player(playerName, playerEndurance, playerSprint, playerDribble, playerPassing, playerShooting);
                    players.Add(player);
                    var team = teams.Where(x => x.Name == teamName).FirstOrDefault();
                    team.AddPlayer(player);
                }
                else if (cmd[0] == "Remove")
                {
                    var teamName = cmd[1];
                    var playerName = cmd[2];
                    var player = players.Where(x => x.Name == playerName).FirstOrDefault();
                    players.Remove(player);
                    var team = teams.Where(x => x.Name == teamName).FirstOrDefault();
                    team.RemovePlayer(player);
                }
                else if (cmd[0] == "Rating")
                {
                    var teamName = cmd[1];
                    var team = teams.Where(x => x.Name == teamName).FirstOrDefault();
                    Console.WriteLine(team.PrintRating());
                }
            }
        }
    }
}
