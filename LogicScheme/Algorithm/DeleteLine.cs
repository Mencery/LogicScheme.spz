using LogicScheme.ElementForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    class DeleteLine
    {
        public static void delete(List<UserControl> userControls,List<DrawLine> drawedLines, MyUserControl temp)
        {
            Point start;
            for (int i = 0; i < drawedLines.Count; i++)
            {
               start  = drawedLines[i].twoPoints[0].pointStart;
                if (isNeedDelete(drawedLines[i].getPointEnd(), temp))
                {
                   
                    foreach(MyUserControl control in userControls)
                    {
                        if(isNeedDelete(start, control)){
                            Disconect.disconnect(control);
                        }
                    }
                    drawedLines.Remove(drawedLines[i]);
                    i = -1;
                    continue;
                  
                }
               else if(isNeedDelete(start, temp))
                {
                    
                    foreach (MyUserControl control in userControls)
                    {
                        if (isNeedDelete(drawedLines[i].getPointEnd(), control))
                        {
                            Disconect.disconnect(control);
                        }
                    }
                    drawedLines.Remove(drawedLines[i]);
                    i = -1;
                    continue;
                }
            }
            
        }
        private static bool isNeedDelete(Point check, MyUserControl temp)
        {
            Point TempEnd = new Point(temp.Location.X + temp.Size.Width,
                     temp.Location.Y + temp.Size.Height);
            return InDiapason.isInDiapason(temp.Location,
                    TempEnd, check);
        }
    }
}
