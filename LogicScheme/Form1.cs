﻿

using LogicScheme.Algorithm;
using LogicScheme.Serialization;
using LogicScheme.Serialization.Load;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace LogicScheme
{
    public partial class Form1 : Form
    {
        public static string XML_FORMAT = "XML files(.xml)|*.xml|all Files(*.*)|*.*";
      
       public List<UserControl> userControls;
        public List<DrawLine> drawedLines;
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
            UserControl output = FindElementByPosition.GetElementByPosition(userControls, e, input);
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

            СreateElement.create(this, nand, userControls, e.X + nand2in1button.Location.X, e.Y);
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

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = XML_FORMAT;

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;


            ISave save = new SaveAsXML();
            save.execute(filename, userControls, drawedLines);
            MessageBox.Show("saved");

        }

        private void loadToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();


                openFileDialog.Filter = XML_FORMAT;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               string filePath = openFileDialog.FileName;
                ILoad load = new LoadXml();
               RecoverContext.recovery(this, load.execute(filePath));
                
            }

        }

        private void signalBoxTrue1_Load(object sender, System.EventArgs e)
        {

        }

        private void screenshotToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Screenshot.create(this);
        }
    }
}

