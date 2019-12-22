using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme
{
    [Serializable]
    public abstract class Element
    {
        public StdLogicState Output { get; set; }
        public StdLogicState[] Inputs { get; set; }



        /// <summary>
        /// 
        /// </summary>
        public abstract void connect(Element outer,bool fromOutputToInput, int indexOfInput=0);
       
        public abstract void execute();
        public StdLogicState getOutput() {
            return Output;
        }
       
       
    }
   
}
