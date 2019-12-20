using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme
{
    class Or2in1 : Element
    {

       
        
        
        public Or2in1()
        {
            Inputs = new StdLogicState[2];
            Inputs[0] = StdLogicState.X;
            Inputs[1] = StdLogicState.X;
           Output = StdLogicState.X;
        }

        public override void connect(Element outer, bool fromOutputToInput, int indexOfInput = 0)
        {

           
            if (fromOutputToInput) { 
                Inputs[indexOfInput] = outer.Output;

             
                }
            else
            {
              
                outer.Output = Inputs[indexOfInput];
            }

           
            execute();

        }
       

        public override void execute()
        {
           if(StdLogicState.True.Equals(Inputs[0]) ||  StdLogicState.True.Equals(Inputs[1]))
            {
                Output = StdLogicState.True;
            }
            else
            {
                if(!(StdLogicState.X.Equals(Inputs[0]) && StdLogicState.X.Equals(Inputs[1])))
                {
                    Output = StdLogicState.False;
                }
                

              
               
            }
        }
    }
}
