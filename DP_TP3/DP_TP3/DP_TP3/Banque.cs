using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3
{
    public class Banque : Joueur
    {
        private static Banque instance = null;
        private float cash;

        public static Banque getInstance()
        {
            return Banque.Instance;
        }

        private Banque(int cash)
        {
            this.cash = cash;
        }

        public static Banque Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Banque(100000);
                }
                return instance;
            }
        }

        public float getCash()
        {
            return this.cash;
        }

        public override void acheter(string nomPropriete)
        {
            Console.WriteLine("la Banque : achat de la propriété '" + nomPropriete + "'");
        }

        public override void encaisser(float montant)
        {
            this.cash += montant;
            Console.WriteLine("la Banque : encaissement de " + montant);
        }

        public override void payer(float montant)
        {
            this.cash -= montant;
            Console.WriteLine("la Banque : paiement de " + montant);
        }

        public override void vendre(string nomPropriete)
        {
            Console.WriteLine("la Banque : vente de la propriété '" + nomPropriete + "'");
        }
    }
}
