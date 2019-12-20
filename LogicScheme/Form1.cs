﻿

using System.Collections.Generic;

using System.Drawing;

using System.Windows.Forms;
using LogicScheme.Algorithm;


namespace LogicScheme
{
    public partial class Form1 : Form
    {
        List<UserControl> userControls;
        List<DrawLine> drawedLines;
        DrawLine drawLine = new DrawLine();

        public Form1()
        {
            userControls = new List<UserControl>();
            drawedLines = new List<DrawLine>();
            InitializeComponent();
           userControls.Add(signalBoxTrue1);
            userControls.Add(signalBoxFalse1);
            
        }
        /// <summary>
        /// Method to create illustrated element  on the button  at the point at which the cursor were at the moment mouse up
        /// </summary>
        /// <param name="sender"> button1 </param>
        /// <param name="e"> parameters of mouse event</param>
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            var or = new OrElement();

            СreateElement.create(this, or, userControls, e.X + button1.Location.X, e.Y);


        }


        bool isClicked = false;
        /// <summary>
        /// start of paint connection line 
        /// </summary>
        /// <param name="sender">logic element</param>
        /// <param name="e">parameters of mouse event</param>
        public void element_MouseDown(object sender, MouseEventArgs e)
        {

         
                drawLine = new DrawLine();
                drawLine.setStartPoint(e.X + (sender as UserControl).Location.X, e.Y + (sender as UserControl).Location.Y);

                isClicked = true;
            
        }
        /// <summary>
        /// painting connection line 
        /// </summary>
        /// <param name="sender">logic element</param>
        /// <param name="e">parameters of mouse event</param>
        public void element_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                drawLine.draw(e.X + (sender as UserControl).Location.X, e.Y + (sender as UserControl).Location.Y);
                Invalidate();
            }
        }
        /// <summary>
        /// end of painting connection line and create connection, if logic element found, else delete line
        /// </summary>
        /// <param name="sender">logic element</param>
        /// <param name="e">parameters of mouse event</param>
        public void element_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            drawLine.save();

            UserControl input = sender as UserControl;
            UserControl output = getElementByPosition(e, input);
            if (output == null)
            {
                drawLine.delete();
                Invalidate();
                return;
            }
            else
            {
                drawedLines.Add(drawLine);
                (output as IElementForm).getElementByPosition(e, input); 
            }



        }
        /// <summary>
        /// find logic element by position
        /// </summary>
        /// <param name="e">parameters of mouse event from   element_MouseUp(object sender, MouseEventArgs e)</param>
        /// <param name="input">input logic element</param>
        /// <returns>found element</returns>
        UserControl getElementByPosition(MouseEventArgs e, UserControl input)
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

        /// <summary>
        /// procces of painting in form
        /// </summary>
        /// <param name="sender">form1</param>
        /// <param name="e"> Paint parameters</param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawLine(pen, drawLine.getPointStart(), drawLine.getPointEnd());
            foreach (var p in drawLine.getTwoPoints())
            {
                e.Graphics.DrawLine(pen, p.pointStart, p.pointEnd);
            }
            foreach (var dl in drawedLines)
            {
                foreach (var p in dl.getTwoPoints())
                {
                    e.Graphics.DrawLine(pen, p.pointStart, p.pointEnd);
                }
            }
        }

        private void signalBoxTrue1_Load(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {

        }

        private void and2in1button_MouseUp(object sender, MouseEventArgs e)
        {
            var and = new AndElement();

            СreateElement.create(this, and, userControls, e.X + and2in1button.Location.X, e.Y);
        }

        private void notbutton_MouseUp(object sender, MouseEventArgs e)
        {
            var not = new NotElement();

            СreateElement.create(this, not, userControls, e.X + notbutton.Location.X, e.Y);
        }

        private void nand2in1button_MouseUp(object sender, MouseEventArgs e)
        {
            var nand = new NandElement();

            СreateElement.create(this, nand, userControls, e.X + nand2in1button.Location.X, e.Y );
        }

        private void nor2in1button_MouseUp(object sender, MouseEventArgs e)
        {
            var nor = new NorElement();

            СreateElement.create(this, nor, userControls, e.X + nor2in1button.Location.X, e.Y);
        }

        private void xor2in1button_MouseUp(object sender, MouseEventArgs e)
        {
            var xor = new XorElement();

            СreateElement.create(this, xor, userControls, e.X + xor2in1button.Location.X, e.Y);
        }
    }
}

