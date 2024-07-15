using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelsDeGuerriers.Classes
{
    internal class Guerrier
    {
        private string _name;
        private int _pointdevie;
        private int _valueDamage;

        Random aleatoire = new Random();
        public string Name { get => _name; set => _name = value; }
        public int PointDeVie { get => _pointdevie; set => _pointdevie = value < 0 ? 0 : value; }
        public virtual int ValueDamage { get => _valueDamage; set => _valueDamage = aleatoire.Next(1, 7); }

        public Guerrier(string name, int pointdevie)
        {
            Name = name;
            PointDeVie = pointdevie;
            ValueDamage = 0;
        }

        public void SubirDegats(int degats) // monGuerrier.SubirDegats(ValueDamage)
        {
            this.PointDeVie -= degats;
        }

        public void Attaquer(Guerrier cible) //monGuerrier.Attaquer(monAutreGuerrier)
        {
            cible.SubirDegats(this.ValueDamage);
            AfficherInfos(cible);
        }

        public void AfficherInfos(Guerrier cible)

        {
            Console.WriteLine($"{this.Name} attaque {cible.Name} ! Il est maintenant a {cible.PointDeVie} PDV.");
        }

        // ------------- A APPRONFONDIR -------------
        /*
        public static void Attaquer(Guerrier attaquant, Guerrier cible) //Guerrier.Attaquer(monGuerrier,monAutreGuerrier)
        {
            cible.PointDeVie -= attaquant.ValueDamage;
            Console.WriteLine($"{attaquant.Name} attack a {cible.Name} est maintenant il a {cible.PointDeVie}");
        }
        */
    }
}
