using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Control
{
    class Mission
    {
        private int Durée;
        private string carte;
        private string nom;
        private List<Jour> jours;

        public Mission(int Durée, string carte, string nom)
        {
            this.Durée = Durée;
            this.carte = carte;
            this.nom = nom;
            jours = new List<Jour>();
        }
    }
}
