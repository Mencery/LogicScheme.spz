using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme
{
  public abstract class Element
    {
         protected internal StdLogicState Output;
        protected internal StdLogicState[] Inputs;

        /// <summary>
        /// 
        /// </summary>
        public abstract void connect(Element outer,bool fromOutputToInput, int indexOfInput=0);
       
        public abstract void execute();
    }
}
