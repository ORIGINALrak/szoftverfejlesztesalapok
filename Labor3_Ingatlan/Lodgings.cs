using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Ingatlan
{
    internal class Lodgings : Flat, IRent
    {
        public Lodgings(double area, int roomsCount, int inhabitantsCount, int unitPrice) : base(area, roomsCount, 0, unitPrice)
        {
            bookedMonths = 0;
        }

        public int bookedMonths { get; set; }

        public bool IsBooked 
        { 
            get 
            {
                if(this.bookedMonths == 0) return false;
                else return true;
            }
        }

        public bool Book(int months)
        {
            if (IsBooked == false)
            {
                bookedMonths = months;
                return true;
            }
            return false;
        }

        public int GetCost(int months)
        {
            return months * (TotalValue() / 240) / inhabitantsCount;
        }

        public override bool MoviIn(int newInhabitants)
        {
            if(IsBooked) { return false; }

            if(newInhabitants * inhabitantsCount >  8 * roomsCount) { return false; }

            if((newInhabitants * inhabitantsCount)*2 > area) { return false; }

            inhabitantsCount += newInhabitants;

            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $" {bookedMonths} hónapra foglalva";
        }
    }
}
