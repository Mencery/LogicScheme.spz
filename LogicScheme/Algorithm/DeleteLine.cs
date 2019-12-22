using LogicScheme.ElementForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Algorithm
{
    class DeleteLine
    {
        public static void delete(List<DrawLine> drawedLines, MyUserControl temp)
        {
            for (int i = 0; i < drawedLines.Count; i++)
            {
                if (InDiapason.isInDiapason(temp.Location,
                    new Point(temp.Location.X + temp.Size.Width,
                    temp.Location.Y + temp.Size.Height), drawedLines[i].getPointEnd()))
                {
                    drawedLines.Remove(drawedLines[i]);
                  
                }
            }
            
        }
    }
}
