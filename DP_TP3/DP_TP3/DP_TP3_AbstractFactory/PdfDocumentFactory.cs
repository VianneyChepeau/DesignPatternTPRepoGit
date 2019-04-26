using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_TP3_AbstractFactory
{
    public class PdfDocumentFactory : AbstractDocumentFactory
    {
        public override Adhesion getAdhesion()
        {
            return new PDFAdhesion();
        }

        public override Devis getDevis()
        {
            return new PDFDevis();
        }
    }
}