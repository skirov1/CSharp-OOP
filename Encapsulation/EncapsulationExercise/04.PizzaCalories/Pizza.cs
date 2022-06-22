using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private double calories;
        private const int maxNumberOfToppings = 10;

        public Dough Dough { get; set; }
        private List<Topping> Toppings { get; set; }
        public double Calories
        {
            get => this.CalculateCalories();
            private set
            {
                {
                    this.calories = CalculateCalories();
                }
            }
        }
        public string Name
        {
            get => this.name;
            private set
            {
                {
                    if (!string.IsNullOrEmpty(value) && value.Length < 15)
                    {
                        this.name = value;
                    }
                    else
                    {
                        Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                        Environment.Exit(0);
                    }
                }
            }
        }
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
            this.Dough = dough;
            this.Calories = 0;
        }
        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count < maxNumberOfToppings)
            {
                this.Toppings.Add(topping);
            }
            else
            {
                Console.WriteLine("Number of toppings should be in range [0..10].");
                Environment.Exit(0);
            }
        }
        private double CalculateCalories()
        {
            double calories = this.Dough.Calories;
            foreach (var topping in this.Toppings)
            {
                calories += topping.Calories;
            }
            return calories;
        }
    }
}
