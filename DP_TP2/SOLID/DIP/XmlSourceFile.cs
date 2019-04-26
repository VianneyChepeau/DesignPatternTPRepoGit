using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public class XmlSourceFile : IXmlSource
    {
        private string filename;

        public XmlSourceFile(string filename)
        {
            this.filename = filename;
        }

        public void XmlProcessor()
        {
            // TODO: charger le XML depuis le fichier
        }

        public void Processor()
        {
            // Traiter le XML
        }
    }
}