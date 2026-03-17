using Labor5_Exeptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngredientTest
{
    [TestFixture]
    internal class TeszteloOsztaly
    {
        [Test]
        public void ToStringTesztelo()
        {
            FoodIngredient F = new FoodIngredient("tojás", 1, MennyisegEgysegTipus.darab);
            Assert.That(F, Is.Not.Null);
            Assert.That(F.ToString(), Is.EqualTo("A kaja tipusa tojás, mennyisége: 1 darab"));
        }

        [Test]
        public void TestEmpty_WhenNothingIsPushed()
        {
            IngredientStack verem = new IngredientStack(1);
            Assert.That(verem.Empty(), Is.EqualTo(true));
        }

        [Test]
        public void TestEmpty_WhenOneIsPushed()
        {
            IngredientStack verem = new IngredientStack(1);
            Assert.DoesNotThrow(
                () => verem.Push(new FoodIngredient("tojás", 1, MennyisegEgysegTipus.darab)
                )
                );
            Assert.That(verem.Empty(), Is.EqualTo(false));
        }

        [Test]
        public void TestWhenOneIsPushedIntoEmpty()
        {
            IngredientStack verem = new IngredientStack(0);
            Assert.Throws<StackFullException>(
                () => verem.Push(new FoodIngredient("tojás", 1, MennyisegEgysegTipus.darab)
                               )
                );
        }
    }
}
