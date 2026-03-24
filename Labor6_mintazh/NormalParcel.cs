using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6_mintazh
{
    internal class NormalParcel : Parcel
    {
        public int Weight { get; }
        public string Address { get; }
        public NormalParcel(int weight, string address) : base(weight, address)
        {
            Random rnd = new Random();
            this.elhelyezesiModTipus = (ElhelyezesiModTipus)rnd.Next(3);
        }
        public override double CalculatePrice(bool fromLocker)
        {
            if (fromLocker)
            {
                return 500 + Weight - 250;
            }
            else
            {
                return 500 + Weight;
            }
        }
    }
}
