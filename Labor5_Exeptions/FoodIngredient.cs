using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor5_Exeptions
{
    public enum MennyisegEgysegTipus { liter, kilogramm, darab, csomag}
    public class FoodIngredient
    {
        string nev;
        double mennyiseg;
        MennyisegEgysegTipus mennyisegEgyseg;

        public FoodIngredient(string nev, double mennyiseg, MennyisegEgysegTipus mennyisegEgyseg)
        {
            this.nev = nev;
            this.mennyiseg = mennyiseg;
            this.mennyisegEgyseg = mennyisegEgyseg;

        }
        public MennyisegEgysegTipus MennyisegEgyseg { get => mennyisegEgyseg; }
        public string Nev { get => nev; set => nev = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public override string ToString()
        {
            return $"A kaja tipusa {nev}, mennyisége: {mennyiseg} {mennyisegEgyseg}";
        }
    }
}
