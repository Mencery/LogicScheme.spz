using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Algorithm
{
    class Connect
    {
        public static void connect(Element inner, Element outer, bool fromOutputToInput, int indexOfInput)
        {


            if (fromOutputToInput)
            {
                inner.Inputs[indexOfInput] = outer.Output;


            }
            else
            {

                outer.Output = inner.Inputs[indexOfInput];
            }


            inner.execute();

        }
    }
}
