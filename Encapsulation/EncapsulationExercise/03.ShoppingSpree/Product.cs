using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get => this.name;
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(0);
                }
            }
        }
        public decimal Cost
        {
            get => this.cost;
            private set
            {
                if (value >= 0)
                {
                    this.cost = value;
                }
                else
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }
            }
        }

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
