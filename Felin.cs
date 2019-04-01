﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Felin : Mammifere
    {
        protected int nombrePattes;

        public Felin(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {

            this.nombrePattes = nombrePattes;
        }

        public new void Afficher()
        {

            Console.WriteLine("Je suis un {0} j'habite en {1} mon cri est {2} et je suis domestique {3} j'ai {4} pattes", this.nom, this.lieuHabitation, this.monCrie, this.jeSuisDomestique, this.nombrePattes);

        }
    }
}

