using LogicScheme.SerializationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicScheme.Serialization.Load
{
    interface ILoad
    {
        SerializableContext execute(string path);
    }
}
