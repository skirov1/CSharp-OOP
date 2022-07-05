using System;
using System.Collections.Generic;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = 1;
            var end = 100;
            var numbers = new List<int>();
            int number;
            while (numbers.Count < 10)
            {
                try
                {
                    number = ReadNumber(start, end);
                    if (number <= start || number >= 100)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    continue;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Your number is not in range {start} - 100!");
                    continue;
                }
                numbers.Add(number);
                start = numbers[numbers.Count - 1];
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
        public static int ReadNumber(int start, int end)
        {
            var input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                throw new FormatException();
            }
            return num;
        }
    }
}
