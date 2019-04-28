using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class VoitureClioBuilder : VoitureBuilder
    {
        public override void creerVoiture()
        {
            Voiture clio = new Voiture();
            clio.type = "clio";
            clio.chassis = "châssis court";
            clio.carosserie = "carrosserie 3 portes";
            clio.moteur = "moteur essence";
            this.voiture = clio;
        }
    }
}
