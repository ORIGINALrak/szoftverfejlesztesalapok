using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Interface
{
    internal class BlockedCreditCard : CreditCard, ILostProperty
    {
        DateTime lost;
        public DateTime DateOfLost { get => lost; }

        public BlockedCreditCard(DateTime time, int balance, string owner) : base(balance, owner)
        {
            lost = time;
        }
        public override bool Pay(int amount)
        {
            Console.WriteLine("nem");
            return false;
        }
    }
}
