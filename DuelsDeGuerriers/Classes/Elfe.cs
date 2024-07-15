using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelsDeGuerriers.Classes
{
    internal class Elfe : Guerrier
    {
        private int _valueDamage;

        Random aleatoire = new Random();

        public override int ValueDamage { get => _valueDamage; set => _valueDamage = aleatoire.Next(3, 7); }

        public Elfe(string name, int pointdevie) : base(name, pointdevie)
        {
            ValueDamage = _valueDamage;
        }
    }
}
