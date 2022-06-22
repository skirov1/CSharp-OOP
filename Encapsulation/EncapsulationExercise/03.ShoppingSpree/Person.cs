using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        public List<string> Products { get; set; }
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
        public decimal Money
        {
            get => this.money;
            set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }
            }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
        }

        public void Buy(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Products.Add(product.Name);
                this.Money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
