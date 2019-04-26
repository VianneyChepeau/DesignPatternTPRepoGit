using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP4.classes
{
    public class ConcretFiltre
    {
        public bool estPremier(int nombre)
        {
            if ((nombre & 1) == 0)
            {
                if (nombre == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
            for (int i = 3; (i * i) <= nombre; i += 2)
            {
                if ((nombre % i) == 0)
                {
                    return false;
                }
            }
            return nombre != 1;
        }
    }
}
