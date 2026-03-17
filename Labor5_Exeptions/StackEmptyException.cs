using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor5_Exeptions
{
    internal class StackEmptyException : StackExeption
    {
        public StackEmptyException(IngredientStack melyikVerem) :base(melyikVerem, "Empty!")
        {

        }
    }
}
