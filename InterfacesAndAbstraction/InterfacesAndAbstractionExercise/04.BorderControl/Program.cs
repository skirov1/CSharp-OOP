using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            var IDs = new List<string>();
            while (true)
            {
                var info = Console.ReadLine().Split();
                if (info[0] == "End")
                {
                    break;
                }
                if (info.Length == 2)
                {
                    var model = info[0];
                    var id = info[1];
                    var robot = new Robot(model, id);
                    IDs.Add(id);
                }
                else if (info.Length == 3)
                {
                    var name = info[0];
                    var age = int.Parse(info[1]);
                    var id = info[2];
                    var citizen = new Citizen(name, age, id);
                    IDs.Add(id);
                }
            }
            var fakeIdDigits = Console.ReadLine();
            var fakeIDs = IDs.Where(x => x.EndsWith(fakeIdDigits)).ToList();
            foreach (var fakeID in fakeIDs)
            {
                Console.WriteLine(fakeID);
            }
        }
    }
}
