using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3_Prototype
{
    public class MachineABiscuit
    {
        private Biscuit biscuit;
        public MachineABiscuit(Biscuit biscuit)
        {
            this.biscuit = biscuit;
        }

        public void setBiscuit(Biscuit biscuit)
        {
            this.biscuit = biscuit;
        }

        public List<Biscuit> FairePaquetBiscuit()
        {
            List<Biscuit> biscuits = new List<Biscuit>();
            for (int i = 0; i<24; i++)
            {
                biscuits.Add((Biscuit)biscuit.Clone());
            }

            return biscuits;
        }
    }
}
