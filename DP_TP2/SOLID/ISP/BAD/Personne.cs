using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.BAD
{
    public class Personne : IPersonne
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateDeNaissance { get; set; }

        public int Age
        {
            get
            {
                // calcul approximatif de l'age en fonction de la date de naissance
                return (int)(DateTime.Now.Subtract(DateDeNaissance).TotalDays / 365.25);
            }
        }

        public void EnvoyerSMS(string msg)
        {
            // TODO
        }

        public void EnvoyerEmail(string msg)
        {
            // TODO
        }
    }
}
