using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Ingatlan
{
    internal class FamilyApartment : Flat
    {
        int childrenCount;
        public FamilyApartment(double area, int roomsCount, int inhabitantsCount, int unitPrice) : base(area, roomsCount, 0, unitPrice)
        {
            childrenCount = 0;
        }

        public bool ChildIsBorn()
        {
            if (inhabitantsCount - childrenCount >= 2)
            {
                inhabitantsCount++;
                childrenCount++;
                return true;
            }
            return false;
        }

        public override bool MoviIn(int newInhabitants)
        {
            int numberOfAdults = inhabitantsCount - childrenCount;
            double totalInhabitantsScore = newInhabitants + numberOfAdults + childrenCount / 2.0;

            if(totalInhabitantsScore > roomsCount *2) { return false; }

            if(10 * (numberOfAdults + newInhabitants) + (5 * childrenCount) > area) { return false; }

            inhabitantsCount += newInhabitants;
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
