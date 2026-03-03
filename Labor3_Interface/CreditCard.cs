using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Interface
{
    internal class CreditCard : PlasticCard, IPaymentInstrument
    {
        int balance;

        public CreditCard(int balance, string owner): base(owner)
        {
            this.balance = balance;
        }

        public virtual bool Pay(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }
}
