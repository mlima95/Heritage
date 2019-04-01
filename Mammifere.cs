using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Mammifere
    {
        protected string nom, lieuHabitation, monCrie;
        protected bool jeSuisDomestique;
        
        public Mammifere(string nom,string lieuHabitation,string monCrie,bool jeSuisDomestique){
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        
        }

        public void Afficher() {
            Console.WriteLine("Je suis un {0} j'habite en {1} mon cri est {2} et je suis domestique {3}",this.nom,this.lieuHabitation,this.monCrie,this.jeSuisDomestique);
        }

        public bool JeSuisDangereux()
        {
            return this.jeSuisDomestique;
        }
    }
    
}
