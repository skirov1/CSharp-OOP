using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private decimal salary;
        private int age;
        public string FirstName
        {
            get => this.firstName;
            private set
            {
                
                    this.firstName = value;
                
               
            }
        }
        public string LastName
        {
            get => this.lastName;
            private set
            {
               
                

                this.lastName = value;
            }
        }
        public int Age
        {
            get => this.age;
            private set
            {
                
                this.age = value;
            }
        }
        public decimal Salary
        {
            get => this.salary;
            private set
            {
                
                this.salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age >= 30)
            {
                decimal increase = this.Salary * percentage / 100;
                this.Salary += increase;
            }
            else
            {
                decimal increase = (this.Salary * percentage / 100) / 2;
                this.Salary += increase;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
