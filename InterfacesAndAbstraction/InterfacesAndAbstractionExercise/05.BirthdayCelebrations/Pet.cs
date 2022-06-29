using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.Birthdate = birthDate;
        }
    }
}
