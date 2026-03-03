using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Ingatlan
{
    internal abstract class Flat : IRealEstate
    {
        protected double area;
        protected int roomsCount;
        protected int inhabitantsCount;
        protected int unitPrice;

        public Flat(double area, int roomsCount, int inhabitantsCount, int unitPrice)
        {
            this.area = area;
            this.roomsCount = roomsCount;
            this.inhabitantsCount = inhabitantsCount;
            this.unitPrice = unitPrice;
        }

        public abstract bool MoviIn(int newInhabitants);

        public int TotalValue()
        {
            return (int)(area * unitPrice);
        }

        public int InhabitantsCount { get => inhabitantsCount; }

        public override string ToString()
        {
            return $"{area} m^2, {roomsCount} db szoba, {inhabitantsCount} db lakó, {unitPrice} Ft/m^2";
        }
    }
}
