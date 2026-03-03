using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Ingatlan
{
    internal class Garage : IRealEstate, IRent
    {
        double area;
        int unitPrice;
        bool isHeated;
        int months;
        bool isOccupied;

        public Garage(double area, int unitPrice, bool isHeated, int months, bool isOccupied)
        {
            this.area = area;
            this.unitPrice = unitPrice;
            this.isHeated = isHeated;
            this.months = months;
            this.isOccupied = isOccupied;
        }

        public bool IsBooked
        {
            get
            {
                if (months > 0 || isOccupied)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Book(int months)
        {
            if (IsBooked == false)
            {
                this.months = months;
                return true;
            }
            return false;
        }

        public int GetCost(int months)
        {
            if (isHeated)
            {
                return (int)((TotalValue() / 120.0) * 1.5);
            }
            else
            {
                return (int)((TotalValue() / 120.0));
            }
        }

     

        public int TotalValue()
        {
            return (int)(unitPrice * area);
        }
        public void UpdateOccupied()
        {
            if (isOccupied) {isOccupied = false;}
            else { isOccupied = true;}
        }

        public override string ToString()
        {
            string futott = "fütött";
            if (!isHeated)
            {
                futott = "nem fütött";
            }
            return $"{area} m^2, van kocsi? {isOccupied}, {futott}, {unitPrice} Ft/m^2, {months} hónapra";
        }
    }
}
