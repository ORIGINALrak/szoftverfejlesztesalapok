using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6_mintazh
{
    internal class Envelope : IDeliverable
    {
        string description;

        public Envelope(string description, int weight, string address)
        {
            this.description = description;
            Weight = weight;
            Address = address;
        }

        public int Weight { get ; }
        public string Address { get ; }

        public double CalculatePrice(bool fromLocker)
        {
            if (Weight <= 50)
            {
                return 200;
            }
            if (Weight <= 500)
            {
                return 400;
            }
            if (Weight <= 2000)
            {
                return 1000;
            }
            throw new OverweightException();
        }

        public override string ToString()
        {
            return $"Címzett: {Address} / Leírás: {description} / Tömeg: {Weight} g";
        }
    }
}
