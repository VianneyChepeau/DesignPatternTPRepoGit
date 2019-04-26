using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP
{
    public class Canari : Oiseau, IVollable
    {
        public override void Manger()
        {
            Console.WriteLine("Je suis un canari et je mange...");
        }

        public void Voler()
        {
            Console.WriteLine("Je suis un canari et je vole...");
        }
    }
}