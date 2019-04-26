using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public class Rectangle : Figure
    {
        private int L;
        private int l;
        private Point centre;
        private double surface;

        public Rectangle(Point centre, int L = 10, int l = 5)
        {
            this.L = L;
            this.l = l;
            this.centre = centre;
            this.surface = this.calculerSurface();
        }
        
        public override double calculerSurface()
        {
            return (this.L * this.l);
        }
        public override void dessiner()
        {
            Console.WriteLine("Je suis un rectangle de longueur " + this.L.ToString() + " et de lageur " + this.l.ToString() + " et j'ai une surface égale à " + this.surface.ToString());
        }
        public override void effacer()
        {
            Console.WriteLine("Supression du rectangle de longueur " + this.L.ToString() + " et de lageur " + this.l.ToString() + " et de surface égale à " + this.surface.ToString());
        }

        // methodes de IPositionnable
        public override int GetX()
        {
            return this.centre.GetX();
        }
        public override void SetX(int x)
        {
            this.centre.SetX(x);
        }
        public override int GetY()
        {
            return this.centre.GetY();
        }
        public override void SetY(int y)
        {
            this.centre.SetY(y);
        }
        public override void deplacer(int x, int y)
        {
            this.SetX(x);
            this.SetY(y);
        }
    }
}
