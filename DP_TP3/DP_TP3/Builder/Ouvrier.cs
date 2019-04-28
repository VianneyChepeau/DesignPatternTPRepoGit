using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Ouvrier
    {
        private VoitureBuilder voitureBuilder;


        public void setVoitureBuilder(VoitureBuilder voitureBuilder)
        {
            this.voitureBuilder = voitureBuilder;
        }

       public void assemblerVoiture()
        {
            voitureBuilder.creerVoiture();
        }

        public Voiture getVoiture()
        {
            return voitureBuilder.getVoiture();
        }
    }
}
