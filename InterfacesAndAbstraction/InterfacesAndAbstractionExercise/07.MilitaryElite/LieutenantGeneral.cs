using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    public class LieutenantGeneral : Soldier, IPrivate, ILieutenantGeneral
    {
        public List<Private> Privates { get; set; }
        public decimal Salary { get; set; }

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Privates = new List<Private>(privates);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:f2}");
            sb.AppendLine("Privates:");
            foreach (var soldier in this.Privates)
            {
                sb.Append("  ");
                sb.AppendLine(soldier.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
