using System;
using System.Collections.Generic;
using System.Text;

namespace POOBootcampGFT.src
{
    class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}
