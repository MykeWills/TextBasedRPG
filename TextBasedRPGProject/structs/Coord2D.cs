using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    public  struct Coord2D
    {
        public int x;
        public int y;
        public Coord2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + ")" + "(" + y + ")";
        }



    }
  
}
