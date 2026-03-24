using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6_mintazh
{
    public interface IDeliverable
    {
        int Weight { get; }
        string Address { get; }
        double CalculatePrice(bool fromLocker);
    }
}
