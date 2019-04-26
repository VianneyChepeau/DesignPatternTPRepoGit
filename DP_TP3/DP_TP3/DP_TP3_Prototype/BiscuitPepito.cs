using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_TP3_Prototype
{
    public class BiscuitPepito : Biscuit
    {
        private string typeChocolat;

        public BiscuitPepito(string typeChocolat)
        {
            this.typeChocolat = typeChocolat;
        }

        public override object Clone()
        {
            return (BiscuitPepito)base.clone();
        }

        public override void manger()
        {
            Console.WriteLine("Aïe Pepito au chocolat " + this.typeChocolat + " !");
        }
    }
}