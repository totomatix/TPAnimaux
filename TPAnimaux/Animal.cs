using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimaux
{
    public abstract class Animal
    {
        protected Animal(string nom, int poids, string couleur)
        {
            Nom = nom;
            Poids = poids;
            Couleur = couleur;
        }

        private string Nom {get;set;}

        private int Poids { get; set; }

        private string Couleur { get; set; }

        public override string? ToString()
        {
            return $"Nom : {Nom}, " +
                $"Couleur : {Couleur}, " +
                $"Poids : {Poids} kg, " +
                $"Son : {FaireUnSon()}";
        }

        public abstract string FaireUnSon();

    }
}
