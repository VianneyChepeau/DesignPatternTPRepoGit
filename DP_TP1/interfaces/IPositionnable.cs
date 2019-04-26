using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public interface IPositionnable
    {
        int GetX();
        void SetX(int x);
        int GetY();
        void SetY(int y);
        void deplacer(int x, int y);
    }
}
