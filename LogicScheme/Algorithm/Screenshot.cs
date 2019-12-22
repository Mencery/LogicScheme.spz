using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    class Screenshot

    {
        public static string IMAGE_FORMATS = "Bitmap Image (.bmp)|*.bmp";
        public static void create( Form1 frm)
        {
            Bitmap Image = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(Image, new Rectangle(0, 0, frm.Width, frm.Height));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = IMAGE_FORMATS;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string ImagePath = string.Format(saveFileDialog.FileName, DateTime.Now.Ticks);
            
            Image.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
