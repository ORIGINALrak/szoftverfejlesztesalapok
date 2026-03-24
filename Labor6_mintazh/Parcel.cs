using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6_mintazh
{
    public enum ElhelyezesiModTipus { Arbitrary, Horizontal, Vertical }
    abstract class Parcel : IDeliverable, IComparable
    {
        protected ElhelyezesiModTipus elhelyezesiModTipus;
        public int Weight { get; }
        public string Address { get; }
        public Parcel(ElhelyezesiModTipus elhelyzesiMod, int weight, string address)
        {
            this.elhelyezesiModTipus = elhelyzesiMod;
            Weight = weight;
            Address = address;
        }
        public Parcel(int weight, string address)
        {
            Weight = weight;
            Address = address;
        }
        public abstract double CalculatePrice(bool fromLocker);

        public  int CompareTo(object obj)
        {
            Parcel a = this;
            Parcel b = obj as Parcel;
            if (a.Weight < b.Weight)
            {
                return -1;
            }
            else if (a.Weight > b.Weight)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
