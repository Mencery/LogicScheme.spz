using LogicScheme.Algorithm;

namespace LogicScheme.Elements
{
    class Not  : Element
    {
        public Not()
        {
            Inputs = new StdLogicState[1];
            Inputs[0] = StdLogicState.X;
          
            Output = StdLogicState.X;
        }

        public override void connect(Element outer, bool fromOutputToInput, int indexOfInput = 0)
        {


            Connect.connect(this, outer, fromOutputToInput, indexOfInput);

        }


        public override void execute()
        {
            switch (Inputs[0])
            {
                case StdLogicState.False:
                    Output = StdLogicState.True;
                    break;
                case StdLogicState.True:
                    Output = StdLogicState.False;
                    break;
                case StdLogicState.X:
                    Output = StdLogicState.X;
                    break;
            }
        }
    }
}

