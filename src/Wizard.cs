using System;
using System.Collections.Generic;
using System.Text;

namespace POOBootcampGFT.src
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) 
            : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia com força super efetiva com bonus de ataque de " + Bonus;

            }
            else
            {
                return this.Name + " Lancou uma magia com força fraca com bonus de " + Bonus;
            }
        }

    }
}
