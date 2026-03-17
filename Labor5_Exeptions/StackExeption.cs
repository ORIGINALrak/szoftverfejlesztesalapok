using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor5_Exeptions
{
    public class StackExeption : Exception
    {
        public IngredientStack melyikVerem { get; }

        public StackExeption(IngredientStack melyikVerem, string message) : base(message)
        {
            this.melyikVerem = melyikVerem;
        }
    }
}
