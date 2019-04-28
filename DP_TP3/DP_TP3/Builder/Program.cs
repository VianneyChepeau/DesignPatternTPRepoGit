using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouvrier ouvrier = new Ouvrier();
            ouvrier.setVoitureBuilder(new VoitureClioBuilder());
            ouvrier.assemblerVoiture();
            Voiture clioFinale = ouvrier.getVoiture();
            Console.WriteLine("Voiture 1 :");
            Console.WriteLine(clioFinale.type);
            Console.WriteLine(clioFinale.chassis);
            Console.WriteLine(clioFinale.carosserie);
            Console.WriteLine(clioFinale.moteur);

            ouvrier.setVoitureBuilder(new VoitureEspaceBuilder());
            ouvrier.assemblerVoiture();
            Voiture espaceFinale = ouvrier.getVoiture();
            Console.WriteLine("");
            Console.WriteLine("Voiture 2 :");
            Console.WriteLine(espaceFinale.type);
            Console.WriteLine(espaceFinale.chassis);
            Console.WriteLine(espaceFinale.carosserie);
            Console.WriteLine(espaceFinale.moteur);
            Console.ReadKey();
        }
    }
}
