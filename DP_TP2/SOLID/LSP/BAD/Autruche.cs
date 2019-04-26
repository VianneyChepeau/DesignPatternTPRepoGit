using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.BAD
{
    public class Autruche : Oiseau
    {
        public override void Voler()
        {
            throw new NotSupportedException();
        }
    }
}
