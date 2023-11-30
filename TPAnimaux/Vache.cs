using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimaux
{
    public class Vache : Animal
    {
        public Vache(string nom, int poids, string couleur) : base(nom, poids, couleur)
        {
        }

        public override string FaireUnSon()
        {
            return "MEUUUH !";
        }
    }
}
