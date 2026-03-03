using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region macskak
            //Macska[] macskak = new Macska[5];

            //macskak[0] = new Macska("valami", 5);
            //macskak[1] = new Macska("valami2", 6);
            //macskak[2] = new Macska("valami3", 4);
            //macskak[3] = new Macska("valami4", 2);
            //macskak[4] = new Macska("valami5", 10);

            //foreach(Macska macska in macskak)
            //{
            //    Console.WriteLine(macska);
            //}
            //Console.WriteLine();
            //Array.Sort(macskak);
            //foreach (Macska macska in macskak)
            //{
            //    Console.WriteLine(macska);
            //}
            #endregion
            #region penz
            //IPaymentInstrument[] eszkozok = new IPaymentInstrument[5];

            //eszkozok[0] = new CreditCard(80000, "Besenyő István");
            //DateTime time = new DateTime(2020, 01, 01);
            //eszkozok[1] = new BlockedCreditCard(time.AddDays(100), 60000, "Valaki Béla");
            //eszkozok[2] = new BlockedCreditCard(time.AddDays(1000), 40000, "Molnár Valaki");
            //eszkozok[3] = new CreditCard(20000, "Random név");
            //eszkozok[4] = new CreditCard(0, "Csóró");

            //Console.WriteLine(Payment(eszkozok, 20000));
            //Console.WriteLine(SupervisedPayment(eszkozok,10000,"Besenyő István"));
            #endregion
        }
        #region penzmethod
        //public static bool Payment(IPaymentInstrument[] eszkozok, int amount)
        //{
        //    for (int i = 0; i < eszkozok.Length; i++)
        //    {
        //        if (eszkozok[i] != null)
        //        {
        //            if (eszkozok[i].Pay(amount)) { return true; }
        //        }
        //    }
        //    return false;
        //}

        //public static bool SupervisedPayment(IPaymentInstrument[] eszkozok, int amount, string name)
        //{
        //    for (int i = 0; i < eszkozok.Length; i++)
        //    {
        //        if (eszkozok[i] != null && eszkozok[i] is IProperty)
        //        {
        //            if ((eszkozok[i] as IProperty).Owner == name && eszkozok[i].Pay(amount)) return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion
    }

}
