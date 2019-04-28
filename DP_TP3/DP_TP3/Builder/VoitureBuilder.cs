using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class VoitureBuilder
    {
        protected Voiture voiture;
        public abstract void creerVoiture();
        public Voiture getVoiture()
        {
            return this.voiture;
        }
    }
}
