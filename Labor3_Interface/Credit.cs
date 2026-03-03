using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Interface
{
    internal class Credit : IPaymentInstrument
    {
        public int amountOfCredit { get; }

        public bool Pay(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
