using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public class Dessin : IEnumerable<Figure>
    {
        private List<Figure> figures;
        private Camera camera;
        private List<Lumiere> lumieres;
        
        public Dessin(List<Figure> figures, Camera camera, List<Lumiere> lumieres)
        {
            this.lumieres = lumieres;
            this.camera = camera;
            this.figures = figures;
        }

        public void Dessiner()
        {
            foreach (var figure in figures)
            {
                Console.Write("- ");
                figure.dessiner();
            }
            Console.Write("- ");
            camera.Allumer();
            foreach (var lumiere in lumieres)
            {
                Console.Write("- ");
                lumiere.Allumer();
            }
        }

        public void Eteindre()
        {
            Console.Write("- ");
            camera.Eteindre();
            foreach (var lumiere in lumieres)
            {
                Console.Write("- ");
                lumiere.Eteindre();
            }
            foreach (var figure in figures)
            {
                Console.Write("- ");
                figure.effacer();
            }
        }

        public IEnumerator<Figure> GetEnumerator()
        {
            return ((IEnumerable<Figure>)figures).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Figure>)figures).GetEnumerator();
        }
    }
}
