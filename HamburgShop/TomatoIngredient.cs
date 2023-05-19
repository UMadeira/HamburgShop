using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal class TomatoIngredient : Ingredient
    {
        public TomatoIngredient(IHamburg hamburg) : base(hamburg)
        {
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(Hamburg.ToString());
            builder.Append("    with Tomato");
            return builder.ToString();
        }

        public override IHamburg Clone()
        {
            var hamburg = Hamburg.Clone();
            return new TomatoIngredient(hamburg);
        }

    }
}
