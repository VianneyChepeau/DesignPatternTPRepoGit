using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.BAD
{
    public class Calendar
    {
        public List<IPersonne> personnes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void Add(IPersonne personne)
        {
            // n'enverra jamais de mail. Passer toute une IPersonne est inutile... => interface plus petite.
        }
    }
}
