using System;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(Sqrt(number));
            }
            catch (Exception)
            {               
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
        static double Sqrt(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(number);
        }
    }
}
