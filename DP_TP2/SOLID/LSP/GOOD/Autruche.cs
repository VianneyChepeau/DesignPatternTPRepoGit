using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP
{
    public class Autruche : Oiseau
    {
        public override void Manger()
        {
            Console.WriteLine("Je suis une Autruche et je mange...");
        }
    }
}