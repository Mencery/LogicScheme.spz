using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Elements
{
    [Serializable]
    [DataContract]
    public class SignalTrue : Element
    {
        public SignalTrue(){
            Output = StdLogicState.True;
            }
        public override void connect(Element outer, bool fromOutputToInput, int indexOfInput = 0)
        {
            outer.Inputs[indexOfInput] = Output;
            outer.execute();
        }
        public override void disconnect()
        {
            Output = StdLogicState.True;
        }
        public override void execute()
        {
            throw new NotImplementedException();
        }
    }
}
