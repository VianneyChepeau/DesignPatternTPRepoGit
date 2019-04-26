using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3
{
    public abstract class Joueur
    {
        public abstract void encaisser(float montant);
        public abstract void payer(float montant);
        public abstract void acheter(string nomPropriete);
        public abstract void vendre(string nomPropriete);
    }
}
