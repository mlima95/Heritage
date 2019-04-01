using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammifere m = new Mammifere("Ours","Afrique","grr",true);
            m.Afficher();
            Felin f = new Felin("lynx", "Asie", "GRA", true, 4);
            f.Afficher();
            Cetace c = new Cetace("Dauphin", "Océan Indien", "iii", true, 360, 100);
            c.Afficher();
            Lion l = new Lion("Leon", "Afrique centrale", "groa", false, 4);
            l.Afficher();
            Chat ch = new Chat("Samilou", "France", "miou", true, 4);
            ch.Afficher();
            Baleine b = new Baleine("kyky", "Océan Indien", "ouuua", true, 562, 300);
            b.Afficher();
            Console.ReadLine();
        }
    }
}
