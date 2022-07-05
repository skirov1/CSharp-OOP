using System;

namespace _04.SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split();
            var sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    sum += int.Parse(data[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{data[i]}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{data[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{data[i]}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
