using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace LogicScheme
{
    interface IElementForm
    {

    bool getElementByPosition(MouseEventArgs e, UserControl input);
        int getIndexOfPortThatConnect();
        Element getElement();
        void connectPortChecked();
     }
}
