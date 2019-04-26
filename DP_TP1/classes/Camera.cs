using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public class Camera : IAllumable
    {
        public void Allumer()
        {
            Console.WriteLine("Allumage de la camera");
        }

        public void Eteindre()
        {
            Console.WriteLine("Extinction de la camera");
        }
    }
}
