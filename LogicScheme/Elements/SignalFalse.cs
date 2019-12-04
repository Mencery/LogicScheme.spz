using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Elements
{
    class SignalFalse: Element
    {
        public SignalFalse()
        {
            Output = StdLogicState.False;
        }
        public override void connect(Element outer, bool fromOutputToInput, int indexOfInput = 0)
        {
            outer.Inputs[indexOfInput] = Output;
            outer.execute();
        }

        public override void execute()
        {
            throw new NotImplementedException();
        }
    }
}
