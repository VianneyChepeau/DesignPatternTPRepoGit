using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class VoitureEspaceBuilder : VoitureBuilder
    {
        public override void creerVoiture()
        {
            Voiture espace = new Voiture();
            espace.type = "Espace";
            espace.chassis = "châssis long";
            espace.carosserie = "carrosserie 5 portes";
            espace.moteur = "moteur diesel";
            this.voiture = espace;
        }
    }
}
