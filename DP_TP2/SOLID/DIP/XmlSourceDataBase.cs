using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public class XmlSourceDataBase : IXmlSource
    {
        private string connString;

        public XmlSourceDataBase(string connString)
        {
            this.connString = connString;
        }

        public void XmlProcessor()
        {
            // TODO: charger le XML depuis la base de données
        }

        public void Processor()
        {
            // Traiter le XML
        }
    }
}