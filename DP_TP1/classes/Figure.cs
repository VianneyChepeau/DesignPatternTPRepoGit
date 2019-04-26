using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public abstract class Figure : IDessinable
    {
        private int r;
        private int g;
        private int b;

        public abstract void dessiner();
        public abstract void effacer();
        public abstract double calculerSurface();

        // methodes de IPositionnable
        public abstract int GetX();
        public abstract void SetX(int x);
        public abstract int GetY();
        public abstract void SetY(int y);
        public abstract void deplacer(int x, int y);

        // methodes de IColoriable
        public int GetR()
        {
            return this.r;
        }
        public void SetR(int r)
        {
            this.r = r;
        }
        public int GetG()
        {
            return this.g;
        }
        public void SetG(int g)
        {
            this.g = g;
        }
        public int GetB()
        {
            return this.b;
        }
        public void SetB(int b)
        {
            this.b = b;
        }
        public void colorier(int r, int g, int b)
        {
            SetR(r);
            SetG(g);
            SetB(b);
        }
    }
}
