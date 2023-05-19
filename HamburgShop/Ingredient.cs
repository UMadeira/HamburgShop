using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal abstract class Ingredient : IHamburg
    {
        protected IHamburg Hamburg { get; set; }

        protected Ingredient(IHamburg hamburg) => Hamburg = hamburg;

        public abstract IHamburg Clone();
    }
}
