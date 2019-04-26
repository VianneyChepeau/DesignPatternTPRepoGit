using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public interface IColoriable
    {
        int GetR();
        void SetR(int r);
        int GetG();
        void SetG(int g);
        int GetB();
        void SetB(int b);
        void colorier(int r, int g, int b);
    }
}
