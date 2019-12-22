
using LogicScheme.Algorithm;
namespace LogicScheme.Elements
{
    public class And2in1 : Element
    {
        public And2in1()
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
            if (StdLogicState.True.Equals(Inputs[0]) && StdLogicState.True.Equals(Inputs[1]))
            {
                Output = StdLogicState.True;
            }
            else
            {
                if ((StdLogicState.X.Equals(Inputs[0]) || StdLogicState.X.Equals(Inputs[1])))

                {
                    Output = StdLogicState.X;
                }

                Output = StdLogicState.False;


            }
        }
    }
}
