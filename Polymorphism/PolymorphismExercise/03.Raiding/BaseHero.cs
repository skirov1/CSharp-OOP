using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public virtual int Power { get; private set; }
        public abstract string CastAbility();

        public BaseHero(string name)
        {
            this.Name = name;
        }
    }
}
