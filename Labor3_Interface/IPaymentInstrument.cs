using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Interface
{
    internal interface IPaymentInstrument
    {
        bool Pay(int amount);
    }
}
