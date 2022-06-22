using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int grams;
        private double calories;

        public double Calories
        {
            get => this.calories;
            private set
            {
                this.calories = this.CalculateCalories();
            }
        }
        protected string FlourType
        {
            get => this.flourType;
            set
            {
                if (value.Contains("white", StringComparison.CurrentCultureIgnoreCase) || value.Contains("wholegrain", StringComparison.CurrentCultureIgnoreCase))
                {
                    this.flourType = value;
                }
                else
                {
                    Console.WriteLine("Invalid type of dough.");
                    Environment.Exit(0);
                }
            }
        }
        protected string BakingTechnique
        {
            get => this.bakingTechnique;
            set
            {
                if (value.Contains("crispy", StringComparison.CurrentCultureIgnoreCase) || value.Contains("chewy", StringComparison.CurrentCultureIgnoreCase) || value.Contains("homemade", StringComparison.CurrentCultureIgnoreCase))
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    Console.WriteLine("Invalid type of dough.");
                    Environment.Exit(0);
                }
            }
        }
        protected int Grams
        {
            get => this.grams;
            set
            {
                if (value >= 1 && value <= 200)
                {
                    this.grams = value;
                }
                else
                {
                    Console.WriteLine("Dough weight should be in the range [1..200].");
                    Environment.Exit(0);
                }
            }
        }

        public Dough(string flourType, string bakingTechnique, int grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
            this.Calories = CalculateCalories();
        }

        private double CalculateCalories()
        {
            double calories = this.Grams * 2;
            if (this.FlourType.Contains("white", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= 1.5;
            }
            if (this.BakingTechnique.Contains("crispy", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= 0.9;
            }
            if (this.BakingTechnique.Contains("chewy", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= 1.1;
            }
            return calories;
        }
    }
}
