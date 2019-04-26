using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3
{
    public class Humain : Joueur
    {
        private int position = 0;
        private string nom;
        private float cash;

        public Humain(string nom, int cash)
        {
            this.nom = nom;
            this.cash = cash;
        }

        public float getCash()
        {
            return this.cash;
        }

        public override void acheter(string nomPropriete)
        {
            Console.WriteLine("le joueur " + this.nom + ": achat de la propriété '" + nomPropriete + "'");
        }

        public override void encaisser(float montant)
        {
            this.cash += montant;
            Console.WriteLine("le joueur " + this.nom + ": encaissement de " + montant);
        }

        public override void payer(float montant)
        {
            this.cash -= montant;
            Console.WriteLine("le joueur " + this.nom + ": paiement de " + montant);
        }

        public override void vendre(string nomPropriete)
        {
            Console.WriteLine("le joueur " + this.nom + ": vente de la propriété '" + nomPropriete + "'");
        }

        public int lancerDes()
        {
            Random aleatoire = new Random(); 
            return aleatoire.Next(1, 7);
        }
    }
}
