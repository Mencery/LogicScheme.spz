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
        public virtual  void disconnect() {
            Output = StdLogicState.X;
            for(int i = 0; i< Inputs.Length; i++)
            {
                Inputs[i] = StdLogicState.X;
            }
        }

        public abstract void execute();
        public StdLogicState getOutput() {
            return Output;
        }
       
       
    }
   
}
