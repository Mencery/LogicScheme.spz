using LogicScheme.Algorithm;
using System.Runtime.Serialization;

namespace LogicScheme.Elements
{
    [DataContract]
    public class Xor2in1 : Element
    {
        public Xor2in1()
        {
            Inputs = new StdLogicState[2];
            Inputs[0] = StdLogicState.X;
            Inputs[1] = StdLogicState.X;
            Output = StdLogicState.X;
        }

        public override void connect(Element outer, bool fromOutputToInput, int indexOfInput = 0)
        {


            Connect.connect(this, outer, fromOutputToInput, indexOfInput);

        }


        public override void execute()
        {
            if (Inputs[0].Equals(Inputs[1]))
            {
                Output = StdLogicState.False;
            }
            else
            {
                Output = StdLogicState.True;
            }
        }
    }
}
