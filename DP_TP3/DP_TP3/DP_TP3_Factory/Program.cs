using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            TerrainFactory terrainFactory = new TerrainFactory();
            GareFactory gareFactory = new GareFactory();
            EEFactory eeFactory = new EEFactory();

            List<Propriete> proprietes = new List<Propriete>();
            proprietes.Add(terrainFactory.creerPropriete());
            proprietes.Add(terrainFactory.creerPropriete());
            proprietes.Add(gareFactory.creerPropriete());
            proprietes.Add(eeFactory.creerPropriete());

            foreach (var propriete in proprietes)
            {
                propriete.calculerLoyer();
            }

            Console.ReadKey();
        }
    }
}
