using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            var raidGroup = new List<BaseHero>();
            var N = int.Parse(Console.ReadLine());
            while (raidGroup.Count < N)
            {
                var heroName = Console.ReadLine();
                var heroType = Console.ReadLine();
                switch (heroType)
                {
                    case "Druid":
                        var druidHero = new Druid(heroName);
                        raidGroup.Add(druidHero);
                        break;
                    case "Paladin":
                        var paladinHero = new Paladin(heroName);
                        raidGroup.Add(paladinHero);
                        break;
                    case "Rogue":
                        var rogueHero = new Rogue(heroName);
                        raidGroup.Add(rogueHero);
                        break;
                    case "Warrior":
                        var warriorHero = new Warrior(heroName);
                        raidGroup.Add(warriorHero);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }
            var bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }
            if (raidGroup.Sum(x => x.Power) >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
