﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP3_Factory
{
    public class GareFactory : ProprieteFactory
    {
        public override Propriete creerPropriete()
        {
            return new Gare();
        }
    }
}
