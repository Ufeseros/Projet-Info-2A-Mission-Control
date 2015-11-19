﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Control
{
    class Activitée
    {
        private string categorie;
        private string libelle;
        private int tempsdébut;
        private int tempsfin;
        private int numJour;
        private List<Astronaute> participants;

        public Activitée()
        {
            categorie = "Living";
            libelle = "Private";
            tempsdébut = 0;
            tempsfin = 0;
            numJour = 1;
            participants = new List<Astronaute>();
        }

        public Activitée(string categorie, string libelle, int tempsdébut, int tempsfin, int numJour)
        {
            this.categorie = categorie;
            this.libelle = libelle;
            this.tempsdébut = tempsdébut;
            this.tempsfin = tempsfin;
            this.numJour = numJour;

            participants = new List<Astronaute>();
        }
    
    
    }
}
