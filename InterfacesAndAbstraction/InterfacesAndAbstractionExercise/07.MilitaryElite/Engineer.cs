using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    public class Engineer : Soldier, IPrivate, ISpecialisedSoldier, IEngineer
    {
        private string corps;
       
        public decimal Salary { get; set; }
        public string Corps
        {
            get => this.corps;
            set
            {
                {
                    if (value == "Airforces" || value == "Marines")
                    {
                        this.corps = value;
                    }
                }
            }
        }
        public List<Repair> Repairs { get; set; }
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs) : base(id, firstName, lastName)
        {          
            this.Salary = salary;
            this.Corps = corps;
            this.Repairs = new List<Repair>(repairs);
        }

        public override string ToString()
        {
            if (this.Corps != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:f2}");
                sb.AppendLine($"Corps: {this.Corps}");
                sb.AppendLine("Repairs:");
                foreach (var repair in this.Repairs)
                {
                    sb.Append("  ");
                    sb.AppendLine(repair.ToString());
                }
                return sb.ToString().TrimEnd();
            }
            return "";
        }
    }
}
