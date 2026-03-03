using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor3_Interface
{
    internal class Macska : IComparable
    {

        public string nev { get; }
        public int ehseg { get; set; }

        public Macska(string nev, int ehseg)
        {
            this.nev = nev;
            this.ehseg = ehseg;
        }

        public int CompareTo(object obj)
        {
            Macska a = this;
            Macska b = obj as Macska;
            if (a.ehseg < b.ehseg) { return -1; }
            else if (a.ehseg > b.ehseg) { return 1; }
            else return 0;
        }

        public override string ToString()
        {
            return this.nev+" ["+this.ehseg+"]";
        }
    }
}
