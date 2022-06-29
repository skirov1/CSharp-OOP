using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    public class Commando : Soldier, IPrivate, ISpecialisedSoldier, ICommando
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
        public List<Mission> Missions { get; set; }
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Corps = corps;
            this.Missions = new List<Mission>(missions);
        }

        public override string ToString()
        {
            if (this.Corps != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:f2}");
                sb.AppendLine($"Corps: {this.Corps}");
                sb.AppendLine("Missions:");
                foreach (var mission in this.Missions)
                {
                    if (mission.ToString() != "")
                    {
                        sb.Append("  ");
                        sb.AppendLine(mission.ToString());
                    }
                }
                return sb.ToString().TrimEnd();
            }
            return "";
        }
    }
}
