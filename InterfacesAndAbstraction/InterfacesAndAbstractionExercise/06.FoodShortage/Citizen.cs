using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public class Citizen : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public string ID { get; set; }
        public string Birthdate { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
