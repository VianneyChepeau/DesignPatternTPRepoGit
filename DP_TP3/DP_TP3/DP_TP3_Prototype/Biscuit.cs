using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_TP3_Prototype
{
    public abstract class Biscuit : ICloneable
    {
        public abstract object Clone();
        public object clone()
        {
            return this.MemberwiseClone();
        }
        public abstract void manger();
    }
}