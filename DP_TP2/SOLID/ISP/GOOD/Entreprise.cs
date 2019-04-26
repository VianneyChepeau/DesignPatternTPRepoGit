using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP
{
    public class Entreprise
    {
        private List<IEmployer> employers;

        public Entreprise(List<IEmployer> employers)
        {
            this.employers = employers;
        }

        public void employer(IEmployer employer)
        {

        }

        public void licencier(IEmployer employer)
        {

        }

        public void produire()
        {

        }
    }
}