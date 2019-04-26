using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_TP3_Prototype
{
    public class BiscuitPalmito : Biscuit
    {
        private int nombreOreilles;

        public BiscuitPalmito(int nombreOreilles)
        {
            this.nombreOreilles = nombreOreilles;
        }

        public override object Clone()
        {
            return (BiscuitPalmito)base.clone();
        }

        public override void manger()
        {
            Console.WriteLine("Palmito, ça se croque par ses " + this.nombreOreilles +" oreilles !");
        }
    }
}