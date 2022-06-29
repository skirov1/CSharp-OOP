using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var birthDates = new List<string>();
            while (true)
            {
                var info = Console.ReadLine().Split();
                if (info[0] == "End")
                {
                    break;
                }
                if (info[0] == "Citizen")
                {
                    var birthDate = info[4];
                    birthDates.Add(birthDate);
                }
                else if (info[0] == "Pet")
                {
                    var birthDate = info[2];
                    birthDates.Add(birthDate);
                }
            }
            var year = Console.ReadLine();
            var birthDatesToPrint = birthDates.Where(x => x.EndsWith(year)).ToList();
            foreach (var birthDate in birthDatesToPrint)
            {
                Console.WriteLine(birthDate);
            }
        }
    }
}
