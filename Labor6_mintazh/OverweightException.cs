using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6_mintazh
{
    public class OverweightException : Exception
    {
        public OverweightException() :base("A küldemény tömege nem haladhatja meg a 2000 grammot!") { }
    }
}
