using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal abstract class CheeseIngredient : Ingredient
    {
        public CheeseIngredient(IHamburg hamburg) : base(hamburg)
        {
        }
    }
}
