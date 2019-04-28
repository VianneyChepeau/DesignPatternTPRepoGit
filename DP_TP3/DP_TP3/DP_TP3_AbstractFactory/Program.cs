using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            HTMLDocumentFactory htmlDocFact = new HTMLDocumentFactory();
            htmlDocFact.getAdhesion();
            htmlDocFact.getDevis();
            PdfDocumentFactory pdfDocFact = new PdfDocumentFactory();
            pdfDocFact.getAdhesion();
            pdfDocFact.getDevis();
        }
    }
}
