using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Baleine:Cetace
    {
         public Baleine(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique,int dureeApnee,int profondeurPlongee)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique,dureeApnee,profondeurPlongee)
        {

         

        }


         public new void Afficher()
         {
             Console.WriteLine("Je suis un {0} j'habite en {1} mon cri est {2} et je suis domestique {3} je peux être en apnée durant {4} minutes, je peux plonger jusqu'à {5} mètres", this.nom, this.lieuHabitation, this.monCrie, this.jeSuisDomestique, this.dureeApnee, this.profondeurPlongee);

         }
    }
}
