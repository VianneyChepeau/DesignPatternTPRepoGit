using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public class Lumiere : IAllumable, IColoriable
    {
        private int r;
        private int g;
        private int b;

        public Lumiere(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public void Allumer()
        {
            Console.WriteLine("Allumage de la lumière de couleur: r=" + this.r.ToString() + ", g=" + this.g.ToString() + ", b=" + this.b.ToString());
        }

        public void Eteindre()
        {
            Console.WriteLine("Extinction de la lumière de couleur: r=" + this.r.ToString() + ", g=" + this.g.ToString() + ", b=" + this.b.ToString());
        }

        public void colorier(int r, int g, int b)
        {
            SetR(r);
            SetG(g);
            SetB(b);
        }
        
        public int GetB()
        {
            return this.b;
        }
        public int GetG()
        {
            return this.g;
        }
        public int GetR()
        {
            return this.r;
        }
        public void SetB(int b)
        {
            this.b = b;
        }
        public void SetG(int g)
        {
            this.g = g;
        }
        public void SetR(int r)
        {
            this.r = r;
        }
    }
}
