using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Utils
    {   [ThreadStatic]
        public static Random random = new Random();
    }
}
