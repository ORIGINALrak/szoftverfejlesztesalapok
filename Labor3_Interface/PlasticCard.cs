using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Interface
{
    internal class PlasticCard : IProperty
    {
        string owner;
        public string Owner { get { return owner; } }

        public PlasticCard(string name)
        {
            owner = name;
        }
    }
}
