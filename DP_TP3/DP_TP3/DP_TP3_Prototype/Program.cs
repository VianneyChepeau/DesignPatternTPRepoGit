using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            MachineABiscuit machineABiscuit = new MachineABiscuit(new BiscuitPalmito(2));

            List<Biscuit> biscuitPalmitos = new List<Biscuit>();
            biscuitPalmitos = machineABiscuit.FairePaquetBiscuit();

            machineABiscuit.setBiscuit(new BiscuitPepito("Lait"));

            List<Biscuit> biscuitPepitos = new List<Biscuit>();
            biscuitPepitos = machineABiscuit.FairePaquetBiscuit();

            foreach (var biscuitPalmito in biscuitPalmitos)
            {
                biscuitPalmito.manger();
            }

            foreach (var biscuitPepito in biscuitPepitos)
            {
                biscuitPepito.manger();
            }

            Console.ReadKey();
        }
    }
}
