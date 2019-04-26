using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public class Cercle : Figure
    {
        private double rayon;
        private Point centre;
        private double surface;

        public Cercle(double rayon) : this(null, null)
        {
            this.rayon = rayon;
            this.surface = this.calculerSurface();
        }

        public Cercle(double? rayon, Point centre)
        {
            if (rayon == null)
                this.rayon = 10;
            else
                this.rayon = double.Parse(rayon.ToString());
            this.surface = this.calculerSurface();
            if(centre == null)
                this.centre = new Point();
            else
                this.centre = centre;            
        }

        public override void dessiner()
        {
            Console.WriteLine("Je suis un cercle de rayon " + this.rayon.ToString() + " et j'ai une surface égale à " + this.surface.ToString() );
        }

        public override void effacer()
        {
            Console.WriteLine("Supression du cercle de rayon " + this.rayon.ToString() + "et de surface égale à " + this.surface.ToString());
        }

        public override double calculerSurface()
        {
            return (Math.Pow(Math.PI * rayon, 2));
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
