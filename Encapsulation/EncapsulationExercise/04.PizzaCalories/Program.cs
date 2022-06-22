using System;

namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pizzaName = Console.ReadLine().Split();

            var doughInfo = Console.ReadLine().Split();
            var dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));

            var pizza = new Pizza(pizzaName[1], dough);

            while (true)
            {
                var toppingInfo = Console.ReadLine().Split();
                if (toppingInfo[0] == "END")
                {
                    break;
                }
                var topping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
                pizza.AddTopping(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
        }
    }
}
