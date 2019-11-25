using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme
{
    class Or2in1 : IElement
    {
        public State Input1 { get; set; }
        public State Input2 { get; set; }
        public State Output { get; set; }
        public Or2in1()
        {
            Input1 = State.X;
            Input2 = State.X;
            Output = State.X;
        }
        public void connect()
        {
            throw new NotImplementedException();
        }

        public void execute()
        {
            throw new NotImplementedException();
        }
        
    }
}
