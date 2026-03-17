using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor5_Exeptions
{
    public class StackFullException : StackExeption
    {
        public FoodIngredient melyikFood { get; }

        public StackFullException(FoodIngredient melyikFood, IngredientStack ingredientStack) : base (ingredientStack, $"Stack is full! {melyikFood}")
        {
            this.melyikFood = melyikFood;
        }
    }
}
