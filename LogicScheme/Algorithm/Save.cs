using LogicScheme.Serialization;
using LogicScheme.Serialization.Save;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    public class Save
    {
        public static string FORMAT = "XML files(.xml)|*.xml|JSON files(.json)|*.json";

        public static void execute(List<UserControl> userControls, List<DrawLine> drawedLines)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FORMAT;
            ISave save;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;

            if (".xml".Equals(filename.Substring(filename.Length - 4)))
            {
                save = new SaveAsXML();
                
            }

            else if(".json".Equals(filename.Substring(filename.Length - 5)))
            {
                save = new SaveAsJSON();
            }
            
            else{
                throw new InvalidDataException();
            }
            save.execute(filename, userControls, drawedLines);


            MessageBox.Show("saved");
        }
    }
}
