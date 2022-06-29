using System;

namespace _09.ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var info = Console.ReadLine().Split();
                if (info[0] == "End")
                {
                    break;
                }
                var name = info[0];
                var country = info[1];
                var age = int.Parse(info[2]);
                var citizen = new Citizen(name, country, age);
                Console.WriteLine(citizen.GetName());
                Console.WriteLine(citizen.IPerson());
            }
        }
    }
}
