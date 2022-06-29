using System;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            var smartPhone = new Smartphone();
            var stationaryPhone = new StationaryPhone();
            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();
            foreach (var number in numbers)
            {
                if (number.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.CallPhone(number));
                }
                else if (number.Length == 10)
                {
                    Console.WriteLine(smartPhone.CallPhone(number));
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartPhone.Browse(url));
            }
        }
    }
}
