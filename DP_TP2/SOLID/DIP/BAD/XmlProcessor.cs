using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP.BAD
{
    public enum XmlSource
    {
        Undefined = 0,
        File = 1,
        Database = 2
    }

    class XmlProcessor
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="source">Indique la source de données</param>
        /// <param name="filename">Nom du fichier (si la source est File)</param>
        /// <param name="connString">Chaine de connexion (si la source est Database)</param>
        public XmlProcessor(XmlSource source, string filename, string connString)
        {
            if (source == XmlSource.File)
            {
                // TODO: charger le XML depuis le fichier
            }
            else if (source == XmlSource.Database)
            {
                // TODO: charger le XML depuis la base de données
            }
        }

        public void Process()
        {
            // Traiter le XML
        }
    }
}
