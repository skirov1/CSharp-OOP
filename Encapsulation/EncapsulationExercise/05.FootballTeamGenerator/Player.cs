using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private decimal skillLevel;
        private decimal endurance;
        private decimal sprint;
        private decimal dribble;
        private decimal passing;
        private decimal shooting;

        public decimal Endurance
        {
            get => this.endurance;
            private set
            {
                {
                    if (value >= 0 && value <= 100)
                    {
                        this.endurance = value;
                    }
                    else
                    {
                        Console.WriteLine($"Endurance should be between 0 and 100.");
                    }
                }
            }
        }
        public decimal Sprint
        {
            get => this.sprint;
            private set
            {
                {
                    if (value >= 0 && value <= 100)
                    {
                        this.sprint = value;
                    }
                    else
                    {
                        Console.WriteLine($"Sprint should be between 0 and 100.");
                    }
                }
            }
        }
        public decimal Dribble
        {
            get => this.dribble;
            private set
            {
                {
                    if (value >= 0 && value <= 100)
                    {
                        this.dribble = value;
                    }
                    else
                    {
                        Console.WriteLine($"Dribble should be between 0 and 100.");
                    }
                }
            }
        }
        public decimal Passing
        {
            get => this.passing;
            private set
            {
                {
                    if (value >= 0 && value <= 100)
                    {
                        this.passing = value;
                    }
                    else
                    {
                        Console.WriteLine($"Passing should be between 0 and 100.");
                    }
                }
            }
        }
        public decimal Shooting
        {
            get => this.shooting;
            private set
            {
                {
                    if (value >= 0 && value <= 100)
                    {
                        this.shooting = value;
                    }
                    else
                    {
                        Console.WriteLine($"Shooting should be between 0 and 100.");
                    }
                }
            }
        }
        public string Name
        {
            get => this.name;
            private set
            {
                {
                    if (!string.IsNullOrWhiteSpace(value) && value != "")
                    {
                        this.name = value;
                    }
                    else
                    {
                        Console.WriteLine("A name should not be empty.");
                        Environment.Exit(0);
                    }
                }
            }
        }
        internal decimal SkillLevel
        {
            get => this.CalculateSkillLevel();
            set
            {
                {
                    this.skillLevel = CalculateSkillLevel();
                }
            }
        }

        public Player(string name, decimal endurance, decimal sprint, decimal dribble, decimal passing, decimal shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.SkillLevel = CalculateSkillLevel();
        }

        private decimal CalculateSkillLevel()
        {
            return (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5;
        }
    }
}
