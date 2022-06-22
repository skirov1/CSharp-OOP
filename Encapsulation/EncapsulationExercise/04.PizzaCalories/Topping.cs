using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private int grams;
        private double calories;

        protected string ToppingType
        {
            get => this.toppingType;
            set
            {
                {
                    if (value.Contains("meat", StringComparison.CurrentCultureIgnoreCase) || value.Contains("veggies", StringComparison.CurrentCultureIgnoreCase) || value.Contains("cheese", StringComparison.CurrentCultureIgnoreCase) || value.Contains("sauce", StringComparison.CurrentCultureIgnoreCase))
                    {
                        this.toppingType = value;
                    }
                    else
                    {
                        
                        Console.WriteLine($"Cannot place {value} on top of your pizza.");
                        Environment.Exit(0);
                    }
                }
            }
        }
        protected int Grams
        {
            get => this.grams;
            set
            {
                {
                    if (value >= 1 && value <= 50)
                    {
                        this.grams = value;
                    }
                    else
                    {

                        Console.WriteLine($"{this.ToppingType} weight should be in the range [1..50].");
                        Environment.Exit(0);
                    }
                }
            }
        }
        public double Calories
        {
            get => this.calories;
            private set
            {
                this.calories = CalculateCalories();
            }
        }

        public Topping(string type, int grams)
        {
            this.ToppingType = type;
            this.Grams = grams;
            this.Calories = CalculateCalories();
        }
        private double CalculateCalories()
        {
            double calories = this.Grams * 2;

            if (this.ToppingType.Contains("meat",StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= 1.2;
            }
            else if (this.ToppingType.Contains("veggies", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= 0.8;
            }
            else if (this.ToppingType.Contains("cheese", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= 1.1;
            }
            else if (this.ToppingType.Contains("sauce", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= 0.9;
            }         
            return calories;
        }
    }
}




