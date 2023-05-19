using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal class CheddarCheeseIngredient : CheeseIngredient
    {
        public CheddarCheeseIngredient(IHamburg hamburg) : base(hamburg)
        {
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(Hamburg.ToString());
            builder.Append("    with Cheddar Cheese");
            return builder.ToString();
        }

        public override IHamburg Clone()
        {
            var hamburg = Hamburg.Clone();
            return new CheddarCheeseIngredient(hamburg);
        }
    }
}
