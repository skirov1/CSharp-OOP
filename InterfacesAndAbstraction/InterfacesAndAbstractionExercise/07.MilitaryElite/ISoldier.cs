using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    public abstract class Soldier
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Soldier(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
