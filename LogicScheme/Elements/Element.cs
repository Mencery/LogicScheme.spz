using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme
{
    [Serializable]
    [DataContract]
    public abstract class Element
    {
        [DataMember]
        public StdLogicState Output { get; set; }
        [DataMember]
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
