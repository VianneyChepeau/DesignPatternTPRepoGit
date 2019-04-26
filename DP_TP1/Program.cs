using DP_TP1_AppConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole_AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            figures.Add(new Cercle(5));
            figures.Add(new Rectangle(new Point()));
            figures.Add(new Carre(new Point()));

            List<Lumiere> lumieres = new List<Lumiere>();
            lumieres.Add(new Lumiere(255, 255, 255));
            lumieres.Add(new Lumiere(200, 150, 20));

            Camera camera = new Camera();


            Dessin dessin = new Dessin(figures, camera, lumieres);

            dessin.Dessiner();
            Console.WriteLine("Appuyez sur une touche pour tout eteindre");
            Console.ReadKey();
            dessin.Eteindre();
            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadKey();
        }
    }
}
