using LogicScheme.Serialization.Load;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicScheme.Algorithm
{
    class Load
    {
        public static string FORMAT = "XML files(.xml)|*.xml|JSON files(.json)|*.json";

        public static void execute(Form1 form,List<UserControl> userControls, List<DrawLine> drawedLines)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            ILoad load;
            //openFileDialog.Filter = XML_FORMAT;
            string filePath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                filePath = openFileDialog.FileName;
                load = new LoadXml();

                if (".xml".Equals(filePath.Substring(filePath.Length - 4)))
                {
                    load = new LoadXml();

                }

                else if (".json".Equals(filePath.Substring(filePath.Length - 5)))
                {
                    load = new LoadJSON();
                }

                else
                {
                    throw new InvalidDataException();
                }
                RecoverContext.recovery(form, load.execute(filePath));
            }


           

        }
    }
}
