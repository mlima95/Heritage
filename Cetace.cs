using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Cetace : Mammifere
    {
        protected int dureeApnee;
        protected int profondeurPlongee;

        public Cetace(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlongee)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {

            this.dureeApnee = dureeApnee;
            this.profondeurPlongee = profondeurPlongee;

        }

        public new void Afficher()
        {
            Console.WriteLine("Je suis un {0} j'habite en {1} mon cri est {2} et je suis domestique {3} je peux être en apnée durant {4} minutes, je peux plonger jusqu'à {5} mètre", this.nom, this.lieuHabitation, this.monCrie, this.jeSuisDomestique, this.dureeApnee, this.profondeurPlongee);

        }
    }
}
