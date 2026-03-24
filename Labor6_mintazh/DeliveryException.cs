using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6_mintazh
{
    public class DeliveryException : Exception
    {
        public DeliveryException()
            :base("A csomag nem adható fel autómatából!"){ }
    }
}
