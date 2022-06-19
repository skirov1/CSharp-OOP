using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private string tomcatGender = "male";

        public override string Gender { get => this.tomcatGender; }

        public Tomcat(string name, int age) : base(name, age, "")
        {

        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
