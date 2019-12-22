using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    class FindElementByPosition
    {
        /// <summary>
        /// find logic element by position
        /// </summary>
        /// <param name="e">parameters of mouse event from   element_MouseUp(object sender, MouseEventArgs e)</param>
        /// <param name="input">input logic element</param>
        /// <returns>found element</returns>
      public static  UserControl GetElementByPosition(List<UserControl> userControls, MouseEventArgs e, UserControl input)
        {
            UserControl userControl = null;
            int input_x = e.X + input.Location.X;
            int input_y = e.Y + input.Location.Y;
            int x, y;
            foreach (var element in userControls)
            {
                x = element.Location.X;
                y = element.Location.Y;
                if (x <= input_x && x + 108 >= input_x && y <= input_y && y + 48 >= input_y)
                {
                    userControl = element;
                }
            }
            return userControl;

        }
    }
}
