using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        private string kittenGender = "female";

        public override string Gender { get => this.kittenGender; }

        public Kitten(string name, int age) : base(name, age, "")
        {

        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
