using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public class Carre : Rectangle
    {
        private int L;
        private Point centre;
        private Double surface;


        public Carre(Point centre, int L = 10) : base(centre, L, L)
        {
            this.L = L;
            this.centre = centre;
            this.surface = base.calculerSurface();
        }

        public override void dessiner()
        {
            Console.WriteLine("Je suis un carré de côté " + this.L.ToString() + " et j'ai une surface égale à " + this.surface.ToString());
        }

        public override void effacer()
        {
            Console.WriteLine("Supression du carré de côté " + this.L.ToString() + " et de surface égale à " + this.surface.ToString());
        }
    }
}
