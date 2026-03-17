using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Labor5_Exeptions
{
    public class IngredientStack
    {
        FoodIngredient[] elelmiszerek;

        public IngredientStack(int meret)
        {
            elelmiszerek = new FoodIngredient[meret];
        }

        int FirstNullIndex()
        {
            int i = 0;
            while (i < elelmiszerek.Length && elelmiszerek[i] != null)
            {
                i++;
            }
            return i;
        }

        public bool Empty()
        {
            if(elelmiszerek == null)
            {
                return true;
            }
            if(elelmiszerek.Length == 0)
            {
                return true;
            }
            return (elelmiszerek[0] == null);
        }
        public void Push(FoodIngredient newItem)
        {
            int elsohely = FirstNullIndex();
            if(elsohely == elelmiszerek.Length)
            {
                throw new StackFullException(newItem, this);
            }
            elelmiszerek[elsohely] = newItem;
        }

        public FoodIngredient Pop()
        {
            if (Empty())
            {
                throw new StackEmptyException(this);
            }
            int elsohely = FirstNullIndex();
            FoodIngredient eredmeny = elelmiszerek[elsohely - 1];
            elelmiszerek[elsohely - 1] = null;
            return eredmeny;
        }
        public FoodIngredient Top()
        {
            if (Empty())
            {
                throw new StackEmptyException(this);
            }
            int elsohely = FirstNullIndex();
            FoodIngredient eredmeny = elelmiszerek[elsohely - 1];
            return eredmeny;
        }
    }
}