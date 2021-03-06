using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            internal set
            {
                if (!string.IsNullOrWhiteSpace(value) && value != "")
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                    Environment.Exit(0);
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            protected set
            {
                //try
                //{
                //    if (value > MinAge && value < MaxAge)
                //    {
                //        this.age = value;
                //    }
                //}
                //catch (ArgumentOutOfRangeException ex)
                //{
                //    throw new ArgumentOutOfRangeException(ex.Message);
                //}
                if (value >= MinAge && value <= MaxAge)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be between 0 and 15.");
                    Environment.Exit(0);
                }
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
