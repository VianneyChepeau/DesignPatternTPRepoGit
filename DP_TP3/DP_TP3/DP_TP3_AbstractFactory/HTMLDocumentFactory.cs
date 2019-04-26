using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_TP3_AbstractFactory
{
    public class HTMLDocumentFactory : AbstractDocumentFactory
    {
        public override Adhesion getAdhesion()
        {
            return new HTMLAdhesion();
        }

        public override Devis getDevis()
        {
            return new HTMLDevis();
        }
    }
}