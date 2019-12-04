
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    class GetElementByPosition
    {
        public static bool execute(MouseEventArgs e, UserControl input,UserControl output, RadioButton[] ports)
        {
            int input_x = e.X + input.Location.X;
            int input_y = e.Y + input.Location.Y;
            int x, y;

            for (int i = 0; i < ports.Length; i++)
            {

                x = ports[i].Location.X + output.Location.X;
                y = ports[i].Location.Y + output.Location.Y;

                if (x <= input_x && x + ports[i].Width >= input_x && y <= input_y && y + ports[i].Height >= input_y)
                {
                    if ((input as IElementForm).getIndexOfPortThatConnect() == 0)
                    {
                        (output as IElementForm).getElement().connect(( input as IElementForm).getElement(), true, i - 1);

                    }
                    else if ((input as IElementForm).getIndexOfPortThatConnect() > 0)
                    {
                        (output as IElementForm).getElement().connect((input as IElementForm).getElement(), false,
                            (input as IElementForm).getIndexOfPortThatConnect() - 1);
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                    (input as IElementForm).connectPortChecked();
                    ports[i].Checked = true;
                    return true;
                }

            }
            return false;
        }
    }
}
