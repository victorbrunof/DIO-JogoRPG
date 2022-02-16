using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_JogoRPG.src.Entities
{
    class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}
