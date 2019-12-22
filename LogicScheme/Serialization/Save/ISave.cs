using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicScheme.Serialization
{
    interface ISave
    {
        void execute(string path,List<UserControl> userControls, List<DrawLine> drawedLines);
    }
}
