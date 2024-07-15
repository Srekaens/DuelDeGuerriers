using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelsDeGuerriers.Classes
{
    internal class Nain : Guerrier
    {
        private int _ptBouclier;

        public int PtBouclier { get => _ptBouclier; set => _ptBouclier = value; }

        public Nain(string name, int pointdevie, int ptBouclier) : base (name, pointdevie)
        {
            PtBouclier = ptBouclier;
            PointDeVie += PtBouclier;
        }
        /*
        public void PdvNain()
        {
            PointDeVie += PtBouclier;
        }
        */
    }
}
