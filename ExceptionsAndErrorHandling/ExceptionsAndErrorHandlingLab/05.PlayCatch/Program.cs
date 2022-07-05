using System;
using System.Linq;

namespace _05.PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var errors = 0;
            while (true)
            {

                try
                {
                    var cmd = Console.ReadLine().Split();
                    var action = cmd[0];
                    if (action == "Replace")
                    {
                        var index = int.Parse(cmd[1]);
                        var element = int.Parse(cmd[2]);
                        numbers[index] = element;
                    }
                    else if (action == "Print")
                    {
                        var startIndex = int.Parse(cmd[1]);
                        var endIndex = int.Parse(cmd[2]);
                        Console.WriteLine(string.Join(", ",numbers.GetRange(startIndex, endIndex - startIndex + 1)));
                    }
                    else if (action == "Show")
                    {
                        var index = int.Parse(cmd[1]);
                        Console.WriteLine(numbers[index]);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    errors++;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The index does not exist!");
                    errors++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    errors++;
                }
                finally
                {
                    if (errors == 3)
                    {
                        Console.WriteLine(string.Join(", ", numbers));
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
