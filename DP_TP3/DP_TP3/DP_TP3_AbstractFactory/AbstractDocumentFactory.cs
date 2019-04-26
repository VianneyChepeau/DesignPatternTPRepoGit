using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_TP3_AbstractFactory
{
    public abstract class AbstractDocumentFactory
    {
        public abstract Devis getDevis();
        public abstract Adhesion getAdhesion();
    }
}