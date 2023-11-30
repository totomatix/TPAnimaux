using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimaux
{
    public class Ane : Animal
    {
        public Ane(string nom, int poids, string couleur) : base(nom, poids, couleur)
        {
        }

        public override string FaireUnSon()
        {
            return "Hi Han !";
        }
    }
}
