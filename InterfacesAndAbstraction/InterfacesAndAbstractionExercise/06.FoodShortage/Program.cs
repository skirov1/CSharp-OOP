using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var buyers = new List<IBuyer>();

            for (int i = 0; i < N; i++)
            {
                var info = Console.ReadLine().Split();
                if (info.Length == 4)
                {
                    var name = info[0];
                    var age = int.Parse(info[1]);
                    var id = info[2];
                    var birthDate = info[3];
                    var citizen = new Citizen(name, age, id, birthDate);
                    buyers.Add(citizen);
                }
                else if (info.Length == 3)
                {
                    var name = info[0];
                    var age = int.Parse(info[1]);
                    var group = info[2];
                    var rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "End")
                {
                    break;
                }
                var buyer = buyers.Where(x => x.Name == cmd).FirstOrDefault();
                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }
            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}
