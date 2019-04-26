using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TP1_AppConsole
{
    public class Point : IPositionnable
    {
        private int x;
        private int y;

        public Point() : this(0,0)
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Getter et Setters de IPositionnable;
        public int GetX()
        {
            return this.x;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetY()
        {
            return this.y;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void deplacer(int x, int y)
        {
            this.SetX(x);
            this.SetY(y);
        }
    }
}
