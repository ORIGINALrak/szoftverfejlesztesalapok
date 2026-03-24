using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6_mintazh
{
    internal class FragileParcel : Parcel
    {
        public FragileParcel(int weight, string address) : base(weight, address)
        {
            if (elhelyezesiModTipus == ElhelyezesiModTipus.Arbitrary)
            {
                throw new IncorrectOrientationException();
            }
        }

        public override double CalculatePrice(bool fromLocker)
        {
            if(fromLocker)
            {
                throw new DeliveryException();
            }
            return 1000 + Weight * 2;
        }
    }
}
