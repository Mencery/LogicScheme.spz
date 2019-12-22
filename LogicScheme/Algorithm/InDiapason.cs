using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Algorithm
{
    class InDiapason
    {
       public static bool isInDiapason(Point start, Point end, Point check)
        {
            if (start.X <= check.X && end.X >= check.X && start.Y <= check.Y && end.Y >= check.Y)
            {
                return true;
            }
            return false;
        } 
    }
}
