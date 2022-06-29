using System;
using System.Collections.Generic;
using System.Text;

namespace _09.ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public string Name { get; set; }
        public string Country { get; set ; }
        public int Age { get; set; }

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
        public string GetName()
        {
            return this.Name;
        }
        public string IPerson()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
