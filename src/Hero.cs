using System;
using System.Collections.Generic;
using System.Text;

namespace POOBootcampGFT.src
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
         public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com a espada";
        }

    }
}
