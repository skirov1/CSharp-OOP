using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string Gender { get; set; }
        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value))
        //        {
        //            this.name = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input!");
        //        }
        //    }
        //}
        //public int Age
        //{
        //    get
        //    {
        //        return this.age;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            this.age = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input!");
        //        }
        //    }
        //}
        //public virtual string Gender
        //{
        //    get
        //    {
        //        return this.gender;
        //    }
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value))
        //        {
        //            this.gender = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input!");
        //        }
        //    }
        //}

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append($"{this.ProduceSound()}");
            if (this.Age > 0 && !string.IsNullOrEmpty(this.Name) && !string.IsNullOrEmpty(this.Gender))
            {
                return sb.ToString();
            }
            return "Invalid input!";
        }
    }
}
